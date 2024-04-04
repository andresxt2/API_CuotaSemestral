using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Cache
{
    public class cacheGeneral<TEntidad, TDatos> where TDatos : IDatos<TEntidad>, new() where TEntidad : class
    {
        private static List<TEntidad> _cache;
        private TDatos _datos = new TDatos();


        public List<TEntidad> ObtenerTodos()
        {
            if (_cache == null)
            {
                CargarDesdeBD();
            }
            return _cache;
        }

        public TEntidad leerPorId(int id)
        {
            if (_cache == null)
            {
                CargarDesdeBD();
            }
            return _cache.Where(e => e.Equals(id)).FirstOrDefault();
        }

        public void Insertar(TEntidad entidad)
        {
            _datos.Insertar(entidad);
            CargarDesdeBD();
        }

        public void Actualizar(TEntidad entidad)
        {
            _datos.Actualizar(entidad);
            CargarDesdeBD();
        }

        public bool Eliminar(int id)
        {
            bool resultado = _datos.Eliminar(id);
            CargarDesdeBD();
            return resultado;
        }

        private void CargarDesdeBD()
        {
            _cache = new List<TEntidad>();
            _cache = _datos.Listar();
        }
    }
}
