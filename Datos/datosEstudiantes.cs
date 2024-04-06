using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Datos
{
    public class datosEstudiantes:IDatos<Estudiantes>
    {
        bddColegiaturasV2 _context;
        public datosEstudiantes()
        {
            _context = new bddColegiaturasV2();

        }

        #region metodos de Lectura
        public List<Estudiantes> Listar()
        {
            var estudiantes = _context.Estudiantes.Where(e => e.borrado_logico == false).ToList();
            return estudiantes;
        }


        public Estudiantes leerPorId(int id)
        {
            return _context.Estudiantes.Where(e => e.id_estudiante == id && e.borrado_logico == false).FirstOrDefault();
        }

        #endregion

        #region metodos de escritura
        public void Insertar(Estudiantes estudiante)
        {
            estudiante.borrado_logico = false;
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
        }

        public bool Actualizar(Estudiantes estudiante)
        {
            Estudiantes estudianteModificar = leerPorId(estudiante.id_estudiante);
            if (estudianteModificar != null) { 
            estudianteModificar.nombre = estudiante.nombre;
            estudianteModificar.correo_electronico = estudiante.correo_electronico;
            estudianteModificar.programa_academico = estudiante.programa_academico;
            estudianteModificar.estado_matricula = estudiante.estado_matricula;
            _context.SaveChanges();
            return true;
            }
            return false;

        }

        public bool Eliminar(int id_estudiante)
        {
            Estudiantes estudianteEliminar = leerPorId(id_estudiante);
            if (estudianteEliminar != null)
            {
                estudianteEliminar.borrado_logico = true;
                estudianteEliminar.fecha_borrado_logico = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion

        public bool validarAtributoNulo (string atributo)
        {
            return string.IsNullOrEmpty(atributo);
        }

    }
}
