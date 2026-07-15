using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using CapaPresentacion.Usuarios_y_Seguridad;
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
	public partial class FrmLogin : Form
	{

		public FrmLogin()
		{
			InitializeComponent();
			txtUsuario.Focus();
		}
		private bool esImagenOriginal = true;

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void ptbVer_Click(object sender, EventArgs e)
		{
			if (esImagenOriginal)
			{
				ptbVer.Image = Properties.Resources.ojo;
				txtContrasena.PasswordChar = '\0';
				esImagenOriginal = false;
			}
			else
			{
				ptbVer.Image = Properties.Resources.eye;
				txtContrasena.PasswordChar = '*';
				esImagenOriginal = true;
			}
		}


		private void Login()
		{
			string usuario = txtUsuario.Text.Trim();
			string contrasena = txtContrasena.Text.Trim();

			if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contrasena))
			{
				MessageBox.Show(
					"Ingrese el usuario y la contraseña",
					"Campos requeridos",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtUsuario.Focus();
				return;
			}

			if (string.IsNullOrEmpty(usuario))
			{
				MessageBox.Show(
					"Ingrese el usuario",
					"Campo requerido",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtUsuario.Focus();
				return;
			}

			if (string.IsNullOrEmpty(contrasena))
			{
				MessageBox.Show(
					"Ingrese la contraseña",
					"Campo requerido",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				txtContrasena.Focus();
				return;
			}

			IInicioSesion inicioSesion = new csInicioSesion
			{
				Usuario = txtUsuario.Text.Trim(),
				Contrasena = txtContrasena.Text.Trim()
			};

			try
			{
				if (inicioSesion.ValidarUsuario())
				{
					Cursor.Current = Cursors.WaitCursor; 
					inicioSesion.CargarDatosUsuario();

					FrmPrincipal menu = new FrmPrincipal(inicioSesion);
					menu.Show();
					this.Hide();
					Cursor.Current = Cursors.Default;
				}
				else
				{
					MessageBox.Show(
						"Usuario o contraseña incorrectos",
						"Acceso denegado",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
					txtContrasena.Clear();
					txtContrasena.Focus();
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

		private void btnLogin_Click(object sender, EventArgs e)
		{

			Login();
		}

		private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}

		}

		private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void lblRecuperarContrasena_Click(object sender, EventArgs e)
        {
			FrmRecuperarContrasena frmRecuperar = new FrmRecuperarContrasena();
			frmRecuperar.Show();
        }

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			Task.Run(() => {
				try
				{
					using (var rv = new Microsoft.Reporting.WinForms.ReportViewer())
					{
						rv.LocalReport.DisplayName = "WarmUp";
					}
				}
				catch {  }
			});
		}
	}
}
