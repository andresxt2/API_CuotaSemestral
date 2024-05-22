using AccesoDatos;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiRest_CuotaSemestral.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ResultadosController : ApiController
    {
        logicaResultados logicaResultados = new logicaResultados();
        // GET: api/Resultados
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Resultados/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/Resultados/ReporteEstadoPagos")]
        public IEnumerable<ReporteEstadoPagos_Result> GetReporteEstadoPagos()
        {
            return logicaResultados.ReporteEstadoPagos();
        }

        [Route("api/Resultados/ReporteMorosidad")]
        public IEnumerable<ReporteMorosidadPorPrograma_Result> GetReporteMorosidadPorPrograma()
        {
            return logicaResultados.ReporteMorosidadPorPrograma();
        }

        // POST: api/Resultados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Resultados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Resultados/5
        public void Delete(int id)
        {
        }
    }
}
