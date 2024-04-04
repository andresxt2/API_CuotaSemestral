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
        bddColegiaturasV2 _context;
        public datosMorosidad()
        {
            _context = new bddColegiaturasV2();

        }

        #region metodos de Lectura
        public List<Morosidad> Listar()
        {
            return _context.Morosidad.Where(m => m.borrado_logico == false).ToList();
        }

        public Morosidad leerPorId(int id)
        {
            return _context.Morosidad.Where(m => m.id_morosidad == id && m.borrado_logico == false).FirstOrDefault();
        }


        #endregion

        #region metodos de escritura
        public void Insertar(Morosidad morosidad)
        {
            morosidad.borrado_logico = false;
            _context.Morosidad.Add(morosidad);
            _context.SaveChanges();
        }

        public void Actualizar(Morosidad morosidad)
        {
            Morosidad morosidadModificar = leerPorId(morosidad.id_morosidad);
            morosidadModificar.id_estudiante = morosidad.id_estudiante;
            morosidadModificar.semestre = morosidad.semestre;
            morosidadModificar.dias_retraso = morosidad.dias_retraso;
            morosidadModificar.monto_debido = morosidad.monto_debido;
            _context.SaveChanges();
        }

        public bool Eliminar(int id_morosidad)
        {
            Morosidad morosidadEliminar = leerPorId(id_morosidad);
            if (morosidadEliminar != null)
            {
                morosidadEliminar.borrado_logico = true;
                morosidadEliminar.fecha_borrado_logico = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion
    }
}
