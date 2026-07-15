using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using CapaPresentacion;
using CapaPresentacion.Formularios;
using CapaPresentacion.Usuarios_y_Seguridad;
using Microsoft.Reporting.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
		private IInicioSesion sesion;
		private IPermisos _permisosNegocio = new csPermisos();


		public FrmPrincipal(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			rvSemana.ProcessingMode = ProcessingMode.Local;
			rvCategoria.ProcessingMode = ProcessingMode.Local;
			DioseñoCustom();
			btnTitulo.ButtonText = "Inicio";
		}


		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			DioseñoCustom();
			CargarDatosSesion();
			ConfigurarPermisosDinamicos();
			this.rvSemana.RefreshReport();
			this.rvSemana.RefreshReport();
		}

		private void DioseñoCustom()
        {
            pnlGesstion.Visible = false;
            pnlExamen.Visible = false;
            pnlReportes.Visible = false;
            pnlConfiguracion.Visible = false;
        }

        private void OcultarSubMenus()
        {
            if (pnlGesstion.Visible == true)
                pnlGesstion.Visible = false;
            if (pnlExamen.Visible == true)
                pnlExamen.Visible = false;
            if (pnlReportes.Visible == true)
                pnlReportes.Visible = false;
            if (pnlConfiguracion.Visible == true)
                pnlConfiguracion.Visible = false;
        }

        private void MostrarSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
     

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void btnMiniaturizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnGestion_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(pnlGesstion);
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(pnlExamen);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(pnlReportes);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(pnlConfiguracion);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmPaciente frmPaciente = new FrmPaciente(sesion);
            frmPaciente.TopLevel = false;
            frmPaciente.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmPaciente);
            frmPaciente.Show();
            btnTitulo.ButtonText = "Gestión de Pacientes";
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmMedicoAfiliado frmMedico = new FrmMedicoAfiliado(sesion);
            frmMedico.TopLevel = false;
            frmMedico.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmMedico);
            frmMedico.Show();
            btnTitulo.ButtonText = "Gestión de Médicos/Afiliados";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
			pnlFormulario.Controls.Clear();
			FrmUsuario frmUsuario = new FrmUsuario(sesion);

			frmUsuario.PerfilActualizadoEnGestion += (s, args) => {
				CargarDatosSesion();
			};

			frmUsuario.TopLevel = false;
			frmUsuario.Dock = DockStyle.Fill;
			pnlFormulario.Controls.Add(frmUsuario);
			frmUsuario.Show();
			btnTitulo.ButtonText = "Gestión de Usuarios";
		}

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmSolicitud frmSolicitud = new FrmSolicitud(sesion);
            frmSolicitud.TopLevel = false;
            frmSolicitud.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmSolicitud);
            frmSolicitud.Show();
            btnTitulo.ButtonText = "Solicitud de Examen";
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmRegistroExamen frmRegistro = new FrmRegistroExamen(sesion);
            frmRegistro.TopLevel = false;
            frmRegistro.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmRegistro);
            frmRegistro.Show();
            btnTitulo.ButtonText = "Registro de Examen";

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmHistorialExamen frmHistorialExamen = new FrmHistorialExamen(sesion);
            frmHistorialExamen.TopLevel = false;
            frmHistorialExamen.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmHistorialExamen);
            frmHistorialExamen.Show();
            btnTitulo.ButtonText = "Historial de exámenes";
        }

        private void btnFinanciero_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmFinanciero frmFinanciero = new FrmFinanciero(sesion);
            frmFinanciero.TopLevel = false;
            frmFinanciero.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmFinanciero);
            frmFinanciero.Show();
            btnTitulo.ButtonText = "Reportes financieros";
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmLaboratorio frmLaboratorio = new FrmLaboratorio(sesion);
            frmLaboratorio.TopLevel = false;
            frmLaboratorio.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmLaboratorio);
            frmLaboratorio.Show();
            btnTitulo.ButtonText = "Reportes de laboratorio";
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmGestionFacturacion frmGestionFacturacion = new FrmGestionFacturacion(sesion);
			frmGestionFacturacion.TopLevel = false;
			frmGestionFacturacion.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmGestionFacturacion);
			frmGestionFacturacion.Show();
            btnTitulo.ButtonText = "Facturación";
        }
        private void btnPrecios_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmPrecios frmPrecios = new FrmPrecios(sesion);
            frmPrecios.TopLevel = false;
            frmPrecios.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmPrecios);
            frmPrecios.Show();
            btnTitulo.ButtonText = "Precios de exámenes";
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            pnlFormulario.Controls.Clear();
            FrmAuditoria frmAuditoria = new FrmAuditoria(sesion);
            frmAuditoria.TopLevel = false;
            frmAuditoria.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(frmAuditoria);
            frmAuditoria.Show();
            btnTitulo.ButtonText = "Auditoría";
        }

		private void btnRoles_Click(object sender, EventArgs e)
		{
			pnlFormulario.Controls.Clear();
			FrmRol frmRol = new FrmRol(sesion);
			frmRol.TopLevel = false;
			frmRol.Dock = DockStyle.Fill;
			pnlFormulario.Controls.Add(frmRol);
			frmRol.Show();
			btnTitulo.ButtonText = "Gestión de Roles y Permisos";
		}

		private void btnOpcion_Click(object sender, EventArgs e)
        {
            int offsetY = -cmsOpciones.Height + 5;

            cmsOpciones.Show(
                btnOpcion,
                new Point(0, offsetY)
            );
        }

		private void CerrarSesion_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
		    "¿Desea cerrar sesión?",
		    "Cerrar sesión",
		    MessageBoxButtons.YesNo,
		    MessageBoxIcon.Question) == DialogResult.Yes)
			{
				FrmLogin login = new FrmLogin();
				login.Show();
				this.Close();
			}
		}

		private void ConfigurarUsuario_Click(object sender, EventArgs e)
		{
			FrmModificarPerfil frmModificarPerfil = new FrmModificarPerfil(sesion);

			frmModificarPerfil.PerfilActualizado += (s, args) => {
				CargarDatosSesion();
			};

			frmModificarPerfil.Show();
		}

		private void pbLogo1_Click(object sender, EventArgs e)
		{
            pnlFormulario.Controls.Clear();
			btnTitulo.ButtonText = "Inicio";
            pnlFormulario.Controls.Add(tlpDashboard);
			CargarEstadisticasDashboard();
		}

		private void pbLogo2_Click(object sender, EventArgs e)
		{
			pnlFormulario.Controls.Clear();
			btnTitulo.ButtonText = "Inicio";
			pnlFormulario.Controls.Add(tlpDashboard);
			CargarEstadisticasDashboard();
		}

		public void CargarDatosSesion()
		{
			lblNombre.Text = sesion.NombreMostrar;
			lblCorreo.Text = sesion.Correo;
			lblRol.Text = sesion.Rol;

			if (!string.IsNullOrEmpty(sesion.RutaFoto))
			{
				string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sesion.RutaFoto);

				if (File.Exists(rutaCompleta))
				{
					if (pbFoto.Image != null) pbFoto.Image.Dispose();

					using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
					{
						pbFoto.Image = Image.FromStream(fs);
					}
				}
			}
		}

		private void ConfigurarPermisosDinamicos()
		{
			int idRol = sesion.IdRol;


			btnPacientes.Visible = _permisosNegocio.ValidarAcceso(idRol, "Pacientes", "Ver");
			btnMedicos.Visible = _permisosNegocio.ValidarAcceso(idRol, "Medicos", "Ver");
			btnUsuarios.Visible = _permisosNegocio.ValidarAcceso(idRol, "Usuarios", "Ver");


			btnSolicitud.Visible = _permisosNegocio.ValidarAcceso(idRol, "Solicitudes", "Ver");
			btnRegistro.Visible = _permisosNegocio.ValidarAcceso(idRol, "Registro Examen", "Ver");
			btnHistorial.Visible = _permisosNegocio.ValidarAcceso(idRol, "Historial", "Ver");


			btnFinanciero.Visible = _permisosNegocio.ValidarAcceso(idRol, "Reportes Financiero", "Ver");
			btnLaboratorio.Visible = _permisosNegocio.ValidarAcceso(idRol, "Reportes Laboratorio", "Ver");


			btnFacturacion.Visible = _permisosNegocio.ValidarAcceso(idRol, "Facturacion", "Ver");

			btnPrecios.Visible = _permisosNegocio.ValidarAcceso(idRol, "Precios", "Ver");
			btnAuditoria.Visible = _permisosNegocio.ValidarAcceso(idRol, "Auditoria", "Ver");
			btnRoles.Visible = _permisosNegocio.ValidarAcceso(idRol, "Roles y Permisos", "Ver");



			if(_permisosNegocio.ValidarAcceso(idRol, "Pacientes", "Ver")){
                btnGestion.Visible = true;
			}
            else if(_permisosNegocio.ValidarAcceso(idRol, "Medicos", "Ver"))
            {
                btnGestion.Visible = true;
			}
            else
            {
                btnGestion.Visible = false;
			}

			if (_permisosNegocio.ValidarAcceso(idRol, "Solicitudes", "Ver"))
			{
				btnExamen.Visible = true;
			}
			else if (_permisosNegocio.ValidarAcceso(idRol, "Registro Examen", "Ver"))
			{
				btnExamen.Visible = true;
			}
			else if (_permisosNegocio.ValidarAcceso(idRol, "Historial", "Ver"))
			{
				btnExamen.Visible = true;
			}
			else
			{
				btnExamen.Visible = false;
			}

			if (_permisosNegocio.ValidarAcceso(idRol, "Reportes Financiero", "Ver"))
			{
				btnReportes.Visible = true;
			}
			else if (_permisosNegocio.ValidarAcceso(idRol, "Reportes Laboratorio", "Ver"))
			{
				btnReportes.Visible = true;
			}
			else
			{
				btnReportes.Visible = false;
			}

			if (_permisosNegocio.ValidarAcceso(idRol, "Precios", "Ver"))
			{
				btnConfiguracion.Visible = true;
			}
			else if (_permisosNegocio.ValidarAcceso(idRol, "Usuarios", "Ver"))
			{
				btnGestion.Visible = true;
			}
			else if (_permisosNegocio.ValidarAcceso(idRol, "Auditoria", "Ver"))
			{
				btnConfiguracion.Visible = true;
			}
			else if (_permisosNegocio.ValidarAcceso(idRol, "Roles y Permisos", "Ver"))
			{
				btnConfiguracion.Visible = true;
			}
			else
			{
				btnConfiguracion.Visible = false;
			}


		}

		private async Task CargarEstadisticasDashboard()
		{
			try
			{
				DataSet ds = await Task.Run(() => sesion.ObtenerDatosDashboard());

				if (ds != null && ds.Tables.Count >= 3)
				{
					DataRow rowContadores = ds.Tables[0].Rows[0];
					lblPacientes.Text = rowContadores["TotalPacientes"].ToString();
					lblExamenes.Text = rowContadores["ExamenesPendientes"].ToString();
					lblFacturacion.Text = rowContadores["PendientesFacturacion"].ToString();
					lblMedicos.Text = rowContadores["TotalMedicos"].ToString();

					rvSemana.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes_y_Auditoria.rptSolicitudes.rdlc";
					rvSemana.LocalReport.DataSources.Clear();
					rvSemana.LocalReport.DataSources.Add(new ReportDataSource("dtSemana", ds.Tables[1]));

					rvCategoria.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes_y_Auditoria.rptCategorias.rdlc";
					rvCategoria.LocalReport.DataSources.Clear();
					rvCategoria.LocalReport.DataSources.Add(new ReportDataSource("dtCategorias", ds.Tables[2]));

					await Task.Run(() => {
					});

					rvSemana.RefreshReport();
					rvCategoria.RefreshReport();
				}
			}
			catch (Exception ex)
			{
				this.BeginInvoke(new Action(() => {
					MessageBox.Show("Error al actualizar Dashboard: " + ex.Message);
				}));
			}
		}

		private async void FrmPrincipal_Shown(object sender, EventArgs e)
		{
			await CargarEstadisticasDashboard();
		}
	}
}

