using CapaNegocio;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using CapaPresentacion.Reportes_y_Auditoria;
using Microsoft.Reporting.WinForms;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmFinanciero : Form
    {
		private IInicioSesion sesion;
        private IReporte reporte;

        public FrmFinanciero(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
            reporte = new csReporte();
        }

		private void FrmFinanciero_Load(object sender, EventArgs e)
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
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(1);
            mnuPeriodo.Checked = false;
            mnuTipo.Checked = false;
            mnuCuentas.Checked = false;

            cmbTipoReporte.SelectedIndex = -1;
            pnlFiltro.Enabled = false;
            pnlIntervalo.Enabled = false;
            dtpDesde.Checked = false;
            dtpHasta.Checked = false;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            rbIntervalo.Checked = false;
            rbFiltro.Checked = false;
            this.rvFinanciero.RefreshReport();
            msAgrupar.Enabled = false;
            msAgrupar.Visible = false;
            lblFiltro.Visible = false;
            lblTipoFiltro.Visible = false;

            // limpiar reportviewer
            rvFinanciero.Reset();
            rvFinanciero.LocalReport.DataSources.Clear();
            rvFinanciero.RefreshReport();
        }

        private void DesmarcarFiltros()
        {
            mnuAno.Checked = false;
            mnuMes.Checked = false;
            mnuDiaSemana.Checked = false;
            mnuHora.Checked = false;
        }

        #endregion


        #region Botones Menu

        //Seleccion de Tipos de reportes 0, por default el cmbFiltros va ser = 0
        private void ingresosPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbTipoReporte.SelectedIndex = 0;
            lblTipoReporte.Text = "Ingresos por periodo";
            msAgrupar.Enabled = true;
            msAgrupar.Visible = true;
            lblFiltro.Visible = true;
            lblTipoFiltro.Visible = true;
        }

        //Seleccion de Tipos de reportes 1, Reporte Cuentas por cobrar
        private void mnuTipo_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbTipoReporte.SelectedIndex = 1;
            lblTipoReporte.Text = "Ingresos por tipo Examen";
            msAgrupar.Enabled = false;
            msAgrupar.Visible = false;
            lblFiltro.Visible = false;
            lblTipoFiltro.Visible = false;
        }

        //Seleccion de Tipos de reportes 2, Reporte Cuentas por cobrar
        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbTipoReporte.SelectedIndex = 2;
            lblTipoReporte.Text = "Cuentas por cobrar";
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

        //AGRUPAR POR MES
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



        #endregion

        // Boton para generar el Reporte
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipoReporte.SelectedIndex == 0)
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

                DataTable dt = reporte.ObtenerReporteIngresosPeriodo(
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

                rvFinanciero.Reset();
                rvFinanciero.ProcessingMode = ProcessingMode.Local;

                rvFinanciero.LocalReport.DataSources.Clear();

                rvFinanciero.LocalReport.ReportEmbeddedResource =
                    "CapaPresentacion.Reportes_y_Auditoria.rptIngresoPeriodo.rdlc";

                ReportDataSource rds =
                    new ReportDataSource("dtIngresoPeriodo", dt);

                rvFinanciero.LocalReport.DataSources.Add(rds);

                ReportParameter rpTipoReporte =
                    new ReportParameter("TipoReporte", lblTipoReporte.Text);

                rvFinanciero.LocalReport.SetParameters(rpTipoReporte);

                rvFinanciero.RefreshReport();
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

                DataTable dt = reporte.ObtenerReporteIngresosPorExamen(
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

                rvFinanciero.Reset();
                rvFinanciero.ProcessingMode = ProcessingMode.Local;

                rvFinanciero.LocalReport.DataSources.Clear();

                rvFinanciero.LocalReport.ReportEmbeddedResource =
                    "CapaPresentacion.Reportes_y_Auditoria.rptIngresoTipoExamen.rdlc";

                ReportDataSource rds =
                    new ReportDataSource("dtIngresoTipoExamen", dt);

                rvFinanciero.LocalReport.DataSources.Add(rds);

                ReportParameter rpTipoReporte =
                    new ReportParameter("TipoReporte", lblTipoReporte.Text);

                rvFinanciero.LocalReport.SetParameters(rpTipoReporte);

                rvFinanciero.RefreshReport();
            }

            else if (cmbTipoReporte.SelectedIndex == 2)
            {
                if (reporte == null)
                {
                    MessageBox.Show("El servicio de reportes no está inicializado.");
                    return;
                }

                // ===== LLAMAR CAPA NEGOCIO =====

                int tipoFiltro = 0;

                DataTable dt = reporte.ObtenerReporteCuentasPorCobrar(
                    tipoFiltro
                );

                // ===== CARGAR REPORTVIEWER =====

                rvFinanciero.Reset();
                rvFinanciero.ProcessingMode = ProcessingMode.Local;

                rvFinanciero.LocalReport.DataSources.Clear();

                rvFinanciero.LocalReport.ReportEmbeddedResource =
                    "CapaPresentacion.Reportes_y_Auditoria.rptCuentasPorCobrar.rdlc";

                ReportDataSource rds =
                    new ReportDataSource("dtCuentasPorCobrar", dt);

                rvFinanciero.LocalReport.DataSources.Add(rds);

                ReportParameter rpTipoReporte =
                    new ReportParameter("TipoReporte", lblTipoReporte.Text);

                rvFinanciero.LocalReport.SetParameters(rpTipoReporte);

                rvFinanciero.RefreshReport();
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
