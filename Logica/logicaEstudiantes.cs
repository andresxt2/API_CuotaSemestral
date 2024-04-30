using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
namespace Logica
{
    public class logicaEstudiantes
    {
        datosEstudiantes DatosEstudiantes = new datosEstudiantes();
        public List<Estudiantes> Listar()
        {
            // Serializar y deserializar
            List<Estudiantes> estudiantes = DatosEstudiantes.Listar();
            return estudiantes;
        }


        //listar por id
        public Estudiantes leerPorId(string id)
        {
            return DatosEstudiantes.Listar().Where(e => e.id_estudiante == id).FirstOrDefault();
        }


        //Listar por programa academico
        public List<Estudiantes> ListarPorPrograma(string programa)
        {
            return DatosEstudiantes.Listar().Where(e => e.programa_academico == programa).ToList();
        }

        public List<Estudiantes> ListarPorEstadoMatricula(string estado)
        {
            return DatosEstudiantes.Listar().Where(e => e.estado_matricula == estado).ToList();
        }


        public void Insertar(Estudiantes estudiante)
        {
            DatosEstudiantes.Insertar(estudiante);
        }

        public bool Actualizar(Estudiantes estudiante)
        {
            return DatosEstudiantes.Actualizar(estudiante);
        }

        public bool Eliminar(string id)
        {
            return DatosEstudiantes.Eliminar(id);
        }  
    }
}
