using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IPaciente
	{
		int IdPersona { get; set; }
		string DNIpersona { get; set; }
		string NombrePersona { get; set; }
		string ApellidoPersona { get; set; }
		DateTime FechaNacimiento { get; set; }
		char Genero { get; set; }
		string Correo { get; set; }
		string Telefono { get; set; }
		string Direccion { get; set; }
		int IdUsuarioRegistro { get; set; }

		int RegistrarPaciente();
		int ModificarPaciente();
		int EliminarPaciente(long idPersona);
		DataTable ListarPacientes();
		DataTable BuscarPaciente(string nom, string ape, string dni, char? gen, DateTime? fD, DateTime? fH);

		DataTable BuscarPersonaPorDNI(string dni);
	}
}
