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
    public partial class FrmAuditoria : Form
    {
		private IInicioSesion sesion;
		private IAuditoria _auditoria = new csAuditoria();


		private void txtBUsuario_TextChanged(object sender, EventArgs e) => AplicarFiltros();
		private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();
		private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

		public FrmAuditoria(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
		}
		private void FrmAuditoria_Load(object sender, EventArgs e)
		{
			dgvAuditoria.AutoGenerateColumns = false;
			CargarMovimientosTotales();
			dtpDesde.Enabled = dtpHasta.Enabled = false;
			dgvAuditoria.ClearSelection();
		}

		private void CargarMovimientosTotales()
		{
			dgvAuditoria.DataSource = _auditoria.ListarAuditoria();
			dgvAuditoria.ClearSelection();
		}

		private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
			FrmUsuario frm = new FrmUsuario(sesion);
			frm.ModoSeleccion = true;

			if (frm.ShowDialog() == DialogResult.OK)
			{
				txtBUsuario.Text = frm.NombreUsuarioSeleccionado;
			}
		}

		private void AplicarFiltros()
		{
			string usuario = txtBUsuario.Text.Trim();
			string accion = cmbAccion.SelectedIndex > -1 ? cmbAccion.SelectedItem.ToString() : null;
			string modulo = cmbModulo.SelectedIndex > -1 ? cmbModulo.SelectedItem.ToString() : null;

			DateTime? desde = chkFecha.Checked ? dtpDesde.Value.Date : (DateTime?)null;
			DateTime? hasta = chkFecha.Checked ? dtpHasta.Value.Date : (DateTime?)null;

			dgvAuditoria.DataSource = _auditoria.BuscarAuditoria(usuario, accion, modulo, desde, hasta);
			dgvAuditoria.ClearSelection();
		}

		private void chkFecha_CheckedChanged(object sender, EventArgs e)
		{
			dtpDesde.Enabled = dtpHasta.Enabled = chkFecha.Checked;
			AplicarFiltros();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBUsuario.Clear();
			cmbAccion.SelectedIndex = -1;
			cmbModulo.SelectedIndex = -1;
			chkFecha.Checked = false;
			dtpDesde.Value = DateTime.Today;
			dtpHasta.Value = DateTime.Today;
			CargarMovimientosTotales();
		}

		private void txtBUsuario_TextChanged_1(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void cmbAccion_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void cmbModulo_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			AplicarFiltros();
		}

		private void FrmAuditoria_Click(object sender, EventArgs e)
		{
			dgvAuditoria.ClearSelection();
		}
	}
}
