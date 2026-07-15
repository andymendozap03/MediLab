using CapaDatos;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmFacturacion : Form
    {
		private IInicioSesion sesion;
        private long idSolicitudActual;
        private IExamen _examenNegocio;
        private IFactura _facturaNegocio;
		private IAuditoria _auditoria = new csAuditoria();


		public FrmFacturacion(IInicioSesion sesionActiva)
		{
			InitializeComponent();
			sesion = sesionActiva;
            _examenNegocio = new csExamen();
            _facturaNegocio = new csFactura();
		}

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            using (FrmSolicitud frm = new FrmSolicitud(sesion))
            {
                frm.ModoSeleccion = true;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.idSolicitudActual = frm.IdSolicitudSeleccionada;
                    txtSolicitud.Text = idSolicitudActual.ToString();
                    txtPaciente.Text = frm.NombrePaciente;
                    txtGenero.Text = frm.Genero == 'M' ? "Masculino" : "Femenino";
                    txtEdad.Text = CalcularEdad(frm.FechaNacimiento).ToString() + " años";

                    DataTable dtExamenes = _facturaNegocio.ObtenerExamenesParaFacturacion(idSolicitudActual);

                    dgvFacturacion.Rows.Clear();

                    foreach (DataRow row in dtExamenes.Rows)
                    {
                        dgvFacturacion.Rows.Add(
                            row["IDEXAMENCOMPUESTO"],  
                            row["Examen"].ToString(),  
                            Convert.ToDecimal(row["Precio"]) 
                        );
                    }

                    CalcularTotal();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFacturacion.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un examen.");
                    return;
                }

                DataTable dtDetalle = new DataTable();
                dtDetalle.Columns.Add("IDEXAMENCOMPUESTO", typeof(long));
                dtDetalle.Columns.Add("PRECIODETA", typeof(decimal));

                decimal total = 0;

                foreach (DataGridViewRow row in dgvFacturacion.Rows)
                {
                    if (row.IsNewRow) continue;

                    long idExamen = Convert.ToInt64(row.Cells["IDEXAMENCOMPUESTO"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

                    dtDetalle.Rows.Add(idExamen, precio);
                    total += precio;
                }

                int idFactura = _facturaNegocio.RegistrarFactura(idSolicitudActual, total, dtDetalle);

				int idModuloFacturacion = 8;
				int idAccionRegistrar = 2;
				string detalle = $"Se generó la Factura por un total de ${total:N2} para el paciente: {txtPaciente.Text}.";

				_auditoria.RegistrarAuditoria(sesion.IdUsuario, idAccionRegistrar, idModuloFacturacion, detalle);

				MessageBox.Show("Factura registrada correctamente.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar factura: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            if (!dgvFacturacion.Columns.Contains("IDEXAMENCOMPUESTO"))
            {
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.Name = "IDEXAMENCOMPUESTO";
                colId.HeaderText = "IDEXAMENCOMPUESTO";
                colId.Visible = false;
                dgvFacturacion.Columns.Insert(0, colId);
            }
        }

        #region FUNCIONES

        public void LimpiarFormulario()
        {
            txtSolicitud.Clear();
            txtPaciente.Clear();
            txtGenero.Clear();
            txtEdad.Clear();
            txtTotal.Clear();

            dgvFacturacion.Rows.Clear();
            idSolicitudActual = 0;
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvFacturacion.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Precio"].Value != null &&
                    decimal.TryParse(row.Cells["Precio"].Value.ToString(), out decimal precio))
                {
                    total += precio;
                }
            }

            txtTotal.Text = total.ToString("N2");
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad;
        }

        #endregion

        
    }
}
