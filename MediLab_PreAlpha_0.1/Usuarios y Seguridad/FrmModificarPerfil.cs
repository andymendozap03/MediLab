using CapaNegocio;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
	public partial class FrmModificarPerfil : Form
	{
		private IInicioSesion sesion;
		private IUsuario _usuarioNegocio;
		private string rutaTemporalImagen = "";
		private const string CARPETA_FOTOS = "FotosUsuarios";
		public event EventHandler PerfilActualizado;

		public FrmModificarPerfil(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			this.sesion = sesionActiva;
			this._usuarioNegocio = new csUsuario();
			CargarDatosActuales();
		}

		private void CargarDatosActuales()
		{
			try
			{
				if (!string.IsNullOrEmpty(sesion.RutaFoto))
				{
					string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sesion.RutaFoto);

					if (File.Exists(rutaCompleta))
					{
						using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
						{
							pbFoto.Image = Image.FromStream(fs);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al cargar foto actual: " + ex.Message);
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{

				_usuarioNegocio.IdUsuario = sesion.IdUsuario;

	
				bool deseaCambiarClave = !string.IsNullOrWhiteSpace(txtContrasenaNueva.Text);
				bool deseaCambiarFoto = !string.IsNullOrEmpty(rutaTemporalImagen);

				if (!deseaCambiarClave && !deseaCambiarFoto)
				{
					MessageBox.Show("No se han detectado cambios para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}


				if (deseaCambiarClave)
				{
					if (string.IsNullOrWhiteSpace(txtContrasenaActual.Text))
					{
						MessageBox.Show("Para cambiar su contraseña, debe ingresar su clave actual.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					if (!_usuarioNegocio.VerificarContrasenaActual(sesion.IdUsuario, txtContrasenaActual.Text))
					{
						MessageBox.Show("La contraseña actual ingresada es incorrecta.", "Error de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}

	
					if (!ValidarContrasena(txtContrasenaNueva.Text))
					{
						MessageBox.Show("La nueva contraseña no cumple con los requisitos mínimos de seguridad.\n(Mínimo 8 caracteres, Mayúscula, Minúscula, Número y Carácter Especial).", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

		
					if (txtContrasenaNueva.Text != txtRepetirContrasena.Text)
					{
						MessageBox.Show("La nueva contraseña y su confirmación no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

		
					_usuarioNegocio.Contrasena = txtContrasenaNueva.Text;
				}

		
				if (deseaCambiarFoto)
				{
				
					string nombreCarpeta = "FotosUsuarios";
					string directorioDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreCarpeta);

			
					if (!Directory.Exists(directorioDestino)) Directory.CreateDirectory(directorioDestino);


					string extension = Path.GetExtension(rutaTemporalImagen);
					string nombreArchivo = $"perfil_{sesion.IdUsuario}{extension}";
					string rutaFinalFisica = Path.Combine(directorioDestino, nombreArchivo);

	
					if (pbFoto.Image != null)
					{
						pbFoto.Image.Dispose();
						pbFoto.Image = null;
					}

					File.Copy(rutaTemporalImagen, rutaFinalFisica, true);

					_usuarioNegocio.Foto = $"{nombreCarpeta}/{nombreArchivo}";
				}

	
				int resultado = _usuarioNegocio.ActualizarPerfil(deseaCambiarClave, deseaCambiarFoto);

				if (resultado > 0)
				{
					if (deseaCambiarFoto)
						sesion.RutaFoto = _usuarioNegocio.Foto;

					PerfilActualizado?.Invoke(this, EventArgs.Empty);

					MessageBox.Show("Tu perfil ha sido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("No se pudo actualizar el perfil. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
				CargarDatosActuales();
			}
		}

		private void btnImagen_Click(object sender, EventArgs e)
		{
			ofdImagen.Filter = "Imágenes (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";
			if (ofdImagen.ShowDialog() == DialogResult.OK)
			{
				rutaTemporalImagen = ofdImagen.FileName;
				pbFoto.Image = Image.FromFile(rutaTemporalImagen);
			}
		}

		private void FrmModificarPerfil_Load(object sender, EventArgs e)
		{
			ToolTip ttReglas = new ToolTip();
			ttReglas.IsBalloon = true;
			ttReglas.ToolTipIcon = ToolTipIcon.Info;
			ttReglas.ToolTipTitle = "Requisitos de seguridad";

			string mensaje = "La contraseña debe tener:\n" +
							 "• Mínimo 8 caracteres\n" +
							 "• Una letra mayúscula\n" +
							 "• Una letra minúscula\n" +
							 "• Un número\n" +
							 "• Un carácter especial (@, $, !, %, *, ?, &)";

			ttReglas.SetToolTip(txtContrasenaNueva, mensaje);
		}

		private bool ValidarContrasena(string password)
		{
			return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
		}

		private bool esImagenOriginal = true;
		private bool esImagenOriginal2 = true;
		private bool esImagenOriginal3 = true;
		private void ptbVer_Click(object sender, EventArgs e)
		{
			if (esImagenOriginal)
			{
				ptbVer.Image = Properties.Resources.ojo;
				txtContrasenaActual.PasswordChar = '\0';
				esImagenOriginal = false;
			}
			else
			{
				ptbVer.Image = Properties.Resources.eye;
				txtContrasenaActual.PasswordChar = '*';
				esImagenOriginal = true;
			}
		}

		private void ptbVer2_Click(object sender, EventArgs e)
		{
			if (esImagenOriginal2)
			{
				ptbVer2.Image = Properties.Resources.ojo;
				txtContrasenaNueva.PasswordChar = '\0';
				esImagenOriginal2 = false;
			}
			else
			{
				ptbVer2.Image = Properties.Resources.eye;
				txtContrasenaNueva.PasswordChar = '*';
				esImagenOriginal2 = true;
			}
		}

		private void ptbVer3_Click(object sender, EventArgs e)
		{
			if (esImagenOriginal3)
			{
				ptbVer3.Image = Properties.Resources.ojo;
				txtRepetirContrasena.PasswordChar = '\0';
				esImagenOriginal3 = false;
			}
			else
			{
				ptbVer3.Image = Properties.Resources.eye;
				txtRepetirContrasena.PasswordChar = '*';
				esImagenOriginal3 = true;
			}
		}
	}
}
