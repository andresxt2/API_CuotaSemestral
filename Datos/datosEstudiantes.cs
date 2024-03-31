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
        bddColegiaturas bdd;
        public datosEstudiantes()
        {
            bdd = new bddColegiaturas();

        }

        #region metodos de Lectura
        public List<Estudiantes> Listar()
        {
            return bdd.Estudiantes.ToList();
        }

        public Estudiantes leer(string ci)
        {
            return bdd.Estudiantes.Where(e => e.ci_estudiante == ci).FirstOrDefault();
        }

        public Estudiantes leer(int ci)
        {
            return null;
        }

        #endregion

        #region metodos de escritura
        public void Insertar(Estudiantes estudiante)
        {
            bdd.Estudiantes.Add(estudiante);
            bdd.SaveChanges();
        }

        public void Actualizar(Estudiantes estudiante)
        {
            Estudiantes estudianteModificar = bdd.Estudiantes.Where(e => e.ci_estudiante == estudiante.ci_estudiante).FirstOrDefault();
            estudianteModificar.nombre = estudiante.nombre;
            estudianteModificar.correo_electronico = estudiante.correo_electronico;
            estudianteModificar.programa_academico = estudiante.programa_academico;
            estudianteModificar.estado_matricula = estudiante.estado_matricula;
            bdd.SaveChanges();
        }

        public bool Eliminar(Estudiantes estudiante)
        {
            Estudiantes estudianteEliminar = leer(estudiante.ci_estudiante);
            if (estudianteEliminar != null)
            {
                bdd.Estudiantes.Remove(estudianteEliminar);
                bdd.SaveChanges();
                return true;
            }else
                return false;
        }
        #endregion

    }
}
