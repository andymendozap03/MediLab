using CapaNegocio;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion.Formularios
{
    public partial class FrmGestionPaciente : Form
    {

		private csPaciente paciente;
		private bool esEdicion = false;
		private IInicioSesion sesion;
		private IPaciente _pacienteNegocio;
		private IAuditoria _auditoria = new csAuditoria();

		public FrmGestionPaciente(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;

			_pacienteNegocio = new csPaciente();
		}

		public FrmGestionPaciente(IInicioSesion sesionActiva, csPaciente pacienteEditar)
		{
			InitializeComponent();
			sesion = sesionActiva;
			paciente = pacienteEditar;
			esEdicion = true;

			_pacienteNegocio = new csPaciente();

			CargarDatosPaciente();
		}


		private void btnVolver_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private int idUsuarioSesion;



		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!ValidarCampos())
					return;


				if (!esEdicion)
				{
					paciente = new csPaciente();
				}

				paciente.DNIpersona = txtDNI.Text.Trim();
				paciente.NombrePersona = txtNombre.Text.Trim();
				paciente.ApellidoPersona = txtApellido.Text.Trim();
				paciente.FechaNacimiento = dtpFechaNacimiento.Value;
				paciente.Correo = txtCorreo.Text.Trim();
				paciente.Telefono = txtTelefono.Text.Trim();
				paciente.Direccion = txtDireccion.Text.Trim();
				paciente.Genero = rbHombre.Checked ? 'M' : 'F';
				paciente.IdUsuarioRegistro = sesion.IdUsuario;

				int resultado;

				if (esEdicion)
					resultado = paciente.ModificarPaciente();
				else
					resultado = paciente.RegistrarPaciente();

				if (resultado == -1)
				{
					MessageBox.Show("Ya existe un paciente con esa cédula", "Paciente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (resultado > 0)
				{
					int accionAuditoria = esEdicion ? 3 : 2;

					int idModuloPaciente = 1;

					string detalle = esEdicion
					? $"Se modificó al paciente con DNI: {paciente.DNIpersona}. Nombre: {paciente.NombrePersona} {paciente.ApellidoPersona}"
					: $"Se registró un nuevo paciente. DNI: {paciente.DNIpersona}, Nombre: {paciente.NombrePersona} {paciente.ApellidoPersona}";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, accionAuditoria, idModuloPaciente, detalle);

					MessageBox.Show(esEdicion ? "Paciente modificado correctamente" : "Paciente registrado correctamente",
									"Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("La cédula ingresada no es válida");
				txtDNI.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("Ingrese el nombre");
				txtNombre.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtApellido.Text))
			{
				MessageBox.Show("Ingrese el apellido");
				txtApellido.Focus();
				return false;
			}

			if (!string.IsNullOrWhiteSpace(txtCorreo.Text) &&
				!ValidarCorreo(txtCorreo.Text.Trim()))
			{
				MessageBox.Show("Ingrese un correo electrónico válido");
				txtCorreo.Focus();
				return false;
			}

			if (!rbHombre.Checked && !rbMujer.Checked)
			{
				MessageBox.Show("Seleccione el género");
				return false;
			}

			return true;
		}

		private void CargarDatosPaciente()
		{
			txtDNI.Text = paciente.DNIpersona;
			txtNombre.Text = paciente.NombrePersona;
			txtApellido.Text = paciente.ApellidoPersona;
			dtpFechaNacimiento.Value = paciente.FechaNacimiento;
			txtCorreo.Text = paciente.Correo;
			txtTelefono.Text = paciente.Telefono;
			txtDireccion.Text = paciente.Direccion;

			if (paciente.Genero == 'M')
				rbHombre.Checked = true;
			else
				rbMujer.Checked = true;

		}


		private bool ValidarCorreo(string correo)
		{
			return Regex.IsMatch(
				correo,
				@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
				RegexOptions.IgnoreCase
			);
		}

		private bool ValidarCedulaEcuatoriana(string cedula)
		{
			if (cedula.Length != 10 || !cedula.All(char.IsDigit))
				return false;

			int provincia = int.Parse(cedula.Substring(0, 2));
			if (provincia < 1 || provincia > 24)
				return false;

			int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
			int suma = 0;

			for (int i = 0; i < 9; i++)
			{
				int valor = int.Parse(cedula[i].ToString()) * coeficientes[i];
				if (valor >= 10)
					valor -= 9;

				suma += valor;
			}

			int digitoVerificador = int.Parse(cedula[9].ToString());
			int decenaSuperior = ((suma + 9) / 10) * 10;
			int resultado = decenaSuperior - suma;

			if (resultado == 10)
				resultado = 0;

			return digitoVerificador == resultado;
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

		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

		}
	}
}
