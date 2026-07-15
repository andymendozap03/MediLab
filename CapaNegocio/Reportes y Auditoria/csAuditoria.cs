using CapaDatos;
using CapaNegocio.Reportes_y_Auditoria.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class csAuditoria : IAuditoria
	{
		private long idAuditoria;
		private long? idUsuario;
		private string accion;
		private string descripcionAuditoria;
		private DateTime fechaAuditoria;
		private string nombreUsuario;

		private readonly IConexionBD _conexion = new csConexionBD();

		public long IdAuditoria
		{
			get { return idAuditoria; }
			set { idAuditoria = value; }
		}

		public long? IdUsuario
		{
			get { return idUsuario; }
			set { idUsuario = value; }
		}

		public string Accion
		{
			get { return accion; }
			set { accion = value; }
		}

		public string DescripcionAuditoria
		{
			get { return descripcionAuditoria; }
			set { descripcionAuditoria = value; }
		}

		public DateTime FechaAuditoria
		{
			get { return fechaAuditoria; }
			set { fechaAuditoria = value; }
		}
		public string NombreUsuario
		{
			get => nombreUsuario;
			set => nombreUsuario = value;
		}

		public int RegistrarAuditoria(long? idUsuario, int idAccion, int idPermiso, string descripcion)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spRegistrarAuditoria", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDUSUARIO", (object)idUsuario ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IDACCION", idAccion);
				cmd.Parameters.AddWithValue("@IDPERMISO", idPermiso);
				cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public DataTable ListarAuditoria()
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarAuditoria", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				new SqlDataAdapter(cmd).Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public DataTable BuscarAuditoria(string usuario, string accion, string modulo, DateTime? desde, DateTime? hasta)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spConsultarAuditoria", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@USUARIO", string.IsNullOrEmpty(usuario) ? (object)DBNull.Value : usuario);
				cmd.Parameters.AddWithValue("@ACCION", string.IsNullOrEmpty(accion) ? (object)DBNull.Value : accion);
				cmd.Parameters.AddWithValue("@MODULO", string.IsNullOrEmpty(modulo) ? (object)DBNull.Value : modulo);
				cmd.Parameters.AddWithValue("@FECHA_DESDE", desde?.Date ?? (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_HASTA", hasta?.Date ?? (object)DBNull.Value);

				new SqlDataAdapter(cmd).Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}
	}
}
