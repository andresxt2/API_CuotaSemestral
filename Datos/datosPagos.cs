using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.DTO;
namespace Datos
{
    public class datosPagos:IDatos<Pagos>
    {
        bddColegiaturasV2 _context;
        public datosPagos()
        {
            _context = new bddColegiaturasV2();

        }

        #region metodos de Lectura
        public List<Pagos> Listar()
        {
            return _context.Pagos.Where(p => p.borrado_logico == false).ToList();
        }

        public Pagos leerPorId(int id)
        {
            return _context.Pagos.Where(p => p.id_pago == id && p.borrado_logico == false).FirstOrDefault();
        }

        public Pagos leerPorCod(string cod_pago)
        {
            return _context.Pagos.Where(p => p.cod_pago == cod_pago && p.borrado_logico == false).FirstOrDefault();
        }


        #endregion

        #region metodos de escritura
        public void Insertar(Pagos pago)
        {
            pago.borrado_logico = false;
            _context.Pagos.Add(pago);
            _context.SaveChanges();
        }

        public List<MostrarPagosPCA> mostrarPagosPCAs(string cedula)
        {
            var consulta = Listar().Where(p => p.id_estudiante == cedula && p.estado == "pendiente").ToList();

            List<MostrarPagosPCA> lista = new List<MostrarPagosPCA>();

            foreach (var item in consulta)
            {
                MostrarPagosPCA mostrar = new MostrarPagosPCA();
                mostrar.cedula = item.id_estudiante;
                mostrar.cod_pago = item.cod_pago;
                mostrar.monto = item.saldo;
                mostrar.nServicio = "PagoColegiaturas";
                lista.Add(mostrar);
            }
            return lista;
        }



        public bool Actualizar(Pagos pago)
        {
            Pagos pagoModificar = leerPorId(pago.id_pago);
            if(pagoModificar != null) { 
            pagoModificar.fecha_pago = pago.fecha_pago;
            pagoModificar.saldo = pago.saldo;
            pagoModificar.id_estudiante = pago.id_estudiante;
            pagoModificar.estado = pago.estado;
            pagoModificar.semestre = pago.semestre;
            _context.SaveChanges();
            return true;
            }
            return false;
        }

        public bool ActualizarEstado(string cod_pago)
        {
            Pagos pagoModificar = leerPorCod(cod_pago);
            if (pagoModificar != null)
            {
                if(pagoModificar.estado.ToLower().Trim() == "pendiente") { 
                pagoModificar.estado = "pagado";
                _context.SaveChanges();
                return true;
                }
                return false;
            }
            return false;
        }

        public bool Eliminar(int id_pago)
        {
            Pagos pagoEliminar = leerPorId(id_pago);
            if (pagoEliminar != null)
            {
                pagoEliminar.borrado_logico = true;
                pagoEliminar.fecha_borrado_logico = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion
    }
}
