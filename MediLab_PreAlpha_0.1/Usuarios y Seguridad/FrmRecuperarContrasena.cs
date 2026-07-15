using CapaNegocio;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Usuarios_y_Seguridad
{
    public partial class FrmRecuperarContrasena : Form
    {
		private IRecuperarContrasena _service;
		private long _idUsuarioActual;



		public FrmRecuperarContrasena()
        {
            InitializeComponent();
			_service = new csRecuperarContrasena();

			pnlUsuario.Visible = true;
            pnlCodigo.Visible = false;
            pnlContrasena.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string codigo = txtContinuar.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese el código recibido.");
                return;
            }

            int resultado = _service.ValidarCodigo(_idUsuarioActual, codigo);

            if (resultado == 1) // Éxito
            {
                pnlCodigo.Visible = false;
                pnlContrasena.Visible = true;
                txtNuevaPassword.Focus();
            }
            else
            {
                string mensaje = "";

                switch (resultado)
                {
                    case -1:
                        mensaje = "El código ha expirado (10 min). Solicite uno nuevo.";
                        break;
                    case -2:
                        mensaje = "El código es incorrecto.";
                        break;
                    case -3:
                        mensaje = "Superó el límite de intentos. El código fue invalidado.";
                        break;
                    case 0:
                        mensaje = "No existe un código activo para este usuario.";
                        break;
                    default:
                        mensaje = "Error de validación desconocido.";
                        break;
                }

                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (resultado == -1 || resultado == -3)
                {
                    pnlCodigo.Visible = false;
                    pnlUsuario.Visible = true;
                }
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string pass = txtNuevaPassword.Text.Trim();
            string confirmar = txtConfirmarPassword.Text.Trim();

            if (pass != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;

                bool cambiado = _service.CambiarPassword(_idUsuarioActual, pass);

                if (cambiado)
                {
                    _service.FinalizarRecuperacion(_idUsuarioActual);
                    MessageBox.Show("Contraseña actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string credencial = txtCredencial.Text.Trim();

            if (string.IsNullOrEmpty(credencial))
            {
                MessageBox.Show("Por favor, ingrese su usuario, DNI o correo electrónico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;


                bool enviado = _service.SolicitarRecuperacion(credencial, out _idUsuarioActual);

                if (enviado)
                {
                    MessageBox.Show("Se ha enviado un código de seguridad a su correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pnlUsuario.Visible = false;
                    pnlCodigo.Visible = true;
                    txtContinuar.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario o hubo un error al enviar el correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
