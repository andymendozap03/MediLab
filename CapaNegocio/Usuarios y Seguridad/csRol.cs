using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
	public class csRol : IRol
	{
		private readonly IConexionBD _conexion;
		private int idRol;
		private string nombreRol;

		public csRol() { _conexion = new csConexionBD(); }

		public int IdRol
		{
			get => idRol;
			set => idRol = value;
		}

		public string NombreRol
		{
			get => nombreRol;
			set => nombreRol = value;
		}

		public DataTable ListarRoles()
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarRoles", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				new SqlDataAdapter(cmd).Fill(tabla);
			}
			finally { _conexion.Desconectar(); }
			return tabla;
		}

		public int GuardarRol(int idRol, string nombreRol)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spGuardarRol", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDROL", idRol);
				cmd.Parameters.AddWithValue("@NOMBRE_ROL", nombreRol.Trim());
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public int EliminarRol(int idRol)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spEliminarRol", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDROL", idRol);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public DataTable BuscarRol(string nombreRol)
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spConsultarRol", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@NOMBRE_ROL", string.IsNullOrWhiteSpace(nombreRol) ? (object)DBNull.Value : nombreRol);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}
			finally { _conexion.Desconectar(); }
			return tabla;
		}
	}
}
