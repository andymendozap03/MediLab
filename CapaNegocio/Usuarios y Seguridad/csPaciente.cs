using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class csPaciente : csPersona, IPaciente
	{
		private readonly IConexionBD _conexion;
		private int idUsuarioRegistro;

		public csPaciente()
		{
			_conexion = new csConexionBD();
		}

		public csPaciente(IConexionBD conexion)
		{
			_conexion = conexion;
		}

		public int IdUsuarioRegistro
		{
			get { return idUsuarioRegistro; }
			set { idUsuarioRegistro = value; }
		}

		public int RegistrarPaciente()
		{
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spRegistrarPaciente", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@DNI", DNIpersona);
				cmd.Parameters.AddWithValue("@NOMBRES", nombrePersona);
				cmd.Parameters.AddWithValue("@APELLIDOS", apellidoPersona);
				cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", fechaNacimiento);
				cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", correo);
				cmd.Parameters.AddWithValue("@TELEFONO", telefono);
				cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
				cmd.Parameters.AddWithValue("@GENERO", genero);
				cmd.Parameters.AddWithValue("@IDUSARIO_REGISTRO", IdUsuarioRegistro);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				throw new Exception("Error al registrar paciente", ex);
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

		public int ModificarPaciente()
		{
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spModificarPaciente", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDPERSONA", IdPersona);
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
			catch (Exception ex)
			{
				throw new Exception("Error al modificar paciente", ex);
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

		public int EliminarPaciente(long idPersona)
		{
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spEliminarPaciente", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDPERSONA", idPersona);

				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				throw new Exception("Error al eliminar paciente", ex);
			}
			finally
			{
				_conexion.Desconectar();
			}
		}

		public DataTable BuscarPaciente(string nombres, string apellidos, string dni, char? genero, DateTime? fechaDesde, DateTime? fechaHasta)
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spConsultarPaciente", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@NOMBRES", string.IsNullOrWhiteSpace(nombres) ? (object)DBNull.Value : nombres);
				cmd.Parameters.AddWithValue("@APELLIDOS", string.IsNullOrWhiteSpace(apellidos) ? (object)DBNull.Value : apellidos);
				cmd.Parameters.AddWithValue("@DNI", string.IsNullOrWhiteSpace(dni) ? (object)DBNull.Value : dni);
				cmd.Parameters.AddWithValue("@GENERO", genero.HasValue ? genero.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_DESDE", fechaDesde.HasValue ? fechaDesde.Value : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@FECHA_HASTA", fechaHasta.HasValue ? fechaHasta.Value : (object)DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return tabla;
		}

		public DataTable ListarPacientes()
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarPacientes", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}
			catch (Exception ex)
			{
				throw new Exception("Error al listar pacientes", ex);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return tabla;
		}

		public DataTable BuscarPersonaPorDNI(string dni)
		{
			DataTable tabla = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spBuscarPersonaPorDNI", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@DNI", dni);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return tabla;
		}


	}
}
