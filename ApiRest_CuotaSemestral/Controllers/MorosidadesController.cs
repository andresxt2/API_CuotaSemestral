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
    public class MorosidadesController : ApiController
    {
        logicaMorosidad logicaMorosidad = new logicaMorosidad();
        
        // GET: api/Morosidades
        public IHttpActionResult Get()
        {
            var morosidades = logicaMorosidad.Listar();
            if (morosidades == null)
            {
                return NotFound();
            }
            return Ok(morosidades);
        }

        // GET: api/Morosidades/5
        public IHttpActionResult Get(int id)
        {
            var morosidad = logicaMorosidad.leerPorId(id);
            if (morosidad == null)
            {
                return NotFound();
            }
            return Ok(morosidad);
        }
        //Get listar por estudiante
        [Route("api/Morosidades/Estudiante/{id_estudiante}")]
        public IEnumerable<Morosidad> Get(string id_estudiante)
        {
            return logicaMorosidad.ListarPorEstudiante(id_estudiante);
        }

        // POST: api/Morosidades
        public IHttpActionResult Post([FromBody] Morosidad morosidad)
        {
            if (morosidad == null)
            {
                return BadRequest("La información de morosidad no puede ser nula");
            }

            logicaMorosidad.Insertar(morosidad);
            return CreatedAtRoute("DefaultApi", new { id = morosidad.id_morosidad }, morosidad);
        }

        // PUT: api/Morosidades/5
        public IHttpActionResult Put(int id, [FromBody] Morosidad morosidad)
        {
            if (morosidad == null)
            {
                return BadRequest("Datos inválidos");
            }

            var morosidadExistente = logicaMorosidad.leerPorId(id);
            if (morosidadExistente == null)
            {
                return NotFound();
            }

            logicaMorosidad.Actualizar(morosidad);
            return StatusCode(HttpStatusCode.NoContent);  // NoContent es típicamente usado para respuestas PUT
        }

        // DELETE: api/Morosidades/5
        public IHttpActionResult Delete(int id)
        {
            var morosidadExistente = logicaMorosidad.leerPorId(id);
            if (morosidadExistente == null)
            {
                return NotFound();
            }

            logicaMorosidad.Eliminar(id);
            return Ok($"La morosidad con ID {id} ha sido eliminada correctamente.");
        }
    }
}
