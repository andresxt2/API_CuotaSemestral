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
    public class PagosController : ApiController
    {
        logicaPagos logicaPagos = new logicaPagos();
        

        // GET: api/Pagos
        public IEnumerable<Pagos> Get()
        {
            return logicaPagos.Listar();
        }

        // GET api/Pagos/5
        public IHttpActionResult Get(int id)
        {
            Pagos pago = logicaPagos.leerPorId(id);
            if (pago == null)
            {
                return NotFound();
            }
            return Ok(pago);
        }

        //Get listar por estudiante
        [Route("api/Pagos/Estudiante/{id_estudiante}")]
        public IEnumerable<Pagos> Get(string id_estudiante)
        {
            return logicaPagos.ListarPorEstudiante(id_estudiante);
        }

        // POST api/Pagos
        public IHttpActionResult Post([FromBody] Pagos pago)
        {
            if (pago == null)
            {
                return BadRequest("El pago no puede ser nulo");
            }

            logicaPagos.Insertar(pago);
            return CreatedAtRoute("DefaultApi", new { id = pago.id_pago }, pago);
        }

        // PUT api/Pagos/5
        public IHttpActionResult Put(int id, [FromBody] Pagos pago)
        {
            if (pago == null)
            {
                return BadRequest("El pago proporcionado es inválido");
            }

            var pagoExistente = logicaPagos.leerPorId(id);
            if (pagoExistente == null)
            {
                return NotFound();
            }

            logicaPagos.Actualizar(pago);
            var pagoActualizado = logicaPagos.leerPorId(id);
            return Content(HttpStatusCode.OK, pagoActualizado);
        }

        // DELETE api/Pagos/5
        public IHttpActionResult Delete(int id)
        {
            var pagoExistente = logicaPagos.leerPorId(id);
            if (pagoExistente == null)
            {
                return NotFound();
            }

            logicaPagos.Eliminar(id);
            return Ok($"El pago con ID {id} ha sido eliminado correctamente.");
        }
    }
}
