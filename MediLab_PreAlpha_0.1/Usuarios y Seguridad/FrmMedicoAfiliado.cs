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
	public partial class FrmMedicoAfiliado : Form
	{
		private IInicioSesion sesion;
		private IMedico _medicoNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();

		public int IdInternoMedico { get; private set; } 
		public string DniMedicoSeleccionado { get; private set; }
		public string NombreMedicoSeleccionado { get; private set; }
		public bool ModoSeleccion { get; set; } = false;

		public FrmMedicoAfiliado(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_medicoNegocio = new csMedico();
			ConfigurarPermisosIniciales();
			dgvMedicos.AutoGenerateColumns = false;
			CargarMedicos();
			DeshabilitarAcciones();
		}

		private void ConfigurarPermisosIniciales()
		{
			btnAgregar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Medicos", "Registrar");

		}

		private void CargarMedicos()
		{

			dgvMedicos.DataSource = _medicoNegocio.ListarMedicos();
			dgvMedicos.ClearSelection();
		}

		private void btnAgregar_Click_1(object sender, EventArgs e)
		{
			FrmGestionMedico frm = new FrmGestionMedico(sesion);
			if (frm.ShowDialog() == DialogResult.OK) CargarMedicos();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgvMedicos.SelectedRows.Count == 0) return;

			DataGridViewRow fila = dgvMedicos.SelectedRows[0];

			csMedico medicoEditar = new csMedico
			{
				IdMedico = Convert.ToInt32(fila.Cells["ID"].Value),
				IdPersona = Convert.ToInt32(fila.Cells["IDPersona"].Value),
				DNIpersona = fila.Cells["DNI"].Value.ToString(),
				NombrePersona = fila.Cells["Nombres"].Value.ToString(),
				ApellidoPersona = fila.Cells["Apellidos"].Value.ToString(),
				IdEspecialidad = Convert.ToInt32(fila.Cells["IDEspecialidad"].Value),
				EspecialidadMedico = fila.Cells["Especialidad"].Value.ToString(),
				Comision = Convert.ToDouble(fila.Cells["Comision"].Value),
				FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value),
				Genero = Convert.ToChar(fila.Cells["Genero"].Value),
				Correo = fila.Cells["CorreoElectronico"].Value.ToString(),
				Telefono = fila.Cells["Telefono"].Value.ToString(),
				Direccion = fila.Cells["Direccion"].Value.ToString()
			};

			FrmGestionMedico frm = new FrmGestionMedico(sesion, medicoEditar);
			if (frm.ShowDialog() == DialogResult.OK) CargarMedicos();
		}

	
		private void AplicarFiltros()
		{
			char? genero = null;
			if (rbHombre.Checked) genero = 'M';
			else if (rbMujer.Checked) genero = 'F';

			dgvMedicos.DataSource = _medicoNegocio.BuscarMedico(
				txtBNombres.Text.Trim(),
				txtBApellidos.Text.Trim(),
				txtBDNI.Text.Trim(),
				genero,
				txtBEspecialidad.Text.Trim(),
				chkFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null,
				chkFecha.Checked ? dtpHasta.Value.Date : (DateTime?)null
			);

			dgvMedicos.ClearSelection();
		}


		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			
		}

		private void DeshabilitarAcciones()
		{
			btnModificar.Enabled = btnEliminar.Enabled = false;
		}

		private void HabilitarAcciones()
		{
			int idRol = sesion.IdRol;
			btnModificar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Medicos", "Modificar");
			btnEliminar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Medicos", "Eliminar");
		}

	


		private void btnVolver_Click(object sender, EventArgs e) => this.Close();

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

		private void txtBEspecialidad_TextChanged(object sender, EventArgs e)
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

		private void chkFecha_CheckedChanged_1(object sender, EventArgs e)
		{
			dtpDesde.Enabled = dtpHasta.Enabled = chkFecha.Checked;
			AplicarFiltros();
		}

		private void FrmMedicoAfiliado_Load_1(object sender, EventArgs e)
		{
			
		}

		private void FrmMedicoAfiliado_Click(object sender, EventArgs e)
		{
			DeshabilitarAcciones();
			dgvMedicos.ClearSelection();
		}

		private void dgvMedicos_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvMedicos.SelectedRows.Count > 0) HabilitarAcciones();
			else DeshabilitarAcciones();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvMedicos.SelectedRows.Count == 0) return;

			DataGridViewRow fila = dgvMedicos.SelectedRows[0];
			string dniMed = fila.Cells["DNI"].Value.ToString().Trim();
			string nombreMed = fila.Cells["Nombres"].Value.ToString().Trim() + " " + fila.Cells["Apellidos"].Value.ToString().Trim();

			long idMedico = Convert.ToInt64(dgvMedicos.SelectedRows[0].Cells["ID"].Value);

			if (MessageBox.Show("¿Está seguro de eliminar al médico seleccionado?", "Confirmar",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{

					int resultado = _medicoNegocio.EliminarMedico(idMedico);

					if (resultado == 1)
					{
						int idModuloMedico = 2;
						string detalle = $"Se eliminó al médico con DNI: {dniMed}. Nombre: {nombreMed} (ID Medico: {idMedico})";

						_auditoria.RegistrarAuditoria(sesion.IdUsuario, 4, idModuloMedico, detalle);

						MessageBox.Show("Médico eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarMedicos();
					}
					else if (resultado == -1)
					{
						MessageBox.Show("No se puede eliminar el médico porque tiene exámenes o facturas asociadas.",
										"Restricción de integridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLimpiar_Click_1(object sender, EventArgs e)
		{
			txtBNombres.Clear();
			txtBApellidos.Clear();
			txtBDNI.Clear();
			txtBEspecialidad.Clear();
			rbHombre.Checked = rbMujer.Checked = chkFecha.Checked = false;
			dtpDesde.Value = dtpHasta.Value = DateTime.Today;
			CargarMedicos();
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (dgvMedicos.SelectedRows.Count > 0)
			{
				DataGridViewRow fila = dgvMedicos.SelectedRows[0];


				IdInternoMedico = Convert.ToInt32(fila.Cells["ID"].Value); 
				DniMedicoSeleccionado = fila.Cells["DNI"].Value.ToString().Trim();
				NombreMedicoSeleccionado = fila.Cells["Nombres"].Value.ToString().Trim() + " " +
										   fila.Cells["Apellidos"].Value.ToString().Trim();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Debe seleccionar un médico de la tabla.", "Aviso");
			}
		}

		private void dgvMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (ModoSeleccion && e.RowIndex >= 0)
			{
				btnInsertar_Click(null, null);
			}
		}

		private void btnVolver_Click_1(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void FrmMedicoAfiliado_Load(object sender, EventArgs e)
		{
			chkFecha_CheckedChanged_1(null, null);
			dgvMedicos.ClearSelection();

			if (ModoSeleccion)
			{
				btnInsertar.Visible = true;
				btnVolver.Visible = true;

			}
			else
			{
				btnInsertar.Visible = false;
				btnVolver.Visible = false;
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

		private void txtBEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
