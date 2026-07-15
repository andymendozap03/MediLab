using CapaDatos;
using CapaNegocio.Examen_y_Factura.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace CapaNegocio
{
	public class csExamen : IExamen
	{
		private readonly IConexionBD _conexion;

		private int idExamen;
		private int tipoExamen;
		private double precio;
		private string estado;
		private string fechaSolicitud;


		public int IdExamen
		{
			get => idExamen;
			set => idExamen = value;
		}

		public int TipoExamen
		{
			get => tipoExamen;
			set => tipoExamen = value;
		}

		public double Precio
		{
			get => precio;
			set => precio = value;
		}

		public string Estado
		{
			get => estado;
			set => estado = value;
		}

		public string FechaSolicitud
		{
			get => fechaSolicitud;
			set => fechaSolicitud = value;
		}

		public csExamen() 
		{ 
			_conexion = new csConexionBD(); 
		}


		public DataTable ListarExamenesPorCategoria(int idCategoria)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarExamenesPorCategoria", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDCATEGORIA", idCategoria);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public int ActualizarPrecio(long idExamen, double nuevoPrecio)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spModificarPrecioExamen", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDEXAMEN", idExamen);
				cmd.Parameters.AddWithValue("@PRECIO", nuevoPrecio);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}


		public int RegistrarNuevaSolicitud(long idPersona, long? idMedico, string estado, List<int> idsExamenes)
		{
			try
			{
				string listaIds = string.Join(",", idsExamenes);

				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spRegistrarSolicitudExamen", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDPERSONA", idPersona);

				if (idMedico == null || idMedico <= 0)
					cmd.Parameters.AddWithValue("@IDMEDICO", DBNull.Value);
				else
					cmd.Parameters.AddWithValue("@IDMEDICO", idMedico);

				cmd.Parameters.AddWithValue("@ESTADO_SOLICITUD", estado);
				cmd.Parameters.AddWithValue("@LISTA_EXAMENES", listaIds);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public DataTable ListarSolicitudes()
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarSolicitudes", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}


		public int ModificarSolicitud(long idSolicitud, long idPersona, long? idMedico, string estado, List<int> idsExamenes)
		{
			try
			{
				string listaIds = string.Join(",", idsExamenes);
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spModificarSolicitudExamen", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);
				cmd.Parameters.AddWithValue("@IDPERSONA", idPersona);
				cmd.Parameters.AddWithValue("@IDMEDICO", (object)idMedico ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@ESTADO_SOLICITUD", estado);
				cmd.Parameters.AddWithValue("@LISTA_EXAMENES", listaIds);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public List<int> ObtenerIdsExamenesPorSolicitud(long idSolicitud)
		{
			List<int> ids = new List<int>();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spObtenerDetalleSolicitud", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read()) { ids.Add(Convert.ToInt32(dr["IDEXAMENCOMPUESTO"])); }
				}
			}
			finally { _conexion.Desconectar(); }
			return ids;
		}

		public int EliminarSolicitud(long idSolicitud)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spEliminarSolicitudExamen", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public DataTable BuscarSolicitudes(string dni, string paciente, DateTime? fD, DateTime? fH)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spConsultarSolicitud", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@DNI", string.IsNullOrEmpty(dni) ? (object)DBNull.Value : dni);
				cmd.Parameters.AddWithValue("@PACIENTE", string.IsNullOrEmpty(paciente) ? (object)DBNull.Value : paciente);
				cmd.Parameters.AddWithValue("@FECHA_DESDE", fD.HasValue ? fD.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_HASTA", fH.HasValue ? fH.Value : (object)DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public DataTable ObtenerParametrosParaResultado(long idSolicitud)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spObtenerParametrosParaResultado", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);
				new SqlDataAdapter(cmd).Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

	
		public int GuardarResultado(long idSoli, long idParam, long idUser, string res, string valRef)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spGuardarResultados", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSoli);
				cmd.Parameters.AddWithValue("@IDPARAMETRO", idParam);
				cmd.Parameters.AddWithValue("@IDUSUARIO", idUser);
				cmd.Parameters.AddWithValue("@RESULTADO", res);
				cmd.Parameters.AddWithValue("@VALOR_REF", valRef);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
		
				throw new Exception("Error al guardar el resultado del parámetro " + idParam + ": " + ex.Message);
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

		public DataTable ObtenerDatosReporte(long idSolicitud)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spReporteResultados", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener datos para el reporte: " + ex.Message);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return dt;
		}

		public void EnviarCorreoReporte(string destinatario, string nombrePaciente, string rutaAdjunto, long idOrden)
		{
			try
			{
	
				string miCorreo = "medilab2026@gmail.com";
				string miPasswordApp = "buyofbstmmpuhkkg"; 

				using (MailMessage mail = new MailMessage())
				{
					mail.From = new MailAddress(miCorreo, "LABORATORIO CLÍNICO MEDILAB");
					mail.To.Add(destinatario);
					mail.Subject = $"Resultados de Exámenes Médicos - Orden #{idOrden}";

					mail.Body = $@"Estimado/a {nombrePaciente},

					Adjunto a este correo encontrará el reporte oficial de sus resultados de laboratorio correspondientes a la Orden No. {idOrden}.

					Gracias por confiar en MEDILAB para el cuidado de su salud.

					Atentamente,
					El Equipo de Laboratorio";

					if (File.Exists(rutaAdjunto))
					{
						mail.Attachments.Add(new Attachment(rutaAdjunto));
					}
					else
					{
						throw new Exception("El archivo adjunto no fue encontrado en la ruta especificada.");
					}

					using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
					{
						smtp.Credentials = new NetworkCredential(miCorreo, miPasswordApp);
						smtp.EnableSsl = true;
						smtp.Send(mail);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error en el envío de correo (Capa Negocio): " + ex.Message);
			}
		}

		public DataTable ListarSolicitudesHistorial(int idPersona)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarSolicitudesHistorial", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDPERSONA", idPersona);
				new SqlDataAdapter(cmd).Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

	}
}
