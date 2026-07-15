using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Examen_y_Factura.Interfaces
{
	public interface IFactura
	{
		int IdFactura { get; set; }
		string FechaFactura { get; set; }
		decimal Total { get; set; }
		DataTable ObtenerExamenesParaFacturacion(long idSolicitud);
		int RegistrarFactura(long idSolicitud, decimal total, DataTable detalle);
		DataTable ListarFacturas();
		DataTable BuscarFacturas(int? idFactura, int? idSolicitud, string dni, DateTime? desde, DateTime? hasta);
		DataTable ObtenerDatosFactura(long idFactura);
		void AnularFactura(long idFactura);
		void ReactivarFactura(long idFactura);
		void EnviarCorreoFactura(string destinatario, string nombrePaciente, string rutaAdjunto, long idFactura);
	}
}
