using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
namespace Cache
{
    public class cacheEstudiantes
    {

    }










        /*
        private static List<Estudiantes> _cache = new List<Estudiantes>();

        private datosEstudiantes _datos = new datosEstudiantes();

        public List<Estudiantes> ObtenerTodos()
        {
            if (!_cache.Any())
            {
                CargarDesdeBD();
            }
            return _cache;
        }

        public void Insertar(Estudiantes entidad)
        {
            _datos.Insertar(entidad);
            CargarDesdeBD();
        }

            public void Actualizar(Estudiantes entidad)
        {
            _datos.Actualizar(entidad);
            CargarDesdeBD();
        }

        
        public bool Eliminar(Estudiantes entidad)
        {
            bool resultado = _datos.Eliminar(entidad);
            CargarDesdeBD();
            return resultado;
        }

        private void CargarDesdeBD()
        {
            var accesoDatos = new datosEstudiantes();
            _cache = accesoDatos.Listar();
        }

        */

    
}
