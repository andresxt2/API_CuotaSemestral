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
        bddColegiaturas bdd;
        public datosPagos()
        {
            bdd = new bddColegiaturas();

        }

        #region metodos de Lectura
        public List<Pagos> Listar()
        {
            return bdd.Pagos.ToList();
        }

        public Pagos leer(int id)
        {
            return bdd.Pagos.Where(p => p.id_pago == id).FirstOrDefault();
        }

        public Pagos leer(string id)
        {
          // Sin implementar
          return null;
        }

        #endregion

        #region metodos de escritura
        public void Insertar(Pagos pago)
        {
            bdd.Pagos.Add(pago);
            bdd.SaveChanges();
        }

        public void Actualizar(Pagos pago)
        {
            Pagos pagoModificar = bdd.Pagos.Where(p => p.id_pago == pago.id_pago).FirstOrDefault();
            pagoModificar.fecha_pago = pago.fecha_pago;
            pagoModificar.monto = pago.monto;
            pagoModificar.ci_estudiante = pago.ci_estudiante;
            bdd.SaveChanges();
        }

        public bool Eliminar(Pagos pago)
        {
            Pagos pagoEliminar = leer(pago.id_pago);
            if (pagoEliminar != null)
            {
                bdd.Pagos.Remove(pagoEliminar);
                bdd.SaveChanges();
                return true;
            }else
                return false;
        }
        #endregion
    }
}
