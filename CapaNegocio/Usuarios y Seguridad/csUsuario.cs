using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class csUsuario : csPersona, IUsuario
	{
		private readonly IConexionBD _conexion;

		private int idUsuario;
		private string nombreUsuario;
		private string contrasena;
		private int rol;
		private string foto;
		private int idUsuarioRegistro;
		public csUsuario()
		{
			_conexion = new csConexionBD();
		}

		public csUsuario(IConexionBD conexion)
		{
			_conexion = conexion;
		}

		public int IdUsuario
		{
			get => idUsuario;
			set => idUsuario = value;
		}
		public string NombreUsuario
		{
			get => nombreUsuario;
			set => nombreUsuario = value;
		}
		public string Contrasena
		{
			get => contrasena;
			set => contrasena = value;
		}
		public int Rol
		{
			get => rol;
			set => rol = value;
		}
		public string Foto
		{
			get => foto;
			set => foto = value;
		}
		public int IdUsuarioRegistro
		{
			get => idUsuarioRegistro;
			set => idUsuarioRegistro = value;
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha = SHA256.Create())
			{
				byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
				StringBuilder sb = new StringBuilder();
				foreach (byte b in bytes) sb.Append(b.ToString("x2"));
				return sb.ToString();
			}
		}

		private bool ValidarContrasena(string password)
		{
			return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
		}

		public int InsertarUsuario()
		{
			if (!ValidarContrasena(Contrasena))
				throw new Exception("La contraseña no cumple los requisitos mínimos de seguridad.");

			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spRegistrarUsuario", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@DNI", DNIpersona);
				cmd.Parameters.AddWithValue("@NOMBRES", nombrePersona);
				cmd.Parameters.AddWithValue("@APELLIDOS", apellidoPersona);
				cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", fechaNacimiento);
				cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", correo);
				cmd.Parameters.AddWithValue("@TELEFONO", telefono);
				cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
				cmd.Parameters.AddWithValue("@GENERO", genero);
				cmd.Parameters.AddWithValue("@NUSUARIO", NombreUsuario);
				cmd.Parameters.AddWithValue("@CONTRASENA", HashPassword(Contrasena));
				cmd.Parameters.AddWithValue("@IDROL", Rol);
				cmd.Parameters.AddWithValue("@FOTO", string.IsNullOrWhiteSpace(Foto) ? "ninguna" : Foto);
				cmd.Parameters.AddWithValue("@IDUSUARIO_REGISTRO", IdUsuarioRegistro);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public int ModificarUsuario()
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spModificarUsuario", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDUSUARIO", IdUsuario);
				cmd.Parameters.AddWithValue("@IDPERSONA", IdPersona);
				cmd.Parameters.AddWithValue("@NUSUARIO", NombreUsuario);
				cmd.Parameters.AddWithValue("@CONTRASENA", string.IsNullOrWhiteSpace(Contrasena) ? (object)DBNull.Value : HashPassword(Contrasena));
				cmd.Parameters.AddWithValue("@IDROL", Rol);
				object parametroFoto;
				if (Foto == null)
					parametroFoto = DBNull.Value;
				else if (string.IsNullOrWhiteSpace(Foto))
					parametroFoto = "ninguna"; 
				else
					parametroFoto = Foto; 
				cmd.Parameters.AddWithValue("@FOTO", parametroFoto); ;
				cmd.Parameters.AddWithValue("@DNI", DNIpersona);
				cmd.Parameters.AddWithValue("@NOMBRES", nombrePersona);
				cmd.Parameters.AddWithValue("@APELLIDOS", apellidoPersona);
				cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", fechaNacimiento);
				cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", correo);
				cmd.Parameters.AddWithValue("@TELEFONO", telefono);
				cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
				cmd.Parameters.AddWithValue("@GENERO", genero);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public int EliminarUsuario(long idUsuario)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spEliminarUsuario", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public DataTable MostrarListarUsuarios()
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarUsuarios", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}
			finally { _conexion.Desconectar(); }
			return tabla;
		}

		public DataTable BuscarUsuario(string nombres, string apellidos, string dni, char? genero, DateTime? fechaDesde, DateTime? fechaHasta)
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spConsultarUsuarios", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@NOMBRES", string.IsNullOrWhiteSpace(nombres) ? (object)DBNull.Value : nombres);
				cmd.Parameters.AddWithValue("@APELLIDOS", string.IsNullOrWhiteSpace(apellidos) ? (object)DBNull.Value : apellidos);
				cmd.Parameters.AddWithValue("@DNI", string.IsNullOrWhiteSpace(dni) ? (object)DBNull.Value : dni);
				cmd.Parameters.AddWithValue("@GENERO", genero.HasValue ? (object)genero.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_DESDE", fechaDesde.HasValue ? (object)fechaDesde.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_HASTA", fechaHasta.HasValue ? (object)fechaHasta.Value : (object)DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}
			finally { _conexion.Desconectar(); }
			return tabla;
		}

		public int ActualizarPerfil(bool actualizaClave, bool actualizaFoto)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spActualizarPerfilUsuario", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);

					cmd.Parameters.AddWithValue("@CONTRASENA", actualizaClave ? HashPassword(contrasena) : (object)DBNull.Value);

					object parametroFotoPerfil = DBNull.Value;
					if (actualizaFoto)
					{
						parametroFotoPerfil = string.IsNullOrWhiteSpace(foto) ? "ninguna" : foto;
					}
					cmd.Parameters.AddWithValue("@FOTO", parametroFotoPerfil);

					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
			finally { _conexion.Desconectar(); }
		}

		public bool VerificarContrasenaActual(int idUser, string passIngresada)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spVerificarContrasenaActual", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDUSUARIO", idUser);
					cmd.Parameters.AddWithValue("@CONTRASENA_HASHEADA", HashPassword(passIngresada));

					int resultado = Convert.ToInt32(cmd.ExecuteScalar());
					return resultado == 1;
				}
			}
			finally { _conexion.Desconectar(); }
		}

	}
}
