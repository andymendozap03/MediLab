using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class csConexionBD : IConexionBD
	{
		private string cadenaConexion;
		private bool estadoConexion;
		private SqlConnection conexion;

		public csConexionBD()
		{
			cadenaConexion = @"Server=JEGA\SQLEXPRESS;Database=BDMediLab;User Id=sa;Password=123;";
			conexion = new SqlConnection(cadenaConexion);
			estadoConexion = false;
		}

		public string CadenaConexion
		{
			get { return cadenaConexion; }
			set
			{
				cadenaConexion = value;
				conexion.ConnectionString = cadenaConexion;
			}
		}

		public bool Estado
		{
			get { return estadoConexion; }
		}

		public bool Conectar()
		{
			try
			{
				if (conexion.State == ConnectionState.Closed)
				{
					conexion.Open();
					estadoConexion = true;
				}
				return true;
			}
			catch (SqlException)
			{
				estadoConexion = false;
				return false;
			}
		}

		public void Desconectar()
		{
			if (conexion.State == ConnectionState.Open)
			{
				conexion.Close();
				estadoConexion = false;
			}
		}

		public bool EstadoConexion()
		{
			return estadoConexion;
		}

		public SqlConnection ObtenerConexion()
		{
			return conexion;
		}
	}
}
