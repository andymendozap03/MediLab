using CapaNegocio;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using Microsoft.Reporting.WinForms;
using Sunny.UI;
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
    public partial class FrmLaboratorio : Form
    {
		private IInicioSesion sesion;
        private IReporte reporte;

		public FrmLaboratorio(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
            reporte = new csReporte();
        }

		private void FrmLaboratorio_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region Funciones

        private void Limpiar()
        {
            DesmarcarFiltros();
            lblTipoFiltro.Text = "General";
            lblTipoReporte.Text = "";
            nudAno.Value = DateTime.Now.Year;
            cmbMes.SelectedIndex = -1;
            cmbDiaSem.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(1);
            mnuCantidad.Checked = false;
            mnuSolicitados.Checked = false;
            cmbTipoReporte.SelectedIndex = -1;
            pnlFiltro.Enabled = false;
            pnlIntervalo.Enabled = false;
            dtpDesde.Checked = false;
            dtpHasta.Checked = false;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            rbIntervalo.Checked = false;
            rbFiltro.Checked = false;
            this.rvLaboratorio.RefreshReport();
            msAgrupar.Enabled = false;
            msAgrupar.Visible = false;
            lblFiltro.Visible = false;
            lblTipoFiltro.Visible = false;

            // limpiar reportviewer
            rvLaboratorio.Reset();
            rvLaboratorio.LocalReport.DataSources.Clear();
            rvLaboratorio.RefreshReport();
        }

        private void DesmarcarFiltros()
        {
            mnuAno.Checked = false;
            mnuMes.Checked = false;
            mnuDiaSemana.Checked = false;
            mnuHora.Checked = false;
        }

        #endregion

        // TIPOS DE REPORTES SELECCIONADOS 0 Y 1
        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbTipoReporte.SelectedIndex = 0;
            lblTipoReporte.Text = "Cantidad de examenes realizados (Todos los examenes)";
            msAgrupar.Enabled = true;
            msAgrupar.Visible = true;
            lblFiltro.Visible = true;
            lblTipoFiltro.Visible = true;
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbTipoReporte.SelectedIndex = 1;
            lblTipoReporte.Text = "Examenes más solicitados";
            msAgrupar.Enabled = false;
            msAgrupar.Visible = false;
            lblFiltro.Visible = false;
            lblTipoFiltro.Visible = false;
        }

        // AGRUPAR POR AÑO
        private void mnuAno_Click(object sender, EventArgs e)
        {
            DesmarcarFiltros();
            mnuAno.Checked = true;
            lblTipoFiltro.Text = "Año";
        }

        // AGRUPAR POR MES
        private void mnuMes_Click(object sender, EventArgs e)
        {
            DesmarcarFiltros();
            mnuMes.Checked = true;
            lblTipoFiltro.Text = "Mes";
        }

        // AGRUPAR POR DIA DE LA SEMANA
        private void mnuDiaSemana_Click(object sender, EventArgs e)
        {
            DesmarcarFiltros();
            mnuDiaSemana.Checked = true;
            lblTipoFiltro.Text = "Día de semana";
        }

        // AGRUPAR POR HORA
        private void mnuHora_Click(object sender, EventArgs e)
        {
            DesmarcarFiltros();
            mnuHora.Checked = true;
            lblTipoFiltro.Text = "Hora";
        }


        // BOTON GENERAR REPORTE
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            //----------------------------------- Condiciones para index == 0

            if(cmbTipoReporte.SelectedIndex == 0)
            {
                if (reporte == null)
                {
                    MessageBox.Show("El servicio de reportes no está inicializado.");
                    return;
                }


                // -------- AGRUPAR POR (MenuStrip) --------

                string agruparPor = "GENERAL";

                if (mnuAno.Checked)
                {
                    agruparPor = "ANO";
                }
                else if (mnuMes.Checked)
                {
                    agruparPor = "MES";
                }
                else if (mnuDiaSemana.Checked)
                {
                    agruparPor = "DIASEMANA";
                }
                else if (mnuHora.Checked)
                {
                    agruparPor = "HORA";
                }

                // -------- FILTROS --------

                int? ano = nudAno.Value > 0 ? (int?)nudAno.Value : null;

                int? mes = cmbMes.SelectedIndex >= 0
                    ? (int?)cmbMes.SelectedIndex + 1
                    : null;

                int? diaSemana = cmbDiaSem.SelectedIndex >= 0
                    ? (int?)cmbDiaSem.SelectedIndex + 1
                    : null;

                DateTime? desde = dtpDesde.Checked
                    ? (DateTime?)dtpDesde.Value
                    : null;

                DateTime? hasta = dtpHasta.Checked
                    ? (DateTime?)dtpHasta.Value
                    : null;


                // -------- LLAMAR CAPA NEGOCIO --------

                DataTable dt = reporte.ObtenerReporteCantidadExamenes(
                    agruparPor,
                    ano,
                    mes,
                    diaSemana,
                    desde,
                    hasta
                );

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el filtro seleccionado.");
                    return;
                }

                // -------- CARGAR REPORTVIEWER --------

                rvLaboratorio.Reset();
                rvLaboratorio.ProcessingMode = ProcessingMode.Local;

                rvLaboratorio.LocalReport.DataSources.Clear();

                rvLaboratorio.LocalReport.ReportEmbeddedResource =
                    "CapaPresentacion.Reportes_y_Auditoria.rptCantidadExamen.rdlc";

                ReportDataSource rds =
                    new ReportDataSource("dsReportesLaboratorio", dt);

                rvLaboratorio.LocalReport.DataSources.Add(rds);

                ReportParameter rpTipoReporte =
                    new ReportParameter("TipoReporte", lblTipoReporte.Text);

                rvLaboratorio.LocalReport.SetParameters(rpTipoReporte);

                rvLaboratorio.RefreshReport();
            }

            else if (cmbTipoReporte.SelectedIndex == 1)
            {
                if (reporte == null)
                {
                    MessageBox.Show("El servicio de reportes no está inicializado.");
                    return;
                }


                // -------- AGRUPAR POR (MenuStrip) --------

                string agruparPor = "GENERAL";

                if (mnuAno.Checked)
                {
                    agruparPor = "ANO";
                }
                else if (mnuMes.Checked)
                {
                    agruparPor = "MES";
                }
                else if (mnuDiaSemana.Checked)
                {
                    agruparPor = "DIASEMANA";
                }
                else if (mnuHora.Checked)
                {
                    agruparPor = "HORA";
                }

                // -------- FILTROS --------

                int? ano = nudAno.Value > 0 ? (int?)nudAno.Value : null;

                int? mes = cmbMes.SelectedIndex >= 0
                    ? (int?)cmbMes.SelectedIndex + 1
                    : null;

                int? diaSemana = cmbDiaSem.SelectedIndex >= 0
                    ? (int?)cmbDiaSem.SelectedIndex + 1
                    : null;

                DateTime? desde = dtpDesde.Checked
                    ? (DateTime?)dtpDesde.Value
                    : null;

                DateTime? hasta = dtpHasta.Checked
                    ? (DateTime?)dtpHasta.Value
                    : null;


                // -------- LLAMAR CAPA NEGOCIO --------

                DataTable dt = reporte.ObtenerReporteExamenesMasSolicitados(
                    agruparPor,
                    ano,
                    mes,
                    diaSemana,
                    desde,
                    hasta
                );

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el filtro seleccionado.");
                    return;
                }

                // -------- CARGAR REPORTVIEWER --------

                rvLaboratorio.Reset();
                rvLaboratorio.ProcessingMode = ProcessingMode.Local;

                rvLaboratorio.LocalReport.DataSources.Clear();

                rvLaboratorio.LocalReport.ReportEmbeddedResource =
                    "CapaPresentacion.Reportes_y_Auditoria.rptExamenesMasSolicitados.rdlc";

                ReportDataSource rds =
                    new ReportDataSource("dtExamenesMasSolicitados", dt);

                rvLaboratorio.LocalReport.DataSources.Add(rds);

                ReportParameter rpTipoReporte =
                    new ReportParameter("TipoReporte", lblTipoReporte.Text);

                rvLaboratorio.LocalReport.SetParameters(rpTipoReporte);

                rvLaboratorio.RefreshReport();
                }

            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rbFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltro.Checked)
            {
                pnlFiltro.Enabled = true;
                pnlIntervalo.Enabled = false;

                dtpDesde.Checked = false;
                dtpHasta.Checked = false;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;

                nudAno.Value = DateTime.Now.Year;
                cmbMes.SelectedIndex = -1;
                cmbDiaSem.SelectedIndex = -1;
                nudAno.Enabled = true;
                cmbMes.Enabled = true;
                cmbDiaSem.Enabled = true;
            }
        }

        private void rbIntervalo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIntervalo.Checked)
            {
                pnlFiltro.Enabled = false;
                pnlIntervalo.Enabled = true;

                dtpDesde.Checked = true;
                dtpHasta.Checked = true;
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;

                nudAno.Value = DateTime.Now.Year;
                cmbMes.SelectedIndex = -1;
                cmbDiaSem.SelectedIndex = -1;
                nudAno.Enabled = false;
                cmbMes.Enabled = false;
                cmbDiaSem.Enabled = false;
            }
        }
    }
}
