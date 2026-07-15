using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio.Reportes_y_Auditoria.Interfaces
{
    public interface IReporte
    {
        DataTable ObtenerReporteCantidadExamenes(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        );

        DataTable ObtenerReporteExamenesMasSolicitados(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        );

        DataTable ObtenerReporteIngresosPeriodo(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        );

        DataTable ObtenerReporteCuentasPorCobrar(
            int tipoFiltro
        );

        DataTable ObtenerReporteIngresosPorExamen(
            string agruparPor,
            int? ano,
            int? mes,
            int? diaSemana,
            DateTime? desde,
            DateTime? hasta
        );

    }
}
