using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;
namespace Logica
{
    public class logicaResultados
    {
        datosResultados _datosResultados;
        public logicaResultados()
        {
            _datosResultados = new Datos.datosResultados();
        }


        public List<ReporteEstadoPagos_Result> ReporteEstadoPagos()
        {
            return _datosResultados.ReporteEstadoPagos();
        }

        public List<ReporteMorosidadPorPrograma_Result> ReporteMorosidadPorPrograma()
        {
            return _datosResultados.ReporteMorosidadPorPrograma();
        }
    }
}
