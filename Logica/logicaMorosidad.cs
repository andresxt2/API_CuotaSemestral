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
    public class logicaMorosidad
    {
        cacheGeneral<Morosidad, datosMorosidad> cacheMorosidad = new cacheGeneral<Morosidad, datosMorosidad>();

        public List<Morosidad> Listar()
        {
            return cacheMorosidad.ObtenerTodos();
        }

        public List<Morosidad> ListarPorEstudiante (int id_estudiante)
        {
            return cacheMorosidad.ObtenerTodos().Where(e => e.id_estudiante == id_estudiante).ToList();
        }

        public List<Morosidad> ListarPorDiasRetraso(int dias)
        {
            return cacheMorosidad.ObtenerTodos().Where(e => e.dias_retraso == dias).ToList();
        }

        public Morosidad leerPorId(int id)
        {
            return cacheMorosidad.ObtenerTodos().Where(e => e.id_morosidad == id).FirstOrDefault();
        }

        public void Insertar(Morosidad morosidad)
        {
            cacheMorosidad.Insertar(morosidad);
        }

        public void Actualizar(Morosidad morosidad)
        {
            cacheMorosidad.Actualizar(morosidad);
        }

        public bool Eliminar(int id )
        {
            return cacheMorosidad.Eliminar(id);
        }

    }
}
