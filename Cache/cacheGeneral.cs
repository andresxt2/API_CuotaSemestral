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

        public void Insertar(TEntidad entidad)
        {
            _datos.Insertar(entidad);
            CargarDesdeBD();
        }

        public bool Actualizar(TEntidad entidad)
        {
            bool resultado = _datos.Actualizar(entidad);
            CargarDesdeBD();
            return resultado;
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
