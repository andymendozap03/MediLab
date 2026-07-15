using CapaNegocio;
using CapaNegocio.Examen_y_Factura.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
	public partial class FrmHistorialExamen : Form
	{
		private int idPacienteActual;
		private IExamen _examenNegocio = new csExamen();
		private IInicioSesion sesion;

		public FrmHistorialExamen(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
		}

		private void FrmHistorialExamen_Load(object sender, EventArgs e)
		{
			rbExamen.Checked = true;

		}

		private void rbExamen_CheckedChanged(object sender, EventArgs e)
		{
			if (rbExamen.Checked)
			{
				spcContenedor.Panel2Collapsed = true;

				spcContenedor.Panel1Collapsed = false;
			}
		}

		private void rbComparar_CheckedChanged(object sender, EventArgs e)
		{
			if (rbComparar.Checked)
			{
				spcContenedor.Panel2Collapsed = false;
				spcContenedor.Panel1Collapsed = false;

				spcContenedor.SplitterDistance = spcContenedor.Width / 2;
			}
		}

		private void btnAgregarPaciente_Click(object sender, EventArgs e)
		{
			FrmPaciente frm = new FrmPaciente(sesion);
			frm.ModoSeleccion = true;

			if (frm.ShowDialog() == DialogResult.OK)
			{
				if (this.idPacienteActual != frm.IdInternoPaciente)
				{
					LimpiarReportes();
				}

				this.idPacienteActual = frm.IdInternoPaciente;
				txtDNIPaciente.Text = frm.DniPacienteSeleccionado;
				txtNombrePaciente.Text = frm.NombreCompletoSeleccionado;

				btnSeleccionarExamen1.Enabled = true;
				btnSeleccionarExamen2.Enabled = true;
			}
		}

		private void btnSeleccionarExamen1_Click(object sender, EventArgs e)
		{
			FrmSolicitud frm = new FrmSolicitud(sesion, idPacienteActual);
			frm.ModoSeleccion = true;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				MostrarReporte(rpvExamen1, frm.IdSolicitudSeleccionada);
			}
		}

		private void btnSeleccionarExamen2_Click(object sender, EventArgs e)
		{
			FrmSolicitud frm = new FrmSolicitud(sesion, idPacienteActual);
			frm.ModoSeleccion = true;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				MostrarReporte(rpvExamen2, frm.IdSolicitudSeleccionada);
			}
		}

		private void MostrarReporte(Microsoft.Reporting.WinForms.ReportViewer rpv, long idSolicitud)
		{
			try
			{
				DataTable dt = _examenNegocio.ObtenerDatosReporte(idSolicitud);
				rpv.LocalReport.DataSources.Clear();
				rpv.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Examen y Factura", "rptResultados.rdlc");
				rpv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsResultadosExamen", dt));
				rpv.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar reporte: " + ex.Message);
			}
		}


		private void LimpiarReportes()
		{
			rpvExamen1.LocalReport.DataSources.Clear();
			rpvExamen1.RefreshReport();

			rpvExamen2.LocalReport.DataSources.Clear();
			rpvExamen2.RefreshReport();

			btnSeleccionarExamen1.Enabled = false;
			btnSeleccionarExamen2.Enabled = false;
		}
	}
}
