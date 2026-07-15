using CapaDatos;
using CapaNegocio.Usuarios_y_Seguridad.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Usuarios_y_Seguridad
{
	public class csPermisos : IPermisos
	{
		private readonly IConexionBD _conexion;
		private int idRol;
		private string nombrePermiso;
		private string nombreAccion;
		private string listaPermisosAcciones;
		public csPermisos() { _conexion = new csConexionBD(); }

		public int IdRol
		{
			get => idRol;
			set => idRol = value;
		}
		public string NombrePermiso
		{
			get => nombrePermiso;
			set => nombrePermiso = value;
		}
		public string NombreAccion
		{
			get => nombreAccion;
			set => nombreAccion = value;
		}
		public string ListaPermisosAcciones
		{
			get => listaPermisosAcciones;
			set => listaPermisosAcciones = value;
		}

		public DataTable ListarPermisosCat()
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spListarPermisosCat", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				new SqlDataAdapter(cmd).Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public DataTable ObtenerConfiguracionRol(int idRol)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spObtenerConfiguracionRol", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDROL", idRol);
				new SqlDataAdapter(cmd).Fill(dt);
			}
			finally { _conexion.Desconectar(); }
			return dt;
		}

		public int GuardarConfiguracionSeguridad(int idRol, string listaPermisosAcciones)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spGuardarConfiguracionSeguridad", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IDROL", idRol);
				cmd.Parameters.AddWithValue("@LISTA_PERMISOS_ACCIONES", listaPermisosAcciones);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally { _conexion.Desconectar(); }
		}

		public bool ValidarAcceso(int idRol, string nombrePermiso, string nombreAccion)
		{
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spValidarAcceso", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IDROL", idRol);
				cmd.Parameters.AddWithValue("@NOM_PERMISO", nombrePermiso.Trim());
				cmd.Parameters.AddWithValue("@NOM_ACCION", nombreAccion.Trim());

				return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
			}
			finally { _conexion.Desconectar(); }
		}
	}
}
