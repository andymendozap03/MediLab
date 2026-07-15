using CapaDatos;
using CapaNegocio.Examen_y_Factura.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class csFactura : IFactura
	{
		private readonly IConexionBD _conexion;

		private int idFactura;
		private string fechaFactura;
		private decimal total;

		private string destinatarioCorreo;
		private string nombrePaciente;
		private string rutaAdjunto;

		public int IdFactura
		{
			get => idFactura;
			set => idFactura = value;
		}

		public string FechaFactura
		{
			get => fechaFactura;
			set => fechaFactura = value;
		}

		public decimal Total
		{
			get => total;
			set => total = value;
		}

		public string DestinatarioCorreo
		{
			get => destinatarioCorreo;
			set => destinatarioCorreo = value;
		}

		public string NombrePaciente
		{
			get => nombrePaciente;
			set => nombrePaciente = value;
		}

		public string RutaAdjunto
		{
			get => rutaAdjunto;
			set => rutaAdjunto = value;
		}

		public csFactura()
		{
			_conexion = new csConexionBD();
		}


		public void EnviarCorreoFactura(string destinatario, string nombrePaciente, string rutaAdjunto, long idFactura)
		{
			try
			{

				string miCorreo = "medilab2026@gmail.com";
				string miPasswordApp = "buyofbstmmpuhkkg";

				using (MailMessage mail = new MailMessage())
				{
					mail.From = new MailAddress(miCorreo, "LABORATORIO CLÍNICO MEDILAB");
					mail.To.Add(destinatario);
					mail.Subject = $"Resultados de Exámenes Médicos - Factura #{idFactura}";

					mail.Body = $@"Estimado/a {nombrePaciente},

					Adjunto a este correo encontrará la factura oficial de sus resultados de laboratorio correspondientes a la factura No. {idFactura}.

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

		public DataTable ObtenerExamenesParaFacturacion(long idSolicitud)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spObtenerExamenesParaFacturacion", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return dt;
		}

		public int RegistrarFactura(long idSolicitud, decimal total, DataTable detalle)
		{
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spRegistrarFactura", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDSOLICITUD", idSolicitud);
				cmd.Parameters.AddWithValue("@TOTAL", total);

				SqlParameter paramDetalle = cmd.Parameters.AddWithValue("@DETALLE", detalle);
				paramDetalle.SqlDbType = SqlDbType.Structured;
				paramDetalle.TypeName = "DetalleFacturaType";

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

		public DataTable ListarFacturas()
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarFacturas", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return dt;
		}

		public DataTable BuscarFacturas(int? idFactura, int? idSolicitud, string dni, DateTime? desde, DateTime? hasta)
		{
			DataTable dt = new DataTable();

			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spConsultarFactura", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDFACTURA", (object)idFactura ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IDSOLICITUD", (object)idSolicitud ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@DNI", string.IsNullOrWhiteSpace(dni) ? (object)DBNull.Value : dni);
				cmd.Parameters.AddWithValue("@FECHA_DESDE", (object)desde ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_HASTA", (object)hasta ?? DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally
			{
				_conexion.Desconectar();
			}

			return dt;
		}

		public DataTable ObtenerDatosFactura(long idFactura)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spReporteFactura", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDFACTURA", idFactura);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener datos de la factura: " + ex.Message);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return dt;
		}

		public void AnularFactura(long idFactura)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spAnularFactura", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDFACTURA", idFactura);
					cmd.ExecuteNonQuery();
				}
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

		public void ReactivarFactura(long idFactura)
		{
			try
			{
				_conexion.Conectar();
				using (SqlCommand cmd = new SqlCommand("spReactivarFactura", _conexion.ObtenerConexion()))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@IDFACTURA", idFactura);
					cmd.ExecuteNonQuery();
				}
			}
			finally
			{
				_conexion.Desconectar();
			}
		}
	}
}
