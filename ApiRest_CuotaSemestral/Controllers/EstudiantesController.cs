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
    public class EstudiantesController : ApiController
    {
        logicaEstudiantes logicaEstudiantes = new logicaEstudiantes();

        // GET Estudiantes
        public IEnumerable<Estudiantes> Get()
        {
            return logicaEstudiantes.Listar();
        }

        // GET api/values/5
        public Estudiantes Get(string id)
        {
            return logicaEstudiantes.leerPorId(id);
        }

        // POST api/values
        /*  public void Post([FromBody] Estudiantes estudiante)
          {
              if (estudiante != null)
              {
                  logicaEstudiantes.Insertar(estudiante);
              }  
          }*/

        // POST api/estudiantes
        public IHttpActionResult Post([FromBody] Estudiantes estudiante)
        {
            if (estudiante == null)
            {
                return BadRequest("El estudiante no puede ser nulo");
            }

            logicaEstudiantes.Insertar(estudiante);
            return CreatedAtRoute("DefaultApi", new { id = estudiante.id_estudiante }, estudiante);
        }


        // PUT api/values/5
        // PUT api/estudiantes/5
        public IHttpActionResult Put(string id, [FromBody] Estudiantes estudiante)
        {
            if (estudiante == null || estudiante.id_estudiante != id)
            {
                return BadRequest("Datos inválidos");
            }

            var estudianteExistente = logicaEstudiantes.leerPorId(id);
            if (estudianteExistente == null)
            {
                return NotFound();
            }

            // Actualizar el estudiante
            logicaEstudiantes.Actualizar(estudiante);

            // Obtener el estudiante actualizado después de la actualización
            var estudianteActualizado = logicaEstudiantes.leerPorId(id);

            // Devolver el estudiante actualizado junto con un código de estado
            return Content(HttpStatusCode.OK, estudianteActualizado);
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(string id)
        {
            logicaEstudiantes.Eliminar(id);
            return Ok("El estudiante ha sido eliminado correctamente");
        }
    }
}
