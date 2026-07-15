using CapaNegocio;
using CapaNegocio.Examen_y_Factura.Interfaces;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
	public partial class FrmRegistroExamen : Form
	{
		private IInicioSesion sesion;
		private IExamen _examenNegocio;
		private long idSolicitudActual;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();

		private Dictionary<int, DataGridView> mapeoGrids;

		private List<TabPage> paginasOriginales = new List<TabPage>();

		public FrmRegistroExamen(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_examenNegocio = new csExamen();
			ConfigurarPermisosIniciales();


			foreach (TabPage pagina in tcResultadoExamen.TabPages)
			{
				paginasOriginales.Add(pagina);
			}

			mapeoGrids = new Dictionary<int, DataGridView> {
			{ 1, dgvEnzimas },
			{ 2, dgvHematologia },
			{ 3, dgvBioquimica },
			{ 4, dgvHormonas },
			{ 5, dgvInmunologia },
			{ 6, dgvElectrolitos },
			{ 7, dgvMarcadoresTumorales },
			{ 8, dgvOrina },
			{ 9, dgvHeces },
			{ 10, dgvDiversos }
			};
		}

		private void ConfigurarPermisosIniciales()
		{
			btnGuardar.Enabled = false;

			btnAgregarSolicitud.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Ver");

		}

		private void btnAgregarSolicitud_Click(object sender, EventArgs e)
		{
			using (FrmSolicitud frm = new FrmSolicitud(sesion))
			{
				frm.ModoSeleccion = true;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					this.idSolicitudActual = frm.IdSolicitudSeleccionada;
					txtSolicitud.Text = idSolicitudActual.ToString();
					txtPaciente.Text = frm.NombrePaciente;
					txtGenero.Text = frm.Genero == 'M' ? "Masculino" : "Femenino";
					txtEdad.Text = CalcularEdad(frm.FechaNacimiento).ToString() + " años";

					CargarParametrosEnGrids();
				}
			}
		}

		private int CalcularEdad(DateTime fechaNacimiento)
		{
			int edad = DateTime.Today.Year - fechaNacimiento.Year;
			if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
			return edad;
		}

		private void CargarParametrosEnGrids()
		{
			DataTable dtParametros = _examenNegocio.ObtenerParametrosParaResultado(idSolicitudActual);
			tcResultadoExamen.TabPages.Clear();

			bool puedeRegistrar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Registrar");
			bool puedeModificar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Modificar");

			bool tieneCeldasVacias = dtParametros.AsEnumerable().Any(r => r["Resultado"] == DBNull.Value || string.IsNullOrWhiteSpace(r["Resultado"].ToString()));
			bool tieneCeldasConDatos = dtParametros.AsEnumerable().Any(r => r["Resultado"] != DBNull.Value && !string.IsNullOrWhiteSpace(r["Resultado"].ToString()));

			btnGuardar.Enabled = (tieneCeldasVacias && puedeRegistrar) || (tieneCeldasConDatos && puedeModificar);

			var mapeoOrdenado = mapeoGrids.OrderBy(x => x.Key);

			foreach (var item in mapeoOrdenado)
			{
				item.Value.DataSource = null;

				DataView view = new DataView(dtParametros);
				view.RowFilter = "IDCat = " + item.Key;

				if (view.Count > 0)
				{
				
					TabPage padreOriginal = paginasOriginales.FirstOrDefault(p => p.Controls.Contains(item.Value));

					if (padreOriginal != null)
					{
						
						tcResultadoExamen.TabPages.Add(padreOriginal);

						item.Value.AutoGenerateColumns = false;
						item.Value.DataSource = view;

						FormatearGridResultado(item.Value);
					}
				}
			}
		}

		private void FormatearGridResultado(DataGridView dgv)
		{

			bool puedeRegistrar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Registrar");
			bool puedeModificar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Modificar");

			foreach (DataGridViewRow row in dgv.Rows)
			{
				DataRowView drv = (DataRowView)row.DataBoundItem;
				bool teniaValorOriginal = drv["Resultado"] != DBNull.Value && !string.IsNullOrWhiteSpace(drv["Resultado"].ToString());

				bool habilitarEdicion = (!teniaValorOriginal && puedeRegistrar) || (teniaValorOriginal && puedeModificar);

				ConfigurarCelda(row, "Resultado", habilitarEdicion);
				ConfigurarCelda(row, "ValorReferencia", habilitarEdicion);
			}
		}

		private void ConfigurarCelda(DataGridViewRow fila, string propiedad, bool habilitar)
		{
			var celda = ObtenerCeldaPorPropiedad(fila, propiedad);
			if (celda != null)
			{
				celda.ReadOnly = !habilitar; 


				celda.Style.BackColor = habilitar ? Color.White : Color.FromArgb(235, 235, 235);

				celda.Style.ForeColor = habilitar ? Color.Black : Color.Gray;
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (idSolicitudActual <= 0) return;

			bool puedeRegistrar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Registrar");
			bool puedeModificar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Registro Examen", "Modificar");


			try
			{
				int exitos = 0;
				int denegados = 0;

				foreach (TabPage pagina in tcResultadoExamen.TabPages)
				{
					DataGridView dgv = BuscarDGV(pagina);

					if (dgv != null && dgv.DataSource != null)
					{
						dgv.EndEdit();
						foreach (DataGridViewRow row in dgv.Rows)
						{

							DataRowView drv = (DataRowView)row.DataBoundItem;
							bool teniaValorOriginal = drv["Resultado"] != DBNull.Value && !string.IsNullOrWhiteSpace(drv["Resultado"].ToString());

							var celdaRes = ObtenerCeldaPorPropiedad(row, "Resultado");
							var celdaParam = ObtenerCeldaPorPropiedad(row, "IDParam");
							var celdaRef = ObtenerCeldaPorPropiedad(row, "ValorReferencia");

							if (celdaRes != null && celdaRes.Value != null && !string.IsNullOrWhiteSpace(celdaRes.Value.ToString()))
							{
								string valorNuevo = celdaRes.Value.ToString().Trim();
								string valorOriginal = teniaValorOriginal ? drv["Resultado"].ToString().Trim() : "";

								
								if (!teniaValorOriginal && !puedeRegistrar)
								{
									denegados++;
									continue;
								}

	
								if (teniaValorOriginal && valorNuevo != valorOriginal && !puedeModificar)
								{
									denegados++;
									continue;
								}

								if (celdaParam != null && celdaParam.Value != DBNull.Value)
								{
									long idParam = Convert.ToInt64(celdaParam.Value);
									string vRef = celdaRef?.Value?.ToString().Trim() ?? "";

									_examenNegocio.GuardarResultado(idSolicitudActual, idParam, sesion.IdUsuario, valorNuevo, vRef);
									exitos++;
								}
							}
						}
					}
				}

				if (exitos > 0)
				{
					int idModuloRegistro = 4;

					string detalle = $"Se procesaron y guardaron {exitos} parámetros clínicos para la Solicitud #{idSolicitudActual} (Paciente: {txtPaciente.Text}).";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, 2, idModuloRegistro, detalle);

					string msj = $"Se procesaron {exitos} resultados.";
					if (denegados > 0) msj += $"\n({denegados} cambios fueron omitidos por falta de permisos).";

					MessageBox.Show(msj, "Operación Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (denegados > 0)
				{
					MessageBox.Show("No se guardaron cambios. No tiene los permisos suficientes para las acciones realizadas.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("No se han ingresado resultados para guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar resultados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private DataGridView BuscarDGV(Control parent)
		{
			if (parent is DataGridView dgv) return dgv;
			foreach (Control child in parent.Controls)
			{
				DataGridView res = BuscarDGV(child);
				if (res != null) return res;
			}
			return null;
		}

		private DataGridViewCell ObtenerCeldaPorPropiedad(DataGridViewRow fila, string propiedad)
		{
			foreach (DataGridViewColumn col in fila.DataGridView.Columns)
			{
				if (col.DataPropertyName.Equals(propiedad, StringComparison.OrdinalIgnoreCase))
				{
					return fila.Cells[col.Index];
				}
			}
			return null;
		}

		private void RestablecerFormulario()
		{
			idSolicitudActual = 0;

			txtSolicitud.Clear();
			txtPaciente.Clear();
			txtGenero.Clear();
			txtEdad.Clear();

			tcResultadoExamen.TabPages.Clear();
			foreach (TabPage pagina in paginasOriginales)
			{
				tcResultadoExamen.TabPages.Add(pagina);
			}

			foreach (var info in mapeoGrids)
			{
				info.Value.DataSource = null;
			}

			if (tcResultadoExamen.TabPages.Count > 0)
			{
				tcResultadoExamen.SelectedIndex = 0;
			}

			btnGuardar.Enabled = false;
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			RestablecerFormulario();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			if (idSolicitudActual <= 0)
			{
				MessageBox.Show("Por favor, seleccione una solicitud primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				
				DataTable dt = _examenNegocio.ObtenerDatosReporte(idSolicitudActual);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("No se encontraron resultados registrados para generar el reporte.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				LocalReport reporte = new LocalReport();

				reporte.ReportPath = Path.Combine(Application.StartupPath, "Examen y Factura", "rptResultados.rdlc");

				reporte.DataSources.Add(new ReportDataSource("dsResultadosExamen", dt));

		
				string deviceInfo =
					@"<DeviceInfo>
                <OutputFormat>PDF</OutputFormat>
                <PageWidth>21cm</PageWidth>
                <PageHeight>29.7cm</PageHeight>
                <MarginTop>0,5cm</MarginTop>
                <MarginLeft>0,5cm</MarginLeft>
                <MarginRight>0,5cm</MarginRight>
                <MarginBottom>0,5cm</MarginBottom>
            </DeviceInfo>";

				byte[] pdfBytes = reporte.Render("PDF", deviceInfo);

				string carpetaMediLab = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MediLab");

		
				if (!Directory.Exists(carpetaMediLab))
				{
					Directory.CreateDirectory(carpetaMediLab);
				}

				string nombrePaciente = dt.Rows[0]["Paciente"].ToString();
				string apellido = nombrePaciente.Split(' ').Last();
				string nombreArchivo = $"Solicitud_{idSolicitudActual}_{apellido}.pdf";

				string rutaCompleta = Path.Combine(carpetaMediLab, nombreArchivo);

				File.WriteAllBytes(rutaCompleta, pdfBytes);

	
				Process.Start(new ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al generar o abrir el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}

		private void btnEnviarCorreo_Click(object sender, EventArgs e)
		{
			if (idSolicitudActual <= 0)
			{
				MessageBox.Show("Seleccione una solicitud válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
		
				DataTable dt = _examenNegocio.ObtenerDatosReporte(idSolicitudActual);
				if (dt == null || dt.Rows.Count == 0) return;

				string correoDestino = dt.Rows[0]["CORREO_ELECTRONICO"]?.ToString();
				string nombrePaciente = dt.Rows[0]["Paciente"].ToString();

				if (string.IsNullOrEmpty(correoDestino))
				{
					MessageBox.Show("El paciente no tiene un correo registrado.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				
				LocalReport reporte = new LocalReport();
				reporte.ReportPath = Path.Combine(Application.StartupPath, "Examen y Factura", "rptResultados.rdlc");
				reporte.DataSources.Add(new ReportDataSource("dsResultadosExamen", dt));

				byte[] pdfBytes = reporte.Render("PDF");

				string carpetaMediLab = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MediLab");
				if (!Directory.Exists(carpetaMediLab)) Directory.CreateDirectory(carpetaMediLab);

				string rutaPDF = Path.Combine(carpetaMediLab, $"Envio_{idSolicitudActual}_{nombrePaciente.Split(' ').Last()}.pdf");
				File.WriteAllBytes(rutaPDF, pdfBytes);

				
				_examenNegocio.EnviarCorreoReporte(correoDestino, nombrePaciente, rutaPDF, idSolicitudActual);

				MessageBox.Show($"¡Reporte enviado con éxito a {correoDestino}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al procesar el envío: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
