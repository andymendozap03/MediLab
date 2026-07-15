using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Reportes_y_Auditoria.Interfaces
{
	public interface IAuditoria
	{
		int RegistrarAuditoria(long? idUsuario, int idaccion, int idPermiso, string descripcion);
		DataTable ListarAuditoria();
		DataTable BuscarAuditoria(string usuario, string accion, string modulo, DateTime? desde, DateTime? hasta);
	}
}
