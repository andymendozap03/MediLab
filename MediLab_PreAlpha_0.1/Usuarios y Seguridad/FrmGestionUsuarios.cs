using CapaNegocio;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using CapaPresentacion.Usuarios_y_Seguridad;
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
	public partial class FrmGestionUsuarios : Form
	{
		private IInicioSesion sesion;
		private IUsuario _usuarioNegocio;
		private IPaciente _personaNegocio;
		private IAuditoria _auditoria = new csAuditoria();
		private IRol _rolNegocio = new csRol();
		private bool esEdicion = false;
		public event EventHandler UsuarioActualizado;



		public FrmGestionUsuarios(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_usuarioNegocio = new csUsuario();
			_personaNegocio = new csPaciente();
			esEdicion = false; 

		}

		public FrmGestionUsuarios(IInicioSesion sesionActiva, csUsuario usuarioEditar)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_usuarioNegocio = usuarioEditar;
			_personaNegocio = new csPaciente();
			esEdicion = true; 

			CargarDatosUsuario(); 
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!ValidarCampos()) return;

				_usuarioNegocio.DNIpersona = txtDNI.Text.Trim();
				_usuarioNegocio.NombrePersona = txtNombre.Text.Trim();
				_usuarioNegocio.ApellidoPersona = txtApellido.Text.Trim();
				_usuarioNegocio.FechaNacimiento = dtpFechaNacimiento.Value;
				_usuarioNegocio.Correo = txtCorreo.Text.Trim();
				_usuarioNegocio.Telefono = txtTelefono.Text.Trim();
				_usuarioNegocio.Direccion = txtDireccion.Text.Trim();
				_usuarioNegocio.Genero = rbHombre.Checked ? 'M' : 'F';
				_usuarioNegocio.IdUsuarioRegistro = sesion.IdUsuario;
				_usuarioNegocio.NombreUsuario = txtUsuario.Text.Trim();
				_usuarioNegocio.Rol = Convert.ToInt32(cmbRol.SelectedValue);

				if (!string.IsNullOrWhiteSpace(txtContrasena.Text))
					_usuarioNegocio.Contrasena = txtContrasena.Text.Trim();

				int resultado = (esEdicion) ? _usuarioNegocio.ModificarUsuario() : _usuarioNegocio.InsertarUsuario();

				if (resultado == 1)
				{
					int idModuloUsuario = 9;
					int idAccion = esEdicion ? 3 : 2;
					string detalle = esEdicion
						? $"Se modificó al usuario: {_usuarioNegocio.NombreUsuario}. Rol ID: {_usuarioNegocio.Rol}."
						: $"Se registró un nuevo usuario: {_usuarioNegocio.NombreUsuario}. Nombre: {_usuarioNegocio.NombrePersona} {_usuarioNegocio.ApellidoPersona}.";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccion, idModuloUsuario, detalle);

					if (esEdicion && _usuarioNegocio.IdUsuario == sesion.IdUsuario)
					{
						sesion.RutaFoto = _usuarioNegocio.Foto;
						UsuarioActualizado?.Invoke(this, EventArgs.Empty);
					}

					MessageBox.Show(esEdicion ? "Usuario modificado correctamente" : "Usuario registrado correctamente",
									"Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

					this.DialogResult = DialogResult.OK;
					this.Close();

					MessageBox.Show(esEdicion ? "Usuario modificado correctamente" : "Usuario registrado correctamente",
									"Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else if (resultado == -1)
				{
					MessageBox.Show("La cédula ya se encuentra registrada en otra persona.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (resultado == -2)
				{
					MessageBox.Show("El nombre de usuario ya existe. Elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Ocurrió un error inesperado. Código: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error de sistema: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txtDNI_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtDNI.Text))
				return;


			DataTable dt = _personaNegocio.BuscarPersonaPorDNI(txtDNI.Text.Trim());

			if (dt.Rows.Count > 0)
			{
				DataRow row = dt.Rows[0];
				txtNombre.Text = row["NOMBRES"].ToString().Trim();
				txtApellido.Text = row["APELLIDOS"].ToString().Trim();
				txtCorreo.Text = row["CORREO_ELECTRONICO"].ToString().Trim();
				txtTelefono.Text = row["TELEFONO"].ToString().Trim();
				txtDireccion.Text = row["DIRECCION"].ToString().Trim();
				dtpFechaNacimiento.Value = Convert.ToDateTime(row["FECHA_NACIMIENTO"]);

				if (row["GENERO"].ToString().Trim() == "M")
					rbHombre.Checked = true;
				else
					rbMujer.Checked = true;

				_usuarioNegocio.IdPersona = Convert.ToInt32(row["IDPERSONA"]);
			}
			else
			{
				_usuarioNegocio.IdPersona = 0;
			}
		}


		private void btnImagen_Click(object sender, EventArgs e)
		{
			ofdImagen.Filter = "Imágenes (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";
			if (ofdImagen.ShowDialog() == DialogResult.OK)
			{
				string nombreCarpeta = "FotosUsuarios";
				string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreCarpeta);

				if (!Directory.Exists(carpetaDestino)) Directory.CreateDirectory(carpetaDestino);

				string extension = Path.GetExtension(ofdImagen.FileName);
				string nombreArchivo = $"user_{txtDNI.Text}_{Guid.NewGuid().ToString().Substring(0, 5)}{extension}";
				string rutaFinalFisica = Path.Combine(carpetaDestino, nombreArchivo);

				if (pbFoto.Image != null)
				{
					pbFoto.Image.Dispose();
					pbFoto.Image = null;
				}

				File.Copy(ofdImagen.FileName, rutaFinalFisica, true);

				_usuarioNegocio.Foto = $"{nombreCarpeta}/{nombreArchivo}";

				using (FileStream fs = new FileStream(rutaFinalFisica, FileMode.Open, FileAccess.Read))
				{
					pbFoto.Image = Image.FromStream(fs);
				}
			}
		}


		private bool ValidarCampos()
		{
			if (string.IsNullOrWhiteSpace(txtDNI.Text))
			{
				MessageBox.Show("Ingrese la cédula");
				txtDNI.Focus();
				return false;
			}

			if (!ValidarCedulaEcuatoriana(txtDNI.Text.Trim()))
			{
				MessageBox.Show("La cédula ingresada no es válida (Ecuador)");
				txtDNI.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
			{
				MessageBox.Show("Nombre y Apellido son obligatorios");
				return false;
			}

			if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !ValidarCorreo(txtCorreo.Text.Trim()))
			{
				MessageBox.Show("Ingrese un correo electrónico válido");
				txtCorreo.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtUsuario.Text))
			{
				MessageBox.Show("Ingrese el nombre de usuario");
				return false;
			}

			if (!esEdicion && string.IsNullOrWhiteSpace(txtContrasena.Text))
			{
				MessageBox.Show("La contraseña es obligatoria para nuevos usuarios");
				return false;
			}

			if (cmbRol.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un rol");
				return false;
			}

			return true;
		}

		private void CargarDatosUsuario()
		{
			txtDNI.Text = _usuarioNegocio.DNIpersona;
			txtNombre.Text = _usuarioNegocio.NombrePersona;
			txtApellido.Text = _usuarioNegocio.ApellidoPersona;
			dtpFechaNacimiento.Value = _usuarioNegocio.FechaNacimiento;
			txtCorreo.Text = _usuarioNegocio.Correo;
			txtTelefono.Text = _usuarioNegocio.Telefono;
			txtDireccion.Text = _usuarioNegocio.Direccion;
			txtUsuario.Text = _usuarioNegocio.NombreUsuario;

			if (_usuarioNegocio.Genero == 'M')
				rbHombre.Checked = true;
			else
				rbMujer.Checked = true;

			cmbRol.SelectedValue = _usuarioNegocio.Rol;

			if (!string.IsNullOrEmpty(_usuarioNegocio.Foto))
			{
				string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _usuarioNegocio.Foto);
				if (File.Exists(rutaCompleta))
				{
					using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
					{
						pbFoto.Image = Image.FromStream(fs);
					}
				}
			}
		}


		private bool ValidarCorreo(string correo)
		{
			return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
		}

		private bool ValidarCedulaEcuatoriana(string cedula)
		{
			if (cedula.Length != 10 || !cedula.All(char.IsDigit)) return false;
			int provincia = int.Parse(cedula.Substring(0, 2));
			if (provincia < 1 || provincia > 24) return false;

			int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
			int suma = 0;
			for (int i = 0; i < 9; i++)
			{
				int valor = int.Parse(cedula[i].ToString()) * coeficientes[i];
				if (valor >= 10) valor -= 9;
				suma += valor;
			}
			int verificador = int.Parse(cedula[9].ToString());
			int superior = ((suma + 9) / 10) * 10;
			int resultado = superior - suma;
			return (resultado == 10 ? 0 : resultado) == verificador;
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
				return;
			}

			if (e.KeyChar == '+')
			{
				if (txtTelefono.SelectionStart > 0 || txtTelefono.Text.Contains("+"))
				{
					e.Handled = true;
				}
			}

		}


		private void CargarRolesEnCombo()
		{
			try
			{
				DataTable dt = _rolNegocio.ListarRoles();

				cmbRol.DataSource = null; 
				cmbRol.DataSource = dt;
				cmbRol.DisplayMember = "NOMBRE_ROL";
				cmbRol.ValueMember = "IDROL";


				if (!esEdicion) cmbRol.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al actualizar roles: " + ex.Message);
			}
		}

		private void FrmGestionUsuarios_Load(object sender, EventArgs e)
		{
			CargarRolesEnCombo();

			if (esEdicion)
			{
				cmbRol.SelectedValue = _usuarioNegocio.Rol;
			}
		}

		private void btnAgregarRol_Click(object sender, EventArgs e)
		{
			FrmRol frm = new FrmRol(sesion, true);

			
			frm.ShowDialog();

	
			CargarRolesEnCombo();

			
			if (frm.DialogResult == DialogResult.OK && frm.IdRolSeleccionado > 0)
			{
				cmbRol.SelectedValue = frm.IdRolSeleccionado;
			}
		}

		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
