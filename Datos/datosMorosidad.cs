using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Datos
{
    public class datosMorosidad:IDatos<Morosidad>
    {
        bddColegiaturas bdd;
        public datosMorosidad()
        {
            bdd = new bddColegiaturas();

        }

        #region metodos de Lectura
        public List<Morosidad> Listar()
        {
            return bdd.Morosidad.ToList();
        }

        public Morosidad leer(int id)
        {
            return bdd.Morosidad.Where(m => m.id_morosidad == id).FirstOrDefault();
        }

        public Morosidad leer(string id)
        {
            return null;
        }

        #endregion

        #region metodos de escritura
        public void Insertar(Morosidad morosidad)
        {
            bdd.Morosidad.Add(morosidad);
            bdd.SaveChanges();
        }

        public void Actualizar(Morosidad morosidad)
        {
            Morosidad morosidadModificar = leer(morosidad.id_morosidad);
            morosidadModificar.ci_estudiante = morosidad.ci_estudiante;
            morosidadModificar.semestre = morosidad.semestre;
            morosidadModificar.dias_retraso = morosidad.dias_retraso;
            morosidadModificar.monto_debido = morosidad.monto_debido;
            bdd.SaveChanges();
        }

        public bool Eliminar (Morosidad morosidad)
        {
            Morosidad morosidadEliminar = leer(morosidad.id_morosidad);
            if (morosidadEliminar != null)
            {
                bdd.Morosidad.Remove(morosidadEliminar);
                bdd.SaveChanges();
                return true;
            }else
                return false;
        }
        #endregion
    }
}
