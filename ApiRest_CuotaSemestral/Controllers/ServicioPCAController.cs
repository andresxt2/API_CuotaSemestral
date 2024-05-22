using AccesoDatos;
using AccesoDatos.DTO;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRest_CuotaSemestral.Controllers
{
    public class ServicioPCAController : ApiController
    {
        Servicio servicio = new Servicio("Pago de Colegiaturas", "Servicio para pagar la colegiatura semestral de la universidad Bullworth");
        MostrarPagosPCA mostrarPagosPCA = new MostrarPagosPCA();
        logicaPagos logicaPagos = new logicaPagos();

        // GET: api/ServicioPCA
        public Servicio Get()
        {
            return servicio;
        }

        // GET: api/ServicioPCA/5
        public string Get(int id)
        {
            return "value";
        }


        [HttpGet]
        [Route("api/ServicioPCA/mostrarPagos/{cedula}")]
        public IEnumerable<MostrarPagosPCA> mostrarPagosPCAs(string cedula)
        {
            return logicaPagos.mostrarPagosPCAs(cedula);
        }

        [HttpPut]
        [Route("api/ServicioPCA/actualizarEstado/{codPago}")]
        public IHttpActionResult Put(string codPago)
        {
            try
            {
                bool actualizado = logicaPagos.ActualizarEstado(codPago);
                if (actualizado)
                {
                    return Ok(new { mensaje = "El estado del pago se actualizó correctamente." });
                }
                else
                {
                    return BadRequest("No se pudo actualizar el estado del pago.");
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/ServicioPCA
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ServicioPCA/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ServicioPCA/5
        public void Delete(int id)
        {
        }
    }
}
