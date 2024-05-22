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
    public class BecasController : ApiController
    {
        private logicaBecas logicaBecas = new logicaBecas();

        // GET api/Becas
        public IEnumerable<Becas_Ayudas_Financieras> Get()
        {
            return logicaBecas.Listar();
        }

        // GET api/Becas/5
        public IHttpActionResult Get(int id)
        {
            var beca = logicaBecas.leerPorId(id);
            if (beca == null)
            {
                return NotFound();
            }
            return Ok(beca);
        }

        //Get listar por estudiante
        [Route("api/Becas/Estudiante/{id_estudiante}")]
        public IEnumerable<Becas_Ayudas_Financieras> Get(string id_estudiante)
        {
            return logicaBecas.ListarPorEstudiante(id_estudiante);
        }

        // POST api/Becas
        public IHttpActionResult Post([FromBody] Becas_Ayudas_Financieras beca)
        {
            if (beca == null)
            {
                return BadRequest("La información de la beca no puede ser nula");
            }

            logicaBecas.Insertar(beca);
            return CreatedAtRoute("DefaultApi", new { id = beca.id_beca }, beca);
        }

        // PUT api/Becas/5
        public IHttpActionResult Put(int id, [FromBody] Becas_Ayudas_Financieras beca)
        {
            if (beca == null)
            {
                return BadRequest("Datos inválidos");
            }

            var becaExistente = logicaBecas.leerPorId(id);
            if (becaExistente == null)
            {
                return NotFound();
            }

            logicaBecas.Actualizar(beca);
            var becaActualizada = logicaBecas.leerPorId(id);
            return Content(HttpStatusCode.OK, becaActualizada);
        }

        // DELETE api/Becas/5
        public IHttpActionResult Delete(int id)
        {
            var becaExistente = logicaBecas.leerPorId(id);
            if (becaExistente == null)
            {
                return NotFound();
            }

            logicaBecas.Eliminar(id);
            return Ok($"La beca con ID {id} ha sido eliminada correctamente.");
        }
    }
}
