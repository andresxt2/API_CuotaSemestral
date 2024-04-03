using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
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


        #endregion

        #region metodos de escritura
        public void Insertar(Pagos pago)
        {
            _context.Pagos.Add(pago);
            _context.SaveChanges();
        }

        public void Actualizar(Pagos pago)
        {
            Pagos pagoModificar = leerPorId(pago.id_pago);
            pagoModificar.fecha_pago = pago.fecha_pago;
            pagoModificar.monto = pago.monto;
            pagoModificar.id_estudiante = pago.id_estudiante;
            _context.SaveChanges();
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
