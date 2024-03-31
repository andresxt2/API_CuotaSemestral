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
    public class logicaPagos
    {
        cacheGeneral<Pagos, datosPagos> cachePagos = new cacheGeneral<Pagos, datosPagos>();

        public List<Pagos> Listar()
        {
            return cachePagos.ObtenerTodos();
        }

        public List<Pagos> ListarPorEstudiante(string ci)
        {
            return cachePagos.ObtenerTodos().Where(e => e.ci_estudiante == ci).ToList();
        }

        public List<Pagos> ListarPorFecha(DateTime fecha)
        {
            return cachePagos.ObtenerTodos().Where(e => e.fecha_pago == fecha).ToList();
        }

        public List<Pagos> ListarPorEstado (string estado)
        {
            return cachePagos.ObtenerTodos().Where(e => e.estado == estado).ToList();
        }

        public Pagos leer(int id)
        {
            return cachePagos.ObtenerTodos().Where(e => e.id_pago == id).FirstOrDefault();
        }

        public void Insertar(Pagos pago)
        {
            cachePagos.Insertar(pago);
        }

        public void Actualizar(Pagos pago)
        {
            cachePagos.Actualizar(pago);
        }

        public bool Eliminar(Pagos pago)
        {
            return cachePagos.Eliminar(pago);
        }
    }
}
