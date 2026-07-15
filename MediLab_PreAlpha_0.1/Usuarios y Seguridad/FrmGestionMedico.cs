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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CapaPresentacion.Formularios
{
    public partial class FrmGestionMedico : Form
    {
		private IInicioSesion sesion;
		private IMedico _medicoNegocio;
		private IPaciente _personaNegocio;
		private IAuditoria _auditoria = new csAuditoria();
		private bool esEdicion = false;
		private int idEspecialidadSeleccionada = 0;

		public FrmGestionMedico(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_medicoNegocio = new csMedico();
			_personaNegocio = new csPaciente();
		}

		public FrmGestionMedico(IInicioSesion sesionActiva, csMedico medicoEditar)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_medicoNegocio = medicoEditar;
			_personaNegocio = new csPaciente();
			esEdicion = true;
			idEspecialidadSeleccionada = medicoEditar.IdEspecialidad;
			CargarDatosCampos();
		}

		private void CargarDatosCampos()
		{
			txtDNI.Text = _medicoNegocio.DNIpersona;
			txtNombre.Text = _medicoNegocio.NombrePersona;
			txtApellido.Text = _medicoNegocio.ApellidoPersona;
			dtpFechaNacimiento.Value = _medicoNegocio.FechaNacimiento;
			txtCorreo.Text = _medicoNegocio.Correo;
			txtTelefono.Text = _medicoNegocio.Telefono;
			txtDireccion.Text = _medicoNegocio.Direccion;
			txtEspecialidad.Text = _medicoNegocio.EspecialidadMedico;
			txtComision.Text = _medicoNegocio.Comision.ToString(CultureInfo.InvariantCulture);

			if (_medicoNegocio.Genero == 'M') rbHombre.Checked = true;
			else rbMujer.Checked = true;
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

			
				_medicoNegocio.DNIpersona = txtDNI.Text.Trim();
				_medicoNegocio.NombrePersona = txtNombre.Text.Trim();
				_medicoNegocio.ApellidoPersona = txtApellido.Text.Trim();
				_medicoNegocio.FechaNacimiento = dtpFechaNacimiento.Value;
				_medicoNegocio.Correo = txtCorreo.Text.Trim();
				_medicoNegocio.Telefono = txtTelefono.Text.Trim();
				_medicoNegocio.Direccion = txtDireccion.Text.Trim();
				_medicoNegocio.Genero = rbHombre.Checked ? 'M' : 'F';

			
				_medicoNegocio.IdEspecialidad = idEspecialidadSeleccionada;

		
				_medicoNegocio.IdUsuarioRegistro = sesion.IdUsuario;

				string comisionTexto = txtComision.Text.Trim().Replace(',', '.');
				if (double.TryParse(comisionTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out double comisionVal))
				{
					_medicoNegocio.Comision = comisionVal;
				}

				int res = esEdicion ? _medicoNegocio.ModificarMedico() : _medicoNegocio.RegistrarMedico();

				if (res == 1)
				{
					int idModuloMedico = 2;
					int accionAuditoria = esEdicion ? 3 : 2;
					string detalle = esEdicion
						? $"Se modificó al médico con DNI: {_medicoNegocio.DNIpersona}. Nombre: {_medicoNegocio.NombrePersona} {_medicoNegocio.ApellidoPersona}"
						: $"Se registró un nuevo médico. DNI: {_medicoNegocio.DNIpersona}, Nombre: {_medicoNegocio.NombrePersona} {_medicoNegocio.ApellidoPersona}";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, accionAuditoria, idModuloMedico, detalle);


					MessageBox.Show(esEdicion ? "Médico actualizado correctamente" : "Médico registrado correctamente",
									"Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show("No se pudo completar la operación. Verifique los datos.", "Error");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error de sistema: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEspecialiad_Click(object sender, EventArgs e)
		{
			using (FrmEspecialidad frmEspecialidad = new FrmEspecialidad())
			{
				if (frmEspecialidad.ShowDialog() == DialogResult.OK)
				{
					this.idEspecialidadSeleccionada = frmEspecialidad.IdSeleccionado;
					txtEspecialidad.Text = frmEspecialidad.EspecialidadSeleccionada;
				}
			}
		}

		private void txtDNI_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtDNI.Text) || esEdicion) return;

			DataTable dt = _personaNegocio.BuscarPersonaPorDNI(txtDNI.Text.Trim());
			if (dt.Rows.Count > 0)
			{
				DataRow r = dt.Rows[0];
				txtNombre.Text = r["NOMBRES"].ToString().Trim();
				txtApellido.Text = r["APELLIDOS"].ToString().Trim();
				dtpFechaNacimiento.Value = Convert.ToDateTime(r["FECHA_NACIMIENTO"]);
				txtCorreo.Text = r["CORREO_ELECTRONICO"].ToString().Trim();
				txtTelefono.Text = r["TELEFONO"].ToString().Trim();
				txtDireccion.Text = r["DIRECCION"].ToString().Trim();

				if (r["GENERO"].ToString().Trim() == "M") rbHombre.Checked = true;
				else rbMujer.Checked = true;

				_medicoNegocio.IdPersona = Convert.ToInt32(r["IDPERSONA"]);
				
			}
		}

		private bool ValidarCampos()
		{
			if (string.IsNullOrWhiteSpace(txtDNI.Text) || !ValidarCedulaEcuatoriana(txtDNI.Text.Trim()))
			{
				MessageBox.Show("Ingrese una cédula ecuatoriana válida.");
				txtDNI.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
			{
				MessageBox.Show("Los nombres y apellidos son obligatorios.");
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
			{
				MessageBox.Show("Debe seleccionar una especialidad.");
				btnEspecialiad.Focus();
				return false;
			}

			string comisionTexto = txtComision.Text.Trim().Replace(',', '.');
			if (string.IsNullOrWhiteSpace(comisionTexto) || !double.TryParse(comisionTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
			{
				MessageBox.Show("Ingrese un valor numérico válido para la comisión (ej. 10.50).");
				txtComision.Focus();
				return false;
			}

			return true;
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

		private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ',')
			{
				e.KeyChar = '.';
			}

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
				return;
			}

			if (e.KeyChar == '.')
			{
				if (txtComision.Text.IndexOf('.') > -1)
				{
					e.Handled = true;
				}
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
	}
}
