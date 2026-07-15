using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Examen_y_Factura.Interfaces
{
	public interface IExamen
	{
		int IdExamen { get; set; }
		double Precio { get; set; }

		DataTable ListarExamenesPorCategoria(int idCategoria);
		int ActualizarPrecio(long idExamen, double nuevoPrecio);

		int RegistrarNuevaSolicitud(long idPersona, long? idMedico, string estado, List<int> idsExamenes);

		DataTable ListarSolicitudes();

		int ModificarSolicitud(long idSolicitud, long idPersona, long? idMedico, string estado, List<int> idsExamenes);
		List<int> ObtenerIdsExamenesPorSolicitud(long idSolicitud);

		int EliminarSolicitud(long idSolicitud);

		DataTable BuscarSolicitudes(string dni, string paciente, DateTime? fD, DateTime? fH);

		DataTable ObtenerParametrosParaResultado(long idSolicitud);
		int GuardarResultado(long idSoli, long idParam, long idUser, string res, string valRef);

		DataTable ObtenerDatosReporte(long idSolicitud);

		void EnviarCorreoReporte(string destinatario, string nombrePaciente, string rutaAdjunto, long idOrden);
		DataTable ListarSolicitudesHistorial(int idPersona);
	}
}
