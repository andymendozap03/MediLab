using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IInicioSesion
	{
		string Usuario { get; set; }
		string Contrasena { get; set; }
		int IdUsuario { get; }
		int IdRol { get; }
		string Rol { get; }
		string NombreMostrar { get; }
		string Correo { get; }
		string RutaFoto { get; set; }

		bool ValidarUsuario();
		void CargarDatosUsuario();
		DataSet ObtenerDatosDashboard();
	}
}
