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

namespace CapaPresentacion.Usuarios_y_Seguridad
{
	public partial class FrmRol : Form
	{
		private IRol _rolNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IInicioSesion sesion;
		private IAuditoria _auditoria = new csAuditoria();

		public int IdRolSeleccionado { get; private set; }
		public string NombreRolSeleccionado { get; private set; }
		private bool _modoSeleccion;
		public FrmRol(IInicioSesion sesionActiva, bool modoSeleccion = false)
		{
			InitializeComponent();
			_modoSeleccion = modoSeleccion;
			sesion = sesionActiva;
			dgvRol.AutoGenerateColumns = false;
			dgvRol.Columns["ID"].DataPropertyName = "IDROL";
			dgvRol.Columns["Rol"].DataPropertyName = "NOMBRE_ROL";

			_rolNegocio = new csRol();
			CargarRoles();
			ConfigurarPermisosIniciales();

			btnInsertar.Visible = _modoSeleccion;
			btnVolver.Visible = _modoSeleccion;
			btnInsertar.Enabled = false;
		}

		private void FrmRol_Load(object sender, EventArgs e)
		{
			CargarRoles();
			dgvRol.ClearSelection();
		}

		private void ConfigurarPermisosIniciales()
		{
			btnAgregar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Roles y Permisos", "Registrar");

		}


		private void CargarRoles()
		{
			dgvRol.DataSource = _rolNegocio.ListarRoles();
			dgvRol.ClearSelection();
		}

		private void DeshabilitarAcciones()
		{
			btnModificar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void HabilitarAcciones()
		{
			int idRol = sesion.IdRol;
			btnModificar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Roles y Permisos", "Modificar");
			btnEliminar.Enabled = _permisosNegocio.ValidarAcceso(idRol, "Roles y Permisos", "Eliminar");
		}

		private void dgvRol_SelectionChanged(object sender, EventArgs e)
		{
			bool tieneFila = dgvRol.SelectedRows.Count > 0;
			btnInsertar.Enabled = tieneFila && _modoSeleccion;

			if (dgvRol.SelectedRows.Count > 0)
				HabilitarAcciones();
			else
				DeshabilitarAcciones();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmGestionRol frm = new FrmGestionRol(sesion, 0, "");
			if (frm.ShowDialog() == DialogResult.OK)
			{
				CargarRoles();
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgvRol.SelectedRows.Count == 0) return;

			int idRol = Convert.ToInt32(dgvRol.SelectedRows[0].Cells["ID"].Value);
			string nombreRol = dgvRol.SelectedRows[0].Cells["ROL"].Value.ToString();

			FrmGestionRol frm = new FrmGestionRol(sesion, idRol, nombreRol);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				CargarRoles();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvRol.SelectedRows.Count == 0) return;

			int idRol = Convert.ToInt32(dgvRol.SelectedRows[0].Cells["ID"].Value);
			string nombreRol = dgvRol.SelectedRows[0].Cells["ROL"].Value.ToString();

			DialogResult confirmacion = MessageBox.Show(
				$"¿Está seguro de eliminar el rol '{nombreRol}'?",
				"Confirmar eliminación",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (confirmacion != DialogResult.Yes) return;

			try
			{

				int resultado = _rolNegocio.EliminarRol(idRol);

				if (resultado == 1)
				{
					int idModuloRoles = 12;
					int idAccionEliminar = 4;
					string detalle = $"Se eliminó el Rol: {nombreRol} (ID: {idRol}).";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccionEliminar, idModuloRoles, detalle);
					MessageBox.Show("Rol eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CargarRoles();
				}
				else if (resultado == -1)
				{
					MessageBox.Show("No se puede eliminar: El rol tiene usuarios asociados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmRol_Click(object sender, EventArgs e)
		{
			dgvRol.ClearSelection();
			DeshabilitarAcciones();
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (dgvRol.SelectedRows.Count > 0)
			{
				IdRolSeleccionado = Convert.ToInt32(dgvRol.SelectedRows[0].Cells["ID"].Value);
				NombreRolSeleccionado = dgvRol.SelectedRows[0].Cells["Rol"].Value.ToString();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void txtBRol_TextChanged(object sender, EventArgs e)
		{
			dgvRol.DataSource = _rolNegocio.BuscarRol(txtBRol.Text.Trim());
			dgvRol.ClearSelection();
			DeshabilitarAcciones();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBRol.Clear();
			CargarRoles();
		}

		private void txtBRol_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
