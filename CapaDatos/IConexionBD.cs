using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public interface IConexionBD
	{
		string CadenaConexion { get; set; }
		bool Estado { get; }

		bool Conectar();
		void Desconectar();
		bool EstadoConexion();
		SqlConnection ObtenerConexion();
	}
}
