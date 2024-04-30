using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class datosResultados
    {
        bddColegiaturasV2 _context;

        public datosResultados()
        {
            _context = new bddColegiaturasV2();
        }

        public List<ReporteEstadoPagos_Result> ReporteEstadoPagos()
        {
            return _context.ReporteEstadoPagos().ToList();
        }

        public List<ReporteMorosidadPorPrograma_Result> ReporteMorosidadPorPrograma()
        {
            return _context.ReporteMorosidadPorPrograma().ToList();
        }

    }
}
