using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Cache;
using Datos;
namespace Logica
{
    public class logicaEstudiantes
    {
        /*
        cacheEstudiantes cacheEstudiantes = new cacheEstudiantes();

        public List<Estudiantes> Listar()
        {
            return cacheEstudiantes.ObtenerTodos();
        }

        public List<Estudiantes> ListarPorPrograma(string programa)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.programa_academico == programa).ToList();
        }

        public List<Estudiantes> ListarPorEstadoMatricula(string estado)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.estado_matricula == estado).ToList();
        }

        public Estudiantes leer(string ci)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.ci_estudiante == ci).FirstOrDefault();
        }

        public void Insertar(Estudiantes estudiante)
        {
            cacheEstudiantes.Insertar(estudiante);
        }

        public void Actualizar(Estudiantes estudiante)
        {
            cacheEstudiantes.Actualizar(estudiante);
        }

        public bool Eliminar(Estudiantes estudiante)
        {
            return cacheEstudiantes.Eliminar(estudiante);
        }

        */


        cacheGeneral<Estudiantes, datosEstudiantes> cacheEstudiantes = new cacheGeneral<Estudiantes, datosEstudiantes>();

        public List<Estudiantes> Listar()
        {
            // Serializar y deserializar
            List<Estudiantes> estudiantes = cacheEstudiantes.ObtenerTodos();
            return estudiantes;
        }

        //Listar por programa academico
        public List<Estudiantes> ListarPorPrograma(string programa)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.programa_academico == programa).ToList();
        }

        public List<Estudiantes> ListarPorEstadoMatricula(string estado)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.estado_matricula == estado).ToList();
        }


        public Estudiantes leer(string ci)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.ci_estudiante == ci).FirstOrDefault();
        }



        public void Insertar(Estudiantes estudiante)
        {
            cacheEstudiantes.Insertar(estudiante);
        }

        public void Actualizar(Estudiantes estudiante)
        {
            cacheEstudiantes.Actualizar(estudiante);
        }

        public bool Eliminar(Estudiantes estudiante)
        {
            return cacheEstudiantes.Eliminar(estudiante);
        }
        

    }
}
