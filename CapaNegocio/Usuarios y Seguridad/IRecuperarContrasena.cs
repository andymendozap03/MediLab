using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IRecuperarContrasena
	{
		bool SolicitarRecuperacion(string credencial, out long idUsuario);
		bool CambiarPassword(long idUsuario, string nuevaPassword);
		int ValidarCodigo(long idUsuario, string codigo);
		bool FinalizarRecuperacion(long idUsuario);

		int GenerarCodigoBD(long idUsuario, string codigo);
		(long? id, string correo) ObtenerDatosUsuarioBD(string credencial);
		bool ActualizarPasswordBD(long idUsuario, string passwordHaseada);
	}
}
