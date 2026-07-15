using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad.Interfaces
{
	public interface IMedico
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

		int IdMedico { get; set; }
		int IdEspecialidad { get; set; }
		string EspecialidadMedico { get; set; } 
		double Comision { get; set; }
		int IdUsuarioRegistro { get; set; }

		DataTable ListarEspecialidades();
		int GestionarEspecialidad(string proc, int id, string nombre);

		int RegistrarMedico();
		int ModificarMedico();
		int EliminarMedico(long idMedico);
		DataTable ListarMedicos();
		DataTable BuscarMedico(string nom, string ape, string dni, char? gen, string esp, DateTime? fD, DateTime? fH);
	}
}
