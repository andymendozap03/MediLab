using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class csMedico : csPersona, IMedico
	{
		private readonly IConexionBD _conexion;

		private int idMedico;
		private int idEspecialidad;
		private string especialidadMedico;
		private double comision;
		private int idUsuarioRegistro;

		public csMedico() { _conexion = new csConexionBD(); }

		public int IdMedico
		{
			get => idMedico;
			set => idMedico = value;
		}
		public int IdEspecialidad
		{
			get => idEspecialidad;
			set => idEspecialidad = value;
		}
		public string EspecialidadMedico
		{
			get => especialidadMedico;
			set => especialidadMedico = value;
		}
		public double Comision
		{
			get => comision;
			set => comision = value;
		}
		public int IdUsuarioRegistro
		{
			get => idUsuarioRegistro;
			set => idUsuarioRegistro = value;
		}

		public int RegistrarMedico()
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spRegistrarMedico", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@DNI", DNIpersona);
				cmd.Parameters.AddWithValue("@NOMBRES", nombrePersona);
				cmd.Parameters.AddWithValue("@APELLIDOS", apellidoPersona);
				cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", fechaNacimiento);
				cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", correo);
				cmd.Parameters.AddWithValue("@TELEFONO", telefono);
				cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
				cmd.Parameters.AddWithValue("@GENERO", genero);
				cmd.Parameters.AddWithValue("@IDESPECIALIDAD", IdEspecialidad);
				cmd.Parameters.Add(new SqlParameter("@COMISION", SqlDbType.Decimal)
				{
					Value = this.Comision,
					Precision = 7,
					Scale = 4
				});
				cmd.Parameters.AddWithValue("@IDUSUARIO_REGISTRO", IdUsuarioRegistro);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public int ModificarMedico()
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spModificarMedico", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDMEDICO", IdMedico);
				cmd.Parameters.AddWithValue("@IDPERSONA", IdPersona);
				cmd.Parameters.AddWithValue("@DNI", DNIpersona);
				cmd.Parameters.AddWithValue("@NOMBRES", nombrePersona);
				cmd.Parameters.AddWithValue("@APELLIDOS", apellidoPersona);
				cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", fechaNacimiento);
				cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", correo);
				cmd.Parameters.AddWithValue("@TELEFONO", telefono);
				cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
				cmd.Parameters.AddWithValue("@GENERO", genero);
				cmd.Parameters.AddWithValue("@IDESPECIALIDAD", IdEspecialidad);
				cmd.Parameters.Add(new SqlParameter("@COMISION", SqlDbType.Decimal)
				{
					Value = this.Comision,
					Precision = 7,
					Scale = 4
				});
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public int EliminarMedico(long idMedico)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spEliminarMedico", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDMEDICO", idMedico);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public DataTable ListarMedicos()
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlDataAdapter da = new SqlDataAdapter("spListarMedicos", _conexion.ObtenerConexion());
				da.Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public DataTable BuscarMedico(string nom, string ape, string dni, char? gen, string esp, DateTime? fD, DateTime? fH)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spConsultarMedicos", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@NOMBRES", string.IsNullOrEmpty(nom) ? (object)DBNull.Value : nom);
				cmd.Parameters.AddWithValue("@APELLIDOS", string.IsNullOrEmpty(ape) ? (object)DBNull.Value : ape);
				cmd.Parameters.AddWithValue("@DNI", string.IsNullOrEmpty(dni) ? (object)DBNull.Value : dni);
				cmd.Parameters.AddWithValue("@GENERO", gen.HasValue ? gen.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@ESPECIALIDAD", string.IsNullOrEmpty(esp) ? (object)DBNull.Value : esp);
				cmd.Parameters.AddWithValue("@FECHA_DESDE", fD.HasValue ? fD.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_HASTA", fH.HasValue ? fH.Value : (object)DBNull.Value);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public DataTable ListarEspecialidades()
		{
			DataTable dt = new DataTable();
			csConexionBD conexion = new csConexionBD();
			try
			{
				conexion.Conectar();
				SqlDataAdapter da = new SqlDataAdapter("spListarEspecialidades", conexion.ObtenerConexion());
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.Fill(dt);
			}
			finally { conexion.Desconectar(); }
			return dt;
		}

		public int GestionarEspecialidad(string proc, int id, string nombre)
		{
			csConexionBD conexion = new csConexionBD();
			try
			{
				conexion.Conectar();
				SqlCommand cmd = new SqlCommand(proc, conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				if (id > 0) cmd.Parameters.AddWithValue("@ID", id);
				if (nombre != null) cmd.Parameters.AddWithValue("@NOMBRE", nombre);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { conexion.Desconectar(); }
		}
	}
}
