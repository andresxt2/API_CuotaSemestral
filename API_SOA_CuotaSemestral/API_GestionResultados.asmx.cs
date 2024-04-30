using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using AccesoDatos;
namespace API_SOA_CuotaSemestral
{
    /// <summary>
    /// Descripción breve de API_GestionResultados
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_GestionResultados : System.Web.Services.WebService
    {
        logicaResultados _logicaResultados = new logicaResultados();

        [WebMethod]

        public List<ReporteEstadoPagos_Result> SPReporteEstadoPagos()
        {
            return _logicaResultados.ReporteEstadoPagos();
        }

        [WebMethod]

        public List<ReporteMorosidadPorPrograma_Result> SPReporteMorosidadPorPrograma()
        {
            return _logicaResultados.ReporteMorosidadPorPrograma();
        }
        
    }
}
