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
    public partial class FrmSolicitudExamen : Form
    {
		private IInicioSesion sesion;
		private IExamen _examenNegocio;
		private IAuditoria _auditoria = new csAuditoria();

		private int idPacienteSeleccionado;
		private int idMedicoSeleccionado;

		private long? idSolicitudEditar = null;

		public FrmSolicitudExamen(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_examenNegocio = new csExamen();
		}

		public FrmSolicitudExamen(IInicioSesion sesionActiva, long idSolicitud, int idPaciente, string dniPaciente, string nombrePaciente, int? idMedico, string dniMedico, string nombreMedico)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_examenNegocio = new csExamen();

			this.idSolicitudEditar = idSolicitud;
			this.idPacienteSeleccionado = idPaciente;
			this.idMedicoSeleccionado = idMedico ?? 0;
			txtDNIPaciente.Text = dniPaciente;
			txtNombrePaciente.Text = nombrePaciente;
			txtDNIMedico.Text = dniMedico;
			txtNombreMedico.Text = nombreMedico;

			this.Text = "Modificar Solicitud de Examen #" + idSolicitud;
		}

		private void btnAgregarPaciente_Click(object sender, EventArgs e)
		{
			using (FrmPaciente frm = new FrmPaciente(sesion))
			{
				frm.ModoSeleccion = true;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					this.idPacienteSeleccionado = frm.IdInternoPaciente;

					txtDNIPaciente.Text = frm.DniPacienteSeleccionado;
					txtNombrePaciente.Text = frm.NombreCompletoSeleccionado;
				}
			}
		}

		private void btnAgregarMedico_Click(object sender, EventArgs e)
		{
			using (FrmMedicoAfiliado frm = new FrmMedicoAfiliado(sesion))
			{
				frm.ModoSeleccion = true;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					this.idMedicoSeleccionado = frm.IdInternoMedico;

					txtDNIMedico.Text = frm.DniMedicoSeleccionado;
					txtNombreMedico.Text = frm.NombreMedicoSeleccionado;
				}
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (idPacienteSeleccionado <= 0)
				{
					MessageBox.Show("Debe seleccionar un Paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				List<int> examenesElegidos = obtenerExamenesMarcados();

				if (examenesElegidos.Count == 0)
				{
					MessageBox.Show("Debe seleccionar al menos un examen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int resultado;
				int idModuloSolicitud = 3;

				if (idSolicitudEditar == null)
				{
					
					resultado = _examenNegocio.RegistrarNuevaSolicitud(
						idPacienteSeleccionado,
						idMedicoSeleccionado > 0 ? (long?)idMedicoSeleccionado : null,
						"PENDIENTE",
						examenesElegidos
					);

					if (resultado > 0)
					{
						string detalle = $"Nueva Solicitud #{resultado} para el paciente: {txtNombrePaciente.Text}. " +
								 $"Exámenes seleccionados: {examenesElegidos.Count}.";
						_auditoria.RegistrarAuditoria(sesion.IdUsuario, 2, idModuloSolicitud, detalle);
						MessageBox.Show("Solicitud registrada con éxito.", "Éxito");
					}
				}
				else
				{
					
					resultado = _examenNegocio.ModificarSolicitud(
						idSolicitudEditar.Value,
						idPacienteSeleccionado,
						idMedicoSeleccionado > 0 ? (long?)idMedicoSeleccionado : null,
						"PENDIENTE",
						examenesElegidos
					);

					if (resultado == 1)
					{
						string detalle = $"Se modificó la Solicitud #{idSolicitudEditar.Value}. Paciente: {txtNombrePaciente.Text}. " +
								 $"Total exámenes actual: {examenesElegidos.Count}.";
						_auditoria.RegistrarAuditoria(sesion.IdUsuario, 3, idModuloSolicitud, detalle);
						MessageBox.Show("Solicitud actualizada con éxito.", "Éxito");
					}
					else if (resultado == -1) MessageBox.Show("No se puede modificar: La solicitud ya no está PENDIENTE.");
				}

				if (resultado > 0)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmSolicitudExamen_Load(object sender, EventArgs e)
		{
			CargarTodosLosGrids();

			if (idSolicitudEditar != null)
			{
				MarcarExamenesSeleccionados(idSolicitudEditar.Value);
			}
		}

		private void CargarTodosLosGrids()
		{

			dgvEnzimas.DataSource = _examenNegocio.ListarExamenesPorCategoria(1);
			dgvHematologia.DataSource = _examenNegocio.ListarExamenesPorCategoria(2);
			dgvBioquimica.DataSource = _examenNegocio.ListarExamenesPorCategoria(3);
			dgvHormonas.DataSource = _examenNegocio.ListarExamenesPorCategoria(4);
			dgvInmunologia.DataSource = _examenNegocio.ListarExamenesPorCategoria(5);
			dgvElectrolitos.DataSource = _examenNegocio.ListarExamenesPorCategoria(6);
			dgvMarcadoresTumorales.DataSource = _examenNegocio.ListarExamenesPorCategoria(7);
			dgvOrina.DataSource = _examenNegocio.ListarExamenesPorCategoria(8);
			dgvHeces.DataSource = _examenNegocio.ListarExamenesPorCategoria(9);
			dgvDiversos.DataSource = _examenNegocio.ListarExamenesPorCategoria(10);

			FormatearGrids();
		}

		private void FormatearGrids()
		{
			DataGridView[] todosLosGrids = { dgvEnzimas, dgvHematologia, dgvBioquimica, dgvHormonas,
				dgvInmunologia, dgvElectrolitos, dgvMarcadoresTumorales, dgvOrina, dgvHeces, dgvDiversos };

			foreach (var dgv in todosLosGrids)
			{
				var colID = ObtenerColumnaPorDataProperty(dgv, "IDExamen");
				var colCat = ObtenerColumnaPorDataProperty(dgv, "IDCategoria");
				var colExamen = ObtenerColumnaPorDataProperty(dgv, "Examen");
				var colPrecio = ObtenerColumnaPorDataProperty(dgv, "Precio");
				var colCheck = ObtenerColumnaPorDataProperty(dgv, "chkExamen");

				if (colID != null) colID.ReadOnly = true;
				if (colCat != null) colCat.ReadOnly = true;
				if (colExamen != null) colExamen.ReadOnly = true;

				if (colPrecio != null)
				{
					colPrecio.ReadOnly = true; 
					colPrecio.DefaultCellStyle.Format = "N2";
				}

				if (colCheck != null)
				{
					colCheck.ReadOnly = false; 
				}
			}
		}

		private DataGridViewColumn ObtenerColumnaPorDataProperty(DataGridView dgv, string dataPropertyName)
		{
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				if (col.DataPropertyName.Equals(dataPropertyName, StringComparison.OrdinalIgnoreCase))
				{
					return col;
				}
			}
			return null;
		}


		private void MarcarExamenesSeleccionados(long idSolicitud)
		{
			// 1. Obtener la lista de IDs que ya están en la base de datos para esta solicitud
			List<int> idsGuardados = _examenNegocio.ObtenerIdsExamenesPorSolicitud(idSolicitud);

			DataGridView[] todosLosGrids = { dgvEnzimas, dgvHematologia, dgvBioquimica, dgvHormonas,
		dgvInmunologia, dgvElectrolitos, dgvMarcadoresTumorales, dgvOrina, dgvHeces, dgvDiversos };

			foreach (var dgv in todosLosGrids)
			{
				foreach (DataGridViewRow row in dgv.Rows)
				{
					var colID = ObtenerColumnaPorDataProperty(dgv, "IDExamen");
					var colCheck = ObtenerColumnaPorDataProperty(dgv, "chkExamen");

					if (colID != null && row.Cells[colID.Index].Value != null)
					{
						int idExamenFila = Convert.ToInt32(row.Cells[colID.Index].Value);

						// 2. Si el ID de la fila está en la lista de guardados, marcar el CheckBox
						if (idsGuardados.Contains(idExamenFila))
						{
							row.Cells[colCheck.Index].Value = true;
						}
					}
				}
			}
		}

		private List<int> obtenerExamenesMarcados()
		{
			List<int> elegidos = new List<int>();
			DataGridView[] todosLosGrids = { dgvEnzimas, dgvHematologia, dgvBioquimica, dgvHormonas,
				dgvInmunologia, dgvElectrolitos, dgvMarcadoresTumorales, dgvOrina, dgvHeces, dgvDiversos };

			foreach (var dgv in todosLosGrids)
			{
				dgv.EndEdit();
				foreach (DataGridViewRow row in dgv.Rows)
				{
					var colCheck = ObtenerColumnaPorDataProperty(dgv, "chkExamen");
					var colID = ObtenerColumnaPorDataProperty(dgv, "IDExamen");

					if (colCheck != null && Convert.ToBoolean(row.Cells[colCheck.Index].Value) == true)
					{
						elegidos.Add(Convert.ToInt32(row.Cells[colID.Index].Value));
					}
				}
			}
			return elegidos;
		}

		private void btnLimpiarMedico_Click(object sender, EventArgs e)
		{
			this.idMedicoSeleccionado = 0;

			txtDNIMedico.Clear();
			txtNombreMedico.Text = "PARTICULAR";
		}
	}
}
