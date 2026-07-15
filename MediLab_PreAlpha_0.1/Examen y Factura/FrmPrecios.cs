using CapaNegocio;
using CapaNegocio.Examen_y_Factura.Interfaces;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using CapaNegocio.Usuarios_y_Seguridad;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmPrecios : Form
    {
		private IInicioSesion sesion;
		private IExamen _examenNegocio;
		private IPermisos _permisosNegocio = new csPermisos();
		private IAuditoria _auditoria = new csAuditoria();

		public FrmPrecios(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
			_examenNegocio = new csExamen();
			ConfigurarPermisosIniciales();
			CargarTodosLosGrids();
		}

		private void ConfigurarPermisosIniciales()
		{
			btnGuardar.Enabled = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Precios", "Modificar");
		}

		private void CargarTodosLosGrids()
		{
			dgvEnzimas.DataSource = _examenNegocio.ListarExamenesPorCategoria(1);
			dgvHematologia.DataSource = _examenNegocio.ListarExamenesPorCategoria(2);
			dgvBioquimica.DataSource = _examenNegocio.ListarExamenesPorCategoria(3);
			dgvHormonas.DataSource = _examenNegocio.ListarExamenesPorCategoria(4);
			dgvInmunologia.DataSource = _examenNegocio.ListarExamenesPorCategoria(5);
			dgvElectrolitos.DataSource = _examenNegocio.ListarExamenesPorCategoria(6);
			dgvMarcadoresTumorales.DataSource = _examenNegocio.ListarExamenesPorCategoria(7);
			dgvOrina.DataSource = _examenNegocio.ListarExamenesPorCategoria(8);
			dgvHeces.DataSource = _examenNegocio.ListarExamenesPorCategoria(9);
			dgvDiversos.DataSource = _examenNegocio.ListarExamenesPorCategoria(10);

			FormatearGrids();
		}

		private void FormatearGrids()
		{
			DataGridView[] todosLosGrids = { dgvEnzimas, dgvHematologia, dgvBioquimica, dgvHormonas,
		dgvInmunologia, dgvElectrolitos, dgvMarcadoresTumorales, dgvOrina, dgvHeces, dgvDiversos };

			bool puedeModificar = _permisosNegocio.ValidarAcceso(sesion.IdRol, "Precios", "Modificar");

			foreach (var dgv in todosLosGrids)
			{
				var colPrecio = ObtenerColumnaPorDataProperty(dgv, "Precio");
				if (colPrecio != null)
				{
					colPrecio.ReadOnly = !puedeModificar;

					colPrecio.DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
					colPrecio.DefaultCellStyle.Format = "N2";

					colPrecio.DefaultCellStyle.BackColor = puedeModificar ? Color.White : Color.FromArgb(240, 240, 240);
				}
			}
		}

		private DataGridViewColumn ObtenerColumnaPorDataProperty(DataGridView dgv, string dataPropertyName)
		{
			foreach (DataGridViewColumn col in dgv.Columns)
			{
				if (col.DataPropertyName.Equals(dataPropertyName, StringComparison.OrdinalIgnoreCase))
				{
					return col;
				}
			}
			return null;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridView[] todosLosGrids = { dgvEnzimas, dgvHematologia, dgvBioquimica, dgvHormonas,
			dgvInmunologia, dgvElectrolitos, dgvMarcadoresTumorales, dgvOrina, dgvHeces, dgvDiversos };

				int errores = 0;
				int cambiosRealizados = 0;

				foreach (var dgv in todosLosGrids)
				{
					
					dgv.EndEdit();

					foreach (DataGridViewRow row in dgv.Rows)
					{
						var colID = ObtenerColumnaPorDataProperty(dgv, "IDExamen");
						var colPrecio = ObtenerColumnaPorDataProperty(dgv, "Precio");

				
						if (row.IsNewRow) continue;

						if (colID != null && row.Cells[colID.Index].Value != null)
						{
							long id = Convert.ToInt64(row.Cells[colID.Index].Value);

							double precio = 0;
							if (row.Cells[colPrecio.Index].Value != DBNull.Value && row.Cells[colPrecio.Index].Value != null)
							{
							
								string valorTexto = row.Cells[colPrecio.Index].Value.ToString().Replace(',', '.');

						
								if (double.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsed))
								{
									precio = parsed;
								}
							}

							if (_examenNegocio.ActualizarPrecio(id, precio) != 1)
								errores++;
							else
								cambiosRealizados++;
						}
					}
				}

				if (errores == 0 && cambiosRealizados > 0)
				{
					int idModuloPrecios = 10;
					int idAccionModificar = 3;
					string detalle = $"Se actualizaron los precios de exámenes en el catálogo.";

					_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccionModificar, idModuloPrecios, detalle);
					MessageBox.Show("Precios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (cambiosRealizados == 0)
					MessageBox.Show("No se encontraron registros para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Hubo " + errores + " errores al guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				CargarTodosLosGrids();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar: " + ex.Message);
			}
		}

		private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dgvEnzimas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			TextBox txt = e.Control as TextBox;

			if (txt != null)
			{
				txt.KeyPress -= new KeyPressEventHandler(txtPrecio_KeyPress);

				DataGridView dgv = sender as DataGridView;
				if (dgv.CurrentCell.ColumnIndex == dgv.Columns["Precio"].Index)
				{
					txt.KeyPress += new KeyPressEventHandler(txtPrecio_KeyPress);
				}
			}
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ',')
			{
				e.KeyChar = '.';
			}

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
	}
}
