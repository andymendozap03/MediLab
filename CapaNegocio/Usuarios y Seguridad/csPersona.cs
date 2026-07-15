using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class csPersona
	{
		protected int idPersona;
		protected string DNI;
		protected string nombrePersona;
		protected string apellidoPersona;
		protected DateTime fechaNacimiento;
		protected string correo;
		protected string direccion;
		protected string telefono;
		protected char genero;

		public int IdPersona
		{
			get { return idPersona; }
			set { idPersona = value; }
		}

		public string DNIpersona
		{
			get { return DNI; }
			set { DNI = value; }
		}

		public string NombrePersona
		{
			get { return nombrePersona; }
			set { nombrePersona = value; }
		}

		public string ApellidoPersona
		{
			get { return apellidoPersona; }
			set { apellidoPersona = value; }
		}

		public DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		public string Correo
		{
			get { return correo; }
			set { correo = value; }
		}

		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		public char Genero
		{
			get { return genero; }
			set { genero = value; }
		}

		protected void ActualizarDatos()
		{
		}
	}
}
