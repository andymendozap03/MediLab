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
	public partial class FrmGestionRol : Form
	{
		private int idRolActual;
		private string nombreRolActual;
		private IPermisos _permisosNegocio;
		private IRol _rolNegocio;
		private IInicioSesion sesion;
		private IAuditoria _auditoria = new csAuditoria();
		public FrmGestionRol(IInicioSesion sesionActiva, int id, string nombre = "")
		{
			InitializeComponent();
			this.sesion = sesionActiva;
			this.idRolActual = id;
			this.nombreRolActual = nombre;
			this._permisosNegocio = new csPermisos();
			this._rolNegocio = new csRol();
		}

		private void FrmGestionRol_Load(object sender, EventArgs e)
		{
			if (idRolActual > 0)
			{
				txtNombreRol.Text = nombreRolActual;
			}
			ConfigurarMatriz();
		}

		private void ConfigurarMatriz()
		{
			try
			{
				DataTable dtPermisos = _permisosNegocio.ListarPermisosCat();
				DataTable dtConfig = idRolActual > 0 ? _permisosNegocio.ObtenerConfiguracionRol(idRolActual) : new DataTable();

				dgvPermisos.Rows.Clear();


				if (dtPermisos.Rows.Count > 0)
				{
					foreach (DataRow row in dtPermisos.Rows)
					{
			
						int idPermiso = Convert.ToInt32(row["IDPERMISO"]);
						string nombrePermiso = row["NOMBRE_PERMISO"].ToString().Trim();

						
						int rowIndex = dgvPermisos.Rows.Add(idPermiso, nombrePermiso, false, false, false, false);
						DataGridViewRow fila = dgvPermisos.Rows[rowIndex];


						if (dtConfig.Rows.Count > 0)
						{
							foreach (DataRow conf in dtConfig.Select($"IDPERMISO = {idPermiso}"))
							{
								int idAccion = Convert.ToInt32(conf["IDACCION"]);
								if (idAccion == 1) fila.Cells["Ver"].Value = true;
								if (idAccion == 2) fila.Cells["Registrar"].Value = true;
								if (idAccion == 3) fila.Cells["Modificar"].Value = true;
								if (idAccion == 4) fila.Cells["Eliminar"].Value = true;
							}
						}
						AplicarRestriccionesModulo(fila, nombrePermiso);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al configurar matriz: " + ex.Message);
			}
		}

		private void AplicarRestriccionesModulo(DataGridViewRow fila, string modulo)
		{
			if (modulo.Contains("Registro")) { BloquearCelda(fila, "Eliminar"); }
			if (modulo.Contains("Historial")) { BloquearCelda(fila, "Registrar"); BloquearCelda(fila, "Modificar"); BloquearCelda(fila, "Eliminar"); }
			if (modulo.Contains("Reportes")) { BloquearCelda(fila, "Modificar"); BloquearCelda(fila, "Eliminar"); }
			if (modulo.Contains("Precios")) { BloquearCelda(fila, "Registrar"); BloquearCelda(fila, "Eliminar"); }
			if (modulo.Contains("Auditoria")) { BloquearCelda(fila, "Registrar"); BloquearCelda(fila, "Modificar"); BloquearCelda(fila, "Eliminar"); }
		}

		private void BloquearCelda(DataGridViewRow fila, string columna)
		{
			fila.Cells[columna].Value = false;

			fila.Cells[columna].ReadOnly = true;
			fila.Cells[columna].Style.BackColor = Color.LightGray;
		}

		private void dgvPermisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dgvPermisos.Columns[e.ColumnIndex].Name == "Ver")
			{
				DataGridViewRow fila = dgvPermisos.Rows[e.RowIndex];
				bool isChecked = Convert.ToBoolean(fila.Cells["Ver"].Value);

				if (!isChecked)
				{
					fila.Cells["Registrar"].Value = false;
					fila.Cells["Modificar"].Value = false;
					fila.Cells["Eliminar"].Value = false;


					dgvPermisos.InvalidateRow(e.RowIndex);
				}
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
				{
					MessageBox.Show("Debe ingresar un nombre para el rol.");
					return;
				}

				bool esNuevoRol = (idRolActual <= 0);
				string nombreRolParaAuditoria = txtNombreRol.Text.Trim();

				int idResult = _rolNegocio.GuardarRol(idRolActual, nombreRolParaAuditoria);

				if (idResult > 0)
				{
	
					List<string> listaAcciones = new List<string>();
					int permisosMarcados = 0;

					foreach (DataGridViewRow fila in dgvPermisos.Rows)
					{
						int idP = Convert.ToInt32(fila.Cells["IDPERMISO"].Value);
						if (Convert.ToBoolean(fila.Cells["Ver"].Value)) { listaAcciones.Add($"{idP}:1"); permisosMarcados++; }
						if (Convert.ToBoolean(fila.Cells["Registrar"].Value)) { listaAcciones.Add($"{idP}:2"); permisosMarcados++; }
						if (Convert.ToBoolean(fila.Cells["Modificar"].Value)) { listaAcciones.Add($"{idP}:3"); permisosMarcados++; }
						if (Convert.ToBoolean(fila.Cells["Eliminar"].Value)) { listaAcciones.Add($"{idP}:4"); permisosMarcados++; }
					}

					string cadenaMasiva = string.Join(",", listaAcciones);
					_permisosNegocio.GuardarConfiguracionSeguridad(idResult, cadenaMasiva);

					int idModuloRoles = 12;
					int idAccion = esNuevoRol ? 2 : 3; 

					string detalle = esNuevoRol
						? $"Se creó el nuevo Rol: '{nombreRolParaAuditoria}' con {permisosMarcados} permisos asignados."
						: $"Se actualizaron los privilegios del Rol: '{nombreRolParaAuditoria}' (ID: {idResult}). Total de accesos activos: {permisosMarcados}.";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccion, idModuloRoles, detalle);

					MessageBox.Show("Configuración de seguridad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar la configuración: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvPermisos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dgvPermisos.IsCurrentCellDirty)
			{
				dgvPermisos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dgvPermisos.Columns[e.ColumnIndex].Name != "Ver")
			{
				bool puedeVer = Convert.ToBoolean(dgvPermisos.Rows[e.RowIndex].Cells["Ver"].Value);

				if (!puedeVer)
				{
					return;
					
				}
			}
		}

		private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
