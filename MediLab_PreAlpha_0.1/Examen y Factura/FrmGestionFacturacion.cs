using CapaNegocio;
using CapaNegocio.Examen_y_Factura.Interfaces;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using CapaPresentacion.Examen_y_Factura;
using CapaPresentacion.Formularios;
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

namespace CapaDatos
{
    public partial class FrmGestionFacturacion : Form
    {
		private IInicioSesion sesion;
        private IExamen _examenNegocio;
        private IFactura _facturaNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();
		private long idFacturaActual;

        public FrmGestionFacturacion(IInicioSesion sesionActiva)
		{
			InitializeComponent();
            dgvGestionFactura.AutoGenerateColumns = false;
            dgvGestionFactura.DataSource = null;
            sesion = sesionActiva;
            _examenNegocio = new csExamen();
            _facturaNegocio = new csFactura();
			ConfigurarPermisosIniciales();
			dgvGestionFactura.ClearSelection();
			chkFecha_CheckedChanged(null, null);
		}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (FrmFacturacion frm = new FrmFacturacion(sesion))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarFacturas();
                }
            }
        }

		private void ConfigurarPermisosIniciales()
		{
			btnAgregar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Facturacion", "Registrar");
            btnAnular.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Facturacion", "Eliminar");
            btnReactivar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Facturacion", "Modificar");

		}

		private void CargarFacturas()
        {
            dgvGestionFactura.DataSource = _facturaNegocio.ListarFacturas();
            dgvGestionFactura.ClearSelection();
        }

        private void FrmGestionFacturacion_Load(object sender, EventArgs e)
        {
            dgvGestionFactura.AutoGenerateColumns = false;
            CargarFacturas();
            dgvGestionFactura.ClearSelection();

        }

        private void AplicarFiltros()
        {
            int? idFactura = string.IsNullOrWhiteSpace(txtIDFactura.Text)
                ? (int?)null
                : Convert.ToInt32(txtIDFactura.Text);

            int? idSolicitud = string.IsNullOrWhiteSpace(txtSolicitud.Text)
                ? (int?)null
                : Convert.ToInt32(txtSolicitud.Text);

            string dni = txtDNI.Text.Trim();

            DateTime? desde = chkFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = chkFecha.Checked ? dtpHasta.Value.Date : (DateTime?)null;

            dgvGestionFactura.DataSource = _facturaNegocio
                .BuscarFacturas(idFactura, idSolicitud, dni, desde, hasta);

            dgvGestionFactura.ClearSelection();
        }

        private void txtIDFactura_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtSolicitud_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
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
            txtSolicitud.Clear();
            txtIDFactura.Clear();
            txtDNI.Clear();
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
			chkFecha.Checked = false;
			CargarFacturas();
		}

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (idFacturaActual <= 0)
            {
                MessageBox.Show("Por favor, seleccione una factura primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = _facturaNegocio.ObtenerDatosFactura(idFacturaActual);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para generar la factura.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LocalReport reporte = new LocalReport();
                string rutaRdlc = Path.Combine(Application.StartupPath, "Examen y Factura", "rptFactura.rdlc");

                if (!File.Exists(rutaRdlc))
                {
                    MessageBox.Show($"No se encontró el archivo RDLC: {rutaRdlc}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reporte.ReportPath = rutaRdlc;
                reporte.DataSources.Clear();
                reporte.DataSources.Add(new ReportDataSource("dsFacturacion", dt));

                string deviceInfo =
                    @"<DeviceInfo>
                <OutputFormat>PDF</OutputFormat>
                <PageWidth>21cm</PageWidth>
                <PageHeight>29.7cm</PageHeight>
                <MarginTop>0.5cm</MarginTop>
                <MarginLeft>0.5cm</MarginLeft>
                <MarginRight>0.5cm</MarginRight>
                <MarginBottom>0.5cm</MarginBottom>
            </DeviceInfo>";

                byte[] pdfBytes = reporte.Render("PDF", deviceInfo);

                string carpetaMediLab = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MediLab");
                if (!Directory.Exists(carpetaMediLab))
                    Directory.CreateDirectory(carpetaMediLab);

                string nombrePaciente = dt.Rows[0]["Paciente"].ToString();
                string apellido = nombrePaciente.Split(' ').Last();
                string nombreArchivo = $"Factura_{idFacturaActual}_{apellido}.pdf";

                string rutaCompleta = Path.Combine(carpetaMediLab, nombreArchivo);

                File.WriteAllBytes(rutaCompleta, pdfBytes);
                Process.Start(new ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar o abrir la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGestionFactura_SelectionChanged(object sender, EventArgs e)
        {
			if (dgvGestionFactura.CurrentRow != null && dgvGestionFactura.SelectedRows.Count > 0)
			{
				idFacturaActual = Convert.ToInt64(dgvGestionFactura.CurrentRow.Cells["IDFACTURA"].Value);

	
				string estadoReal = dgvGestionFactura.CurrentRow.Cells["ESTADO"].Value.ToString().Trim().ToUpper();



				btnAnular.Enabled = (estadoReal == "A") &&
									 _permisosNegocio.ValidarAcceso(sesion.IdRol, "Facturacion", "Eliminar");

				btnReactivar.Enabled = (estadoReal == "N") &&
										_permisosNegocio.ValidarAcceso(sesion.IdRol, "Facturacion", "Modificar");
			}
			else
			{

				idFacturaActual = 0;
				btnAnular.Enabled = false;
				btnReactivar.Enabled = false;
			}
		}

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (idFacturaActual <= 0) return;

			string nombres = dgvGestionFactura.CurrentRow.Cells["Nombres"].Value?.ToString() ?? "";
			string apellidos = dgvGestionFactura.CurrentRow.Cells["Apellidos"].Value?.ToString() ?? "";
			string pacienteCompleto = (nombres + " " + apellidos).Trim();

			var confirm = MessageBox.Show("¿Desea anular esta factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _facturaNegocio.AnularFactura(idFacturaActual);
					int idModuloFacturacion = 8;
					int idAccionEliminar = 4;
					string detalle = $"Se anuló la Factura #{idFacturaActual} del paciente: {pacienteCompleto}.";
					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccionEliminar, idModuloFacturacion, detalle);

					MessageBox.Show("Factura anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarFacturas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al anular la factura: " + ex.Message);
                }
            }
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (idFacturaActual <= 0) return;
			string nombres = dgvGestionFactura.CurrentRow.Cells["Nombres"].Value?.ToString() ?? "";
			string apellidos = dgvGestionFactura.CurrentRow.Cells["Apellidos"].Value?.ToString() ?? "";
			string pacienteCompleto = (nombres + " " + apellidos).Trim();

			var confirm = MessageBox.Show("¿Desea reactivar esta factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _facturaNegocio.ReactivarFactura(idFacturaActual);
					int idModuloFacturacion = 8;
					int idAccionModificar = 3;
					string detalle = $"Se reactivó la Factura #{idFacturaActual} del paciente: {pacienteCompleto}.";
					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccionModificar, idModuloFacturacion, detalle);

					MessageBox.Show("Factura reactivada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarFacturas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al reactivar la factura: " + ex.Message);
                }
            }
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (idFacturaActual <= 0)
            {
                MessageBox.Show("Seleccione una solicitud válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                DataTable dt = _facturaNegocio.ObtenerDatosFactura(idFacturaActual);
                if (dt == null || dt.Rows.Count == 0) return;

                string correoDestino = dt.Rows[0]["CORREO_ELECTRONICO"]?.ToString();
                string nombrePaciente = dt.Rows[0]["Paciente"].ToString();

                if (string.IsNullOrEmpty(correoDestino))
                {
                    MessageBox.Show("El paciente no tiene un correo registrado.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                LocalReport reporte = new LocalReport();
                reporte.ReportPath = Path.Combine(Application.StartupPath, "Examen y Factura", "rptFactura.rdlc");
                reporte.DataSources.Add(new ReportDataSource("dsFacturacion", dt));

                byte[] pdfBytes = reporte.Render("PDF");

                string carpetaMediLab = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MediLab");
                if (!Directory.Exists(carpetaMediLab)) Directory.CreateDirectory(carpetaMediLab);

                string rutaPDF = Path.Combine(carpetaMediLab, $"Envio_{idFacturaActual}_{nombrePaciente.Split(' ').Last()}.pdf");
                File.WriteAllBytes(rutaPDF, pdfBytes);


                _facturaNegocio.EnviarCorreoFactura(correoDestino, nombrePaciente, rutaPDF, idFacturaActual);

                MessageBox.Show($"¡Reporte enviado con éxito a {correoDestino}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el envío: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void txtIDFactura_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; 
			}
		}

		private void txtSolicitud_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void dgvGestionFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvGestionFactura.Columns[e.ColumnIndex].Name == "ESTADO" && e.Value != null)
			{
				string estado = e.Value.ToString().Trim().ToUpper();

				if (estado == "A")
				{
					e.Value = "Activa";
				}
				else if (estado == "N")
				{
					e.Value = "Anulada";
					e.CellStyle.ForeColor = Color.Red; 
				}

				e.FormattingApplied = true;
			}
		}

		private void FrmGestionFacturacion_Click(object sender, EventArgs e)
		{
			dgvGestionFactura.ClearSelection();
		}

		private void dgvGestionFactura_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dgvGestionFactura.ClearSelection();
		}

		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
