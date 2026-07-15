using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad
{
	public class csRecuperarContrasena : IRecuperarContrasena
	{
		private readonly IConexionBD _conexion;
		private long idUsuario;
		private string credencial;
		private string codigoVerificacion;
		private string nuevaContrasena;
		private string correoUsuario;

		public csRecuperarContrasena()
		{
			_conexion = new csConexionBD();
		}
		public long IdUsuario
		{
			get => idUsuario;
			set => idUsuario = value;
		}

		public string Credencial
		{
			get => credencial;
			set => credencial = value;
		}

		public string CodigoVerificacion
		{
			get => codigoVerificacion;
			set => codigoVerificacion = value;
		}

		public string NuevaContrasena
		{
			get => nuevaContrasena;
			set => nuevaContrasena = value;
		}

		public string CorreoUsuario
		{
			get => correoUsuario;
			set => correoUsuario = value;
		}

		public bool SolicitarRecuperacion(string credencial, out long idUsuario)
		{
			idUsuario = 0;
			var datos = ObtenerDatosUsuarioBD(credencial);

			if (datos.id == null) return false;

			idUsuario = datos.id.Value;
			string codigo = GenerarCodigoAleatorio();

			if (GenerarCodigoBD(idUsuario, codigo) == 1)
			{
				return EnviarEmail(datos.correo, codigo);
			}
			return false;
		}

		public bool CambiarPassword(long idUsuario, string nuevaPassword)
		{
			if (!ValidarFortalezaContrasena(nuevaPassword))
				throw new Exception("La contraseña no cumple con los requisitos de seguridad.");

			string passwordHash = HashPassword(nuevaPassword);
			return ActualizarPasswordBD(idUsuario, passwordHash);
		}

		public int ValidarCodigo(long idUsuario, string codigo)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spValidarCodigoRecuperacion", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
					cmd.Parameters.AddWithValue("@CODIGO", codigo);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
			finally { _conexion.Desconectar(); }
		}

		public bool FinalizarRecuperacion(long idUsuario)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spMarcarCodigoUsuario", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
					return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
				}
			}
			finally { _conexion.Desconectar(); }
		}


		public int GenerarCodigoBD(long idUsuario, string codigo)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spGenerarCodigoRecuperacion", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
					cmd.Parameters.AddWithValue("@CODIGO", codigo);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
			finally { _conexion.Desconectar(); }
		}

		public (long? id, string correo) ObtenerDatosUsuarioBD(string credencial)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spObtenerUsuarioRecuperacion", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@CREDENCIAL", credencial);
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
							return (Convert.ToInt64(dr["IDUSUARIO"]), dr["CORREO_ELECTRONICO"].ToString());
					}
				}
			}
			finally { _conexion.Desconectar(); }
			return (null, null);
		}

		public bool ActualizarPasswordBD(long idUsuario, string passwordHaseada)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spCambiarPassword", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDUSUARIO", idUsuario);
					cmd.Parameters.AddWithValue("@PASSWORD", passwordHaseada);
					return Convert.ToInt32(cmd.ExecuteScalar()) == 1;
				}
			}
			finally { _conexion.Desconectar(); }
		}

		private bool EnviarEmail(string correoDestino, string codigo)
		{
			try
			{
				string correoEmisor = "medilab2026@gmail.com";
				string passwordEmisor = "buyofbstmmpuhkkg";

				MailMessage mail = new MailMessage();
				mail.To.Add(correoDestino);
				mail.From = new MailAddress(correoEmisor, "LABORATORIO CLÍNICO MEDILAB");
				mail.Subject = "Código de Recuperación de Contraseña";
				mail.Body = $"Su código de seguridad es: {codigo}. Expira en 10 minutos.";

				using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
				{
					smtp.Credentials = new NetworkCredential(correoEmisor, passwordEmisor);
					smtp.EnableSsl = true;
					smtp.Send(mail);
				}
				return true;
			}
			catch { return false; }
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha = SHA256.Create())
			{
				byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
				return string.Concat(bytes.Select(b => b.ToString("x2")));
			}
		}

		private bool ValidarFortalezaContrasena(string password)
		{
			return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
		}

		private string GenerarCodigoAleatorio(int longitud = 6)
		{
			const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			Random random = new Random();
			return new string(Enumerable.Repeat(caracteres, longitud)
				.Select(s => s[random.Next(s.Length)]).ToArray());
		}

	}
}
