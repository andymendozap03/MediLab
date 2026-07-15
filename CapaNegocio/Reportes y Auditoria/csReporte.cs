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
	public class csReporte : IReporte
	{
		private readonly IConexionBD _conexion;



		private int idReporte;
		private string tipoReporte;
		private string fechaReporte;

		private int tipoFiltro;
		private DateTime? fechaDesde;
		private DateTime? fechaHasta;

		public int IdReporte
		{
			get => idReporte;
			set => idReporte = value;
		}

		public string TipoReporte
		{
			get => tipoReporte;
			set => tipoReporte = value;
		}

		public string FechaReporte
		{
			get => fechaReporte;
			set => fechaReporte = value;
		}
		public int TipoFiltro
		{
			get => tipoFiltro;
			set => tipoFiltro = value;
		}

		public DateTime? FechaDesde
		{
			get => fechaDesde;
			set => fechaDesde = value;
		}

		public DateTime? FechaHasta
		{
			get => fechaHasta;
			set => fechaHasta = value;
		}


		public csReporte() { _conexion = new csConexionBD(); }

        public DataTable ObtenerReporteCantidadExamenes(
			string agruparPor,
			int? ano,
			int? mes,
			int? diaSemana,
			DateTime? desde,
			DateTime? hasta
		)
        {
            DataTable dt = new DataTable();

            try
            {
                _conexion.Conectar();

                SqlCommand cmd = new SqlCommand("spReporteCantidadExamenes", _conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AgruparPor", agruparPor);
                cmd.Parameters.AddWithValue("@Ano", (object)ano ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Mes", (object)mes ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaSemana", (object)diaSemana ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Desde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hasta", (object)hasta ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el reporte de cantidad de exámenes: " + ex.Message);
            }
            finally
            {
                _conexion.Desconectar();
            }

            return dt;
        }

        public DataTable ObtenerReporteExamenesMasSolicitados(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        )
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();
				SqlCommand cmd = new SqlCommand("spReporteExamenesMasSolicitados", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AgruparPor", agruparPor);
                cmd.Parameters.AddWithValue("@Ano", (object)ano ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Mes", (object)mes ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaSemana", (object)diaSemana ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Desde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hasta", (object)hasta ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);

			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener el reporte de examenes mas solicitados: " + ex.Message);
			}
			finally
			{
				_conexion.Desconectar();
			}
			return dt;
		}

		public DataTable ObtenerReporteIngresosPeriodo(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        )
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spReporteIngresoPorPeriodo", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AgruparPor", agruparPor);
                cmd.Parameters.AddWithValue("@Ano", (object)ano ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Mes", (object)mes ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaSemana", (object)diaSemana ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Desde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hasta", (object)hasta ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener el reporte de ingresos por periodo: " + ex.Message);
			}
			finally
			{

				_conexion.Desconectar();
			}

			return dt;
		}
        

        public DataTable ObtenerReporteIngresosPorExamen(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        )
        {
            DataTable dt = new DataTable();
            try
            {
                _conexion.Conectar();

                SqlCommand cmd = new SqlCommand("spReporteIngresoPorExamen", _conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AgruparPor", agruparPor);
                cmd.Parameters.AddWithValue("@Ano", (object)ano ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Mes", (object)mes ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaSemana", (object)diaSemana ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Desde", (object)desde ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hasta", (object)hasta ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el reporte de ingresos por examen: " + ex.Message);
            }
            finally
            {

                _conexion.Desconectar();
            }

            return dt;
        }

        public DataTable ObtenerReporteCuentasPorCobrar(
			int tipoFiltro
		)
		{
			DataTable dt = new DataTable();
			try
			{
				_conexion.Conectar();

				SqlCommand cmd = new SqlCommand("spReporteCuentasPorCobrar", _conexion.ObtenerConexion());
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@TipoFiltro", tipoFiltro);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener el reporte de ingresos por periodo: " + ex.Message);
			}
			finally
			{
				_conexion.Desconectar();
			}

			return dt;
		}
	}
}
