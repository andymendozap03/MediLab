using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IPermisos
	{
		DataTable ListarPermisosCat();
		DataTable ObtenerConfiguracionRol(int idRol);
		int GuardarConfiguracionSeguridad(int idRol, string listaPermisosAcciones);
		bool ValidarAcceso(int idRol, string nombrePermiso, string nombreAccion);
	}
}
