using CapaNegocio;
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
	public partial class FrmEspecialidad : Form
	{
		public string EspecialidadSeleccionada { get; private set; }
		public int IdSeleccionado { get; private set; }
		public FrmEspecialidad()
		{
			InitializeComponent();
		}

		private csMedico objMedico = new csMedico();
		private int idSeleccionado = 0;

		private void FrmEspecialidad_Load(object sender, EventArgs e)
		{
			ActualizarGrid();
		}

		private void ActualizarGrid()
		{
			dgvEspecialidad.DataSource = objMedico.ListarEspecialidades();
			txtNombreEspecialidad.Clear();
			idSeleccionado = 0;
		}

		private void dgvEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				IdSeleccionado = Convert.ToInt32(dgvEspecialidad.Rows[e.RowIndex].Cells["IDEspecialidad"].Value);
				EspecialidadSeleccionada = dgvEspecialidad.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNombreEspecialidad.Text)) return;
			int res = objMedico.GestionarEspecialidad("spInsertarEspecialidad", 0, txtNombreEspecialidad.Text.Trim());
			if (res == 1)
			{
				MessageBox.Show("Especialidad agregada correctamente");
				ActualizarGrid();
			}
			else MessageBox.Show("La especialidad ya existe.");
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (idSeleccionado == 0 || string.IsNullOrWhiteSpace(txtNombreEspecialidad.Text)) return;
			int res = objMedico.GestionarEspecialidad("spModificarEspecialidad", idSeleccionado, txtNombreEspecialidad.Text.Trim());
			if (res == 1)
			{
				MessageBox.Show("Especialidad modificada correctamente");
				ActualizarGrid();
			}
			else MessageBox.Show("Error o nombre duplicado.");
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (idSeleccionado == 0) return;
			var confirm = MessageBox.Show("¿Eliminar especialidad?", "Confirmar", MessageBoxButtons.YesNo);
			if (confirm == DialogResult.Yes)
			{
				int res = objMedico.GestionarEspecialidad("spEliminarEspecialidad", idSeleccionado, null);
				if (res == 1)
				{
					MessageBox.Show("Especialidad eliminada correctamente");
					ActualizarGrid();
				}
				else MessageBox.Show("No se puede eliminar (está asociada a médicos).");
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvEspecialidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				EspecialidadSeleccionada = dgvEspecialidad.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			if (dgvEspecialidad.CurrentRow != null)
			{
				IdSeleccionado = Convert.ToInt32(dgvEspecialidad.CurrentRow.Cells["IDEspecialidad"].Value);
				EspecialidadSeleccionada = dgvEspecialidad.CurrentRow.Cells["Especialidad"].Value.ToString();

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Por favor, seleccione una especialidad de la lista.");
			}
		}

		private void txtNombreEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
