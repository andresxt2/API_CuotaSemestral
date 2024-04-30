using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.DTO;
using Datos;
namespace Logica
{
    public class logicaPagos
    {
        datosPagos DatosPagos = new datosPagos();

        public List<Pagos> Listar()
        {
            return DatosPagos.Listar();
        }

        public List<MostrarPagosPCA> mostrarPagosPCAs(string cedula)
        {
               return DatosPagos.mostrarPagosPCAs(cedula);
        }

        public List<Pagos> ListarPorEstudiante(string id_estudiante)
        {
            return DatosPagos.Listar().Where(e => e.id_estudiante == id_estudiante).ToList();
        }

        public List<Pagos> ListarPorFecha(DateTime fecha)
        {
            return DatosPagos.Listar().Where(e => e.fecha_pago == fecha).ToList();
        }

        public List<Pagos> ListarPorEstado (string estado)
        {
            return DatosPagos.Listar().Where(e => e.estado == estado).ToList();
        }

        public Pagos leerPorId(int id)
        {
            return DatosPagos.Listar().Where(e => e.id_pago == id).FirstOrDefault();
        }



        public void Insertar(Pagos pago)
        {
            DatosPagos.Insertar(pago);
        }

        public bool Actualizar(Pagos pago)
        {
            return DatosPagos.Actualizar(pago);
        }

        public bool ActualizarEstado(string cod_pago)
        {
            return DatosPagos.ActualizarEstado(cod_pago);
        }

        public bool Eliminar(int id)
        {
            return DatosPagos.Eliminar(id);
        }
    }
}
