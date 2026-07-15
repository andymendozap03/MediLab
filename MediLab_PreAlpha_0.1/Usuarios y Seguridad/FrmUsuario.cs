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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmUsuario : Form
    {
		private IInicioSesion sesion;
		private IUsuario _usuarioNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();
		public event EventHandler PerfilActualizadoEnGestion;
		public int IdUsuarioSeleccionado { get; private set; }
		public string NombreUsuarioSeleccionado { get; private set; }
		public bool ModoSeleccion { get; set; } = false;

		public FrmUsuario(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_usuarioNegocio = new csUsuario();
			CargarUsuarios();
			dgvUsuario.AutoGenerateColumns = false;
			ConfigurarPermisosIniciales();
			DeshabilitarAcciones();
		}
		private void FrmUsuario_Load(object sender, EventArgs e)
		{
			dgvUsuario.ClearSelection();
			chkFecha_CheckedChanged(null, null);
			if (ModoSeleccion)
			{
				btnInsertar.Visible = true;
				btnVolver.Visible = true;

				btnAgregar.Visible = false;
				btnModificar.Visible = false;
				btnEliminar.Visible = false;
			}
			else
			{
				btnInsertar.Visible = false;
				btnVolver.Visible = false;

				btnAgregar.Visible = true;
				btnModificar.Visible = true;
				btnEliminar.Visible = true;
			}
		}

		private void ConfigurarPermisosIniciales()
		{
			btnAgregar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Usuarios", "Registrar");
			
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios(sesion);

			frmGestionUsuarios.UsuarioActualizado += (s, args) => {
				PerfilActualizadoEnGestion?.Invoke(this, EventArgs.Empty);
			};

			if (frmGestionUsuarios.ShowDialog() == DialogResult.OK)
			{
				CargarUsuarios();
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			csUsuario usuarioSeleccionado = ObtenerUsuarioSeleccionado();
			if (usuarioSeleccionado == null) return;

			FrmGestionUsuarios frm = new FrmGestionUsuarios(sesion, usuarioSeleccionado);

			frm.UsuarioActualizado += (s, args) => {
				PerfilActualizadoEnGestion?.Invoke(this, EventArgs.Empty);
			};

			if (frm.ShowDialog() == DialogResult.OK)
			{
				CargarUsuarios();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvUsuario.SelectedRows.Count == 0)
			{
				MessageBox.Show(
					"Seleccione un usuario de la lista antes de continuar.",
					"Advertencia",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			DataGridViewRow fila = dgvUsuario.SelectedRows[0];
			string nombreUsuarioParaDetalle = fila.Cells["NombreUsuario"].Value.ToString().Trim();
			long idUsuarioParaEliminar = Convert.ToInt64(dgvUsuario.SelectedRows[0].Cells["ID"].Value);

			if (idUsuarioParaEliminar == sesion.IdUsuario)
			{
				MessageBox.Show(
					"No puedes eliminar tu propia cuenta de usuario mientras mantienes la sesión activa.",
					"Acción Denegada",
					MessageBoxButtons.OK,
					MessageBoxIcon.Stop
				);
				return;
			}

			DialogResult confirmacion = MessageBox.Show(
				"¿Está seguro de eliminar permanentemente al usuario seleccionado?",
				"Confirmar eliminación",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (confirmacion != DialogResult.Yes)
				return;

			try
			{
				int resultado = _usuarioNegocio.EliminarUsuario(idUsuarioParaEliminar);

				if (resultado == 1)
				{
					int idModuloUsuario = 9;
					int idAccionEliminar = 4; 
					string detalle = $"Se eliminó permanentemente la cuenta del usuario: {nombreUsuarioParaDetalle} (ID: {idUsuarioParaEliminar}).";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccionEliminar, idModuloUsuario, detalle);
					MessageBox.Show(
						"Usuario eliminado correctamente.",
						"Eliminación exitosa",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);

					CargarUsuarios();
				}
				else if (resultado == -1)
				{
					MessageBox.Show(
						"No se puede eliminar el usuario porque tiene registros relacionados en el sistema.",
						"Eliminación no permitida",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
				else
				{
					MessageBox.Show(
						"No se pudo completar la operación. El registro podría haber sido eliminado previamente.",
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Error de sistema: " + ex.Message,
					"Error Crítico",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void CargarUsuarios()
		{
			dgvUsuario.DataSource = _usuarioNegocio.MostrarListarUsuarios();
			dgvUsuario.ClearSelection();
		}

		


		private void DeshabilitarAcciones()
		{
			btnModificar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void HabilitarAcciones()
		{
			int idRol = sesion.IdRol;
			btnModificar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Usuarios", "Modificar");
			btnEliminar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Usuarios", "Eliminar");
		}

		private void dgvUsuario_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				dgvUsuario.ClearSelection();
				DeshabilitarAcciones();
			}
		}

		private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvUsuario.SelectedRows.Count > 0)
				HabilitarAcciones();
			else
				DeshabilitarAcciones();
		}

		private void FrmUsuario_Click(object sender, EventArgs e)
		{
			DeshabilitarAcciones();
			dgvUsuario.ClearSelection();
		}

		private csUsuario ObtenerUsuarioSeleccionado()
		{
			if (dgvUsuario.SelectedRows.Count == 0)
				return null;

			DataGridViewRow fila = dgvUsuario.SelectedRows[0];

			csUsuario usuario = new csUsuario
			{
				IdUsuario = Convert.ToInt32(fila.Cells["ID"].Value),
				IdPersona = Convert.ToInt32(fila.Cells["IDPersona"].Value),

				DNIpersona = fila.Cells["DNI"].Value.ToString(),
				NombrePersona = fila.Cells["Nombres"].Value.ToString(),
				ApellidoPersona = fila.Cells["Apellidos"].Value.ToString(),
				FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value),
				Genero = Convert.ToChar(fila.Cells["Genero"].Value),
				Correo = fila.Cells["CorreoElectronico"].Value.ToString(),
				Telefono = fila.Cells["Telefono"].Value.ToString(),
				Direccion = fila.Cells["Direccion"].Value.ToString(),

				NombreUsuario = fila.Cells["NombreUsuario"].Value.ToString(),
				Rol = fila.Cells["Rol"].Value.ToString() == "Administrador" ? 1 : 2
			};

			return usuario;
		}

		private void AplicarFiltros()
		{
			char? genero = null;

			if (rbHombre.Checked) genero = 'M';
			else if (rbMujer.Checked) genero = 'F';

			dgvUsuario.DataSource = _usuarioNegocio.BuscarUsuario(
				txtBNombres.Text.Trim(),
				txtBApellidos.Text.Trim(),
				txtBDNI.Text.Trim(),
				genero,
				chkFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null,
				chkFecha.Checked ? dtpHasta.Value.Date : (DateTime?)null
			);

			dgvUsuario.ClearSelection();
		}

		private void txtBNombres_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void txtBApellidos_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void txtBDNI_TextChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void rbMujer_CheckedChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void rbHombre_CheckedChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void dtpDesde_ValueChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void dtpHasta_ValueChanged(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void chkFecha_CheckedChanged(object sender, EventArgs e)
		{
			dtpDesde.Enabled = chkFecha.Checked;
			dtpHasta.Enabled = chkFecha.Checked;
			AplicarFiltros();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBNombres.Clear();
			txtBApellidos.Clear();
			txtBDNI.Clear();
			rbHombre.Checked = false;
			rbMujer.Checked = false;
			chkFecha.Checked = false;
			dtpDesde.Value = DateTime.Today;
			dtpHasta.Value = DateTime.Today;

			CargarUsuarios();
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (dgvUsuario.SelectedRows.Count > 0)
			{
				DataGridViewRow fila = dgvUsuario.SelectedRows[0];

				IdUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
				NombreUsuarioSeleccionado = fila.Cells["NombreUsuario"].Value.ToString().Trim();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un usuario de la lista.");
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (ModoSeleccion && e.RowIndex >= 0)
			{
				btnInsertar_Click(null, null);
			}
		}

		private void txtBNombres_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtBApellidos_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtBDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
