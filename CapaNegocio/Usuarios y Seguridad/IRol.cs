using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IRol
	{
		DataTable ListarRoles();
		int GuardarRol(int idRol, string nombreRol);
		int EliminarRol(int idRol);
		DataTable BuscarRol(string nombreRol);
	}
}
