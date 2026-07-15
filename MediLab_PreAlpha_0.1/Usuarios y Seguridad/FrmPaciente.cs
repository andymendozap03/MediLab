using CapaNegocio;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmPaciente : Form
    {
		private IInicioSesion sesion;
		private IPaciente _pacienteNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();

		public int IdInternoPaciente { get; private set; }
		public string DniPacienteSeleccionado { get; private set; }
		public string NombreCompletoSeleccionado { get; private set; }
		public bool ModoSeleccion { get; set; } = false;

		public FrmPaciente(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_pacienteNegocio = new csPaciente();
			CargarPacientes();
			dgvPacientes.AutoGenerateColumns = false;
			DeshabilitarAcciones();
			ConfigurarPermisosIniciales();
		}
		private void FrmPaciente_Load(object sender, EventArgs e)
		{
			ConfigurarPermisosIniciales();
			dgvPacientes.ClearSelection();
			chkFecha_CheckedChanged(null, null);

			if (ModoSeleccion)
			{

				btnInsertar.Visible = true;
				btnVolver.Visible = true;


				btnInsertar.Enabled = true;
				btnVolver.Enabled = true;
			}
			else
			{
				btnInsertar.Visible = false;
				btnVolver.Visible = false;

				btnAgregar.Visible = true;
				btnModificar.Visible = true;
				btnEliminar.Visible = true;
			}
			dgvPacientes.ClearSelection();
		}

		private void ConfigurarPermisosIniciales()
		{
			btnAgregar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Pacientes", "Registrar");

		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			csPaciente pacienteSeleccionado = ObtenerPacienteSeleccionado();

			if (pacienteSeleccionado == null)
				return;

			FrmGestionPaciente frmGestionPaciente = new FrmGestionPaciente(sesion, pacienteSeleccionado);

			if (frmGestionPaciente.ShowDialog() == DialogResult.OK)
			{
				CargarPacientes();
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmGestionPaciente frmGestionPaciente = new FrmGestionPaciente(sesion);

			if (frmGestionPaciente.ShowDialog() == DialogResult.OK)
			{
				CargarPacientes();
			}

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvPacientes.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Seleccione un paciente",
					"Advertencia",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			DataGridViewRow fila = dgvPacientes.SelectedRows[0];
			string dniPaciente = fila.Cells["DNI"].Value.ToString();
			string nombrePaciente = fila.Cells["Nombres"].Value.ToString() + " " + fila.Cells["Apellidos"].Value.ToString();

			long idPersona = Convert.ToInt64(
				dgvPacientes.SelectedRows[0].Cells["ID"].Value
			);

			DialogResult confirmacion = MessageBox.Show(
				"¿Está seguro de eliminar el paciente seleccionado?",
				"Confirmar eliminación",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (confirmacion != DialogResult.Yes)
				return;

			try
			{
				int resultado = _pacienteNegocio.EliminarPaciente(idPersona);

				if (resultado == 1)
				{
					int idModuloPaciente = 1;
					string detalle = $"Se eliminó al paciente con DNI: {dniPaciente}. Nombre: {nombrePaciente} (ID: {idPersona})";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, 4, idModuloPaciente, detalle);

					MessageBox.Show(
						"Paciente eliminado correctamente",
						"Eliminación exitosa",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);

					CargarPacientes(); 
				}
				else if (resultado == -1)
				{
					MessageBox.Show(
						"No se puede eliminar el paciente porque tiene registros relacionados",
						"Eliminación no permitida",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
				else
				{
					MessageBox.Show(
						"No se pudo eliminar el paciente",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void CargarPacientes()
		{
			dgvPacientes.DataSource = _pacienteNegocio.ListarPacientes();
			dgvPacientes.ClearSelection();
		}

		private void DeshabilitarAcciones()
		{
			btnModificar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void HabilitarAcciones()
		{
			int idRol = sesion.IdRol;
			btnModificar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Pacientes", "Modificar");
			btnEliminar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Pacientes", "Eliminar");
		}

		private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvPacientes.SelectedRows.Count > 0)
			{
				HabilitarAcciones();
				if (ModoSeleccion) btnInsertar.Visible = true;
			}
			else
			{
				DeshabilitarAcciones();
				btnInsertar.Visible = false;
			}
		}

		private void FrmPaciente_Click(object sender, EventArgs e)
		{
			dgvPacientes.ClearSelection();
			DeshabilitarAcciones();
		}

		private void dgvPacientes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				dgvPacientes.ClearSelection();
				DeshabilitarAcciones();
			}
		}


		private csPaciente ObtenerPacienteSeleccionado()
		{
			if (dgvPacientes.SelectedRows.Count == 0)
				return null;

			DataGridViewRow fila = dgvPacientes.SelectedRows[0];

			csPaciente paciente = new csPaciente
			{
				IdPersona = Convert.ToInt32(fila.Cells["ID"].Value),
				DNIpersona = fila.Cells["DNI"].Value.ToString(),
				NombrePersona = fila.Cells["Nombres"].Value.ToString(),
				ApellidoPersona = fila.Cells["Apellidos"].Value.ToString(),
				FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value),
				Genero = Convert.ToChar(fila.Cells["Genero"].Value),
				Correo = fila.Cells["CorreoElectronico"].Value.ToString(),
				Telefono = fila.Cells["Telefono"].Value.ToString(),
				Direccion = fila.Cells["Direccion"].Value.ToString()
			};

			return paciente;
		}

		private void AplicarFiltros()
		{

			char? genero = null;

			if (rbHombre.Checked) genero = 'M';
			else if (rbMujer.Checked) genero = 'F';

			dgvPacientes.DataSource = _pacienteNegocio.BuscarPaciente(
				txtBNombres.Text.Trim(),
				txtBApellidos.Text.Trim(),
				txtBDNI.Text.Trim(),
				genero,
				chkFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null,
				chkFecha.Checked ? dtpHasta.Value.Date : (DateTime?)null
			);

			dgvPacientes.ClearSelection();
		}

		private void txtBNombres_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void txtBApellidos_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void txtBDNI_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void rbMujer_CheckedChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void rbHombre_CheckedChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void dtpDesde_ValueChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void dtpHasta_ValueChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBNombres.Clear();
			txtBApellidos.Clear();
			txtBDNI.Clear();
			rbHombre.Checked = false;
			rbMujer.Checked = false;

			dtpDesde.Value = DateTime.Today;
			dtpHasta.Value = DateTime.Today;

			CargarPacientes();
		}

		private void chkFecha_CheckedChanged(object sender, EventArgs e)
		{
			if (chkFecha.Checked)
			{
				dtpDesde.Enabled = true;
				dtpHasta.Enabled = true;
				AplicarFiltros();
			}
			else
			{
				dtpDesde.Enabled = false;
				dtpHasta.Enabled = false;
				AplicarFiltros();
			}
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (dgvPacientes.SelectedRows.Count > 0)
			{
				DataGridViewRow fila = dgvPacientes.SelectedRows[0];

		
				IdInternoPaciente = Convert.ToInt32(fila.Cells["ID"].Value);
				DniPacienteSeleccionado = fila.Cells["DNI"].Value.ToString().Trim();
				NombreCompletoSeleccionado = fila.Cells["Nombres"].Value.ToString().Trim() + " " +
											 fila.Cells["Apellidos"].Value.ToString().Trim();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un paciente de la lista.");
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (ModoSeleccion && e.RowIndex >= 0)
			{
				btnInsertar_Click(null, null);
			}
		}

		private void txtBNombres_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtBApellidos_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtBDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
