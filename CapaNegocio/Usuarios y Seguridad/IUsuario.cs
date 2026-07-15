using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IUsuario
	{
		int IdUsuario { get; set; }
		int IdPersona { get; set; }
		string DNIpersona { get; set; }
		string NombrePersona { get; set; }
		string ApellidoPersona { get; set; }
		DateTime FechaNacimiento { get; set; }
		char Genero { get; set; }
		string Correo { get; set; }
		string Telefono { get; set; }
		string Direccion { get; set; }
		string NombreUsuario { get; set; }
		string Contrasena { get; set; }
		int Rol { get; set; }
		string Foto { get; set; }
		int IdUsuarioRegistro { get; set; }
		int InsertarUsuario();
		int ModificarUsuario();
		int EliminarUsuario(long idUsuario);
		DataTable MostrarListarUsuarios();
		DataTable BuscarUsuario(string nom, string ape, string dni, char? gen, DateTime? fD, DateTime? fH);
		int ActualizarPerfil(bool actualizaClave, bool actualizaFoto);
		bool VerificarContrasenaActual(int idUser, string passIngresada);

	}
}

