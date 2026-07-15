using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace CapaNegocio.Usuarios_y_Seguridad
{
	public class csInicioSesion : IInicioSesion
	{
		private readonly IConexionBD _conexion;
		private string usuario;
		private string contrasena;
		private int idUsuario;
		private int idRol;
		private string nombreRol;
		private string nombreMostrar;
		private string correo;
		private string rutaFoto;

		public csInicioSesion()
		{
			_conexion = new csConexionBD();
		}

		public string Usuario
		{
			get => usuario;
			set => usuario = value;
		}
		public string Contrasena
		{
			get => contrasena;
			set => contrasena = value;
		}

		public int IdUsuario => idUsuario;
		public int IdRol => idRol;
		public string Rol => nombreRol;
		public string NombreMostrar => nombreMostrar;
		public string Correo => correo;
		public string RutaFoto
		{
			get => rutaFoto;
			set => rutaFoto = value;
		}

		public bool ValidarUsuario()
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spBuscarUsuario", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@Usuario", Usuario);
					cmd.Parameters.AddWithValue("@Contrasena", HashPassword(Contrasena));

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							idUsuario = Convert.ToInt32(dr["IDUSUARIO"]);
							idRol = Convert.ToInt32(dr["IDROL"]);
							nombreRol = dr["NOMBRE_ROL"].ToString().Trim();
							return true;
						}
					}
				}
			}
			finally { _conexion.Desconectar(); }
			return false;
		}

		public void CargarDatosUsuario()
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spObtenerDatosUsuarioSesion", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							string nombres = dr["NOMBRES"].ToString().Trim();
							string apellidos = dr["APELLIDOS"].ToString().Trim();
							nombreMostrar = nombres.Split(' ')[0] + " " + apellidos.Split(' ')[0];
							correo = dr["CORREO_ELECTRONICO"].ToString().Trim();
							rutaFoto = dr["FOTO"] == DBNull.Value ? string.Empty : dr["FOTO"].ToString();
						}
					}
				}
			}
			finally { _conexion.Desconectar(); }
		}

		private string HashPassword(string contrasena)
		{
			using (SHA256 sha = SHA256.Create())
			{
				byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
				StringBuilder sb = new StringBuilder();
				foreach (byte b in hash) sb.Append(b.ToString("x2"));
				return sb.ToString();
			}
		}

		public DataSet ObtenerDatosDashboard()
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spObtenerEstadisticasDashboard", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					DataSet ds = new DataSet();
					using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					{
						da.Fill(ds);
					}
					return ds;
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener datos del dashboard: " + ex.Message);
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

	}
}
