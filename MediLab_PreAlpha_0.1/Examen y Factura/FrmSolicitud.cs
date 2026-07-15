using CapaNegocio;
using CapaNegocio.Examen_y_Factura.Interfaces;
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
	public partial class FrmSolicitud : Form
	{
		private IInicioSesion sesion;
		private IExamen _examenNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();

		public bool ModoSeleccion { get; set; } = false;
		public long IdSolicitudSeleccionada { get; private set; }
		public string NombrePaciente { get; private set; }
		public char Genero { get; private set; }
		public DateTime FechaNacimiento { get; private set; }

		public FrmSolicitud(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;

			_examenNegocio = new csExamen();
			ConfigurarPermisosIniciales();

			CargarSolicitudes();
			dgvSolicitudes.AutoGenerateColumns = false;

			DeshabilitarAcciones();
		}


		private int? _idPacienteFiltro;



		public FrmSolicitud(IInicioSesion sesionActiva, int? idPaciente = null)
		{
			InitializeComponent();

			sesion = sesionActiva;
			_examenNegocio = new csExamen();
			_idPacienteFiltro = idPaciente;


			ConfigurarPermisosIniciales();
			dgvSolicitudes.AutoGenerateColumns = false;

			CargarSolicitudes();

			DeshabilitarAcciones();
		}


		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmSolicitudExamen frm = new FrmSolicitudExamen(sesion);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				CargarSolicitudes();
			}
		}

		private void ConfigurarPermisosIniciales()
		{
			btnAgregar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Solicitudes", "Registrar");

		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgvSolicitudes.SelectedRows.Count == 0) return;

			DataGridViewRow fila = dgvSolicitudes.SelectedRows[0];

			long idSolicitud = Convert.ToInt64(fila.Cells["ID"].Value);
			int idPaciente = Convert.ToInt32(fila.Cells["IDPersona"].Value);
			string dniPac = fila.Cells["DNIPaciente"].Value.ToString();
			string nomPac = fila.Cells["Paciente"].Value.ToString();

			
			int? idMed = fila.Cells["IDMedico"].Value != DBNull.Value ? (int?)Convert.ToInt32(fila.Cells["IDMedico"].Value) : null;

			
			string dniMed = fila.Cells["DNIMedico"].Value != null ? fila.Cells["DNIMedico"].Value.ToString() : "";
			string nomMed = fila.Cells["Medico"].Value.ToString();

			
			FrmSolicitudExamen frm = new FrmSolicitudExamen(sesion, idSolicitud, idPaciente, dniPac, nomPac, idMed, dniMed, nomMed);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				CargarSolicitudes();
			}
		}

		private void CargarSolicitudes()
		{
			if (_idPacienteFiltro.HasValue)
				dgvSolicitudes.DataSource = _examenNegocio.ListarSolicitudesHistorial(_idPacienteFiltro.Value);
			else
				dgvSolicitudes.DataSource = _examenNegocio.ListarSolicitudes();
		}

		private void FrmSolicitud_Load(object sender, EventArgs e)
		{
			chkFecha_CheckedChanged(null, null);
			CargarSolicitudes();

			dgvSolicitudes.ClearSelection();

			if (ModoSeleccion)
			{

				btnInsertar.Visible = true;
				btnVolver.Visible = true;
				btnInsertar.Enabled = false;

			}
			else
			{

				btnInsertar.Visible = false;
				btnVolver.Visible = false;

				btnAgregar.Visible = true;
				btnModificar.Visible = true;
				btnEliminar.Visible = true;
			}
		}

		private void DeshabilitarAcciones()
		{
			btnModificar.Enabled = false;
			btnEliminar.Enabled = false;
			if (ModoSeleccion) btnInsertar.Enabled = false;
		}

		private void HabilitarAcciones()
		{
			int idRol = sesion.IdRol;
			btnModificar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Solicitudes", "Modificar");
			btnEliminar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Solicitudes", "Eliminar");
			if (ModoSeleccion) btnInsertar.Enabled = true;
		}

		private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSolicitudes.SelectedRows.Count > 0)
				HabilitarAcciones();
			else
				DeshabilitarAcciones();
		}

		private void dgvSolicitudes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				dgvSolicitudes.ClearSelection();
				DeshabilitarAcciones();
			}
		}

		private void FrmSolicitud_Click(object sender, EventArgs e)
		{
			dgvSolicitudes.ClearSelection();
			DeshabilitarAcciones();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvSolicitudes.SelectedRows.Count == 0)
			{
				MessageBox.Show("Seleccione una solicitud para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DataGridViewRow fila = dgvSolicitudes.SelectedRows[0];

			string pacienteNombre = fila.Cells["Paciente"].Value.ToString();
			long idSolicitud = Convert.ToInt64(dgvSolicitudes.SelectedRows[0].Cells["ID"].Value);
			string estado = dgvSolicitudes.SelectedRows[0].Cells["Estado"].Value.ToString().Trim();

			if (estado != "PENDIENTE")
			{
				MessageBox.Show("Solo se pueden eliminar solicitudes en estado PENDIENTE.", "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			DialogResult confirmacion = MessageBox.Show(
				"¿Está seguro de eliminar la solicitud #" + idSolicitud + "? Esta acción borrará también todos los exámenes asociados.",
				"Confirmar eliminación",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (confirmacion == DialogResult.Yes)
			{
				try
				{
					int resultado = _examenNegocio.EliminarSolicitud(idSolicitud);

					if (resultado == 1)
					{
						int idModuloSolicitud = 3;
						string detalle = $"Se eliminó la Solicitud #{idSolicitud} perteneciente al paciente: {pacienteNombre}.";
						_auditoria.RegistrarAuditoria(sesion.IdUsuario, 4, idModuloSolicitud, detalle);
						MessageBox.Show("Solicitud eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarSolicitudes();
					}
					else if (resultado == -1)
					{
						MessageBox.Show("No se puede eliminar la solicitud porque ya no está PENDIENTE.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						MessageBox.Show("Ocurrió un error al intentar eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void AplicarFiltros()
		{
			
			string dni = txtBDNI.Text.Trim();
			string nombre = txtBNombres.Text.Trim();

			
			DateTime? desde = chkFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
			DateTime? hasta = chkFecha.Checked ? dtpHasta.Value.Date : (DateTime?)null;

			dgvSolicitudes.DataSource = _examenNegocio.BuscarSolicitudes(dni, nombre, desde, hasta);
			dgvSolicitudes.ClearSelection();
		}

		private void txtBDNI_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void txtBNombres_TextChanged(object sender, EventArgs e)
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

		private void chkFecha_CheckedChanged(object sender, EventArgs e)
		{
			dtpDesde.Enabled = dtpHasta.Enabled = chkFecha.Checked;
			AplicarFiltros();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBDNI.Clear();
			txtBNombres.Clear();
			chkFecha.Checked = false;
			dtpDesde.Value = DateTime.Today;
			dtpHasta.Value = DateTime.Today;
			CargarSolicitudes();
		}

		private void dgvSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (ModoSeleccion && e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgvSolicitudes.Rows[e.RowIndex];

				DataRowView drv = (DataRowView)fila.DataBoundItem;

				IdSolicitudSeleccionada = Convert.ToInt64(drv["ID"]);
				NombrePaciente = drv["Paciente"].ToString();
				Genero = Convert.ToChar(drv["Genero"]);
				FechaNacimiento = Convert.ToDateTime(drv["FechaNacimiento"]);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (dgvSolicitudes.SelectedRows.Count > 0)
			{
				DataGridViewRow fila = dgvSolicitudes.SelectedRows[0];

				DataRowView drv = (DataRowView)fila.DataBoundItem;

				IdSolicitudSeleccionada = Convert.ToInt64(drv["ID"]);
				NombrePaciente = drv["Paciente"].ToString();
				Genero = Convert.ToChar(drv["Genero"]);
				FechaNacimiento = Convert.ToDateTime(drv["FechaNacimiento"]);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Por favor, seleccione una solicitud de la lista.", "Aviso");
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void txtBDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtBNombres_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
