using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Datos
{
    public class datosBecasAyudas: IDatos<Becas_Ayudas_Financieras>
    {
        bddColegiaturasV2 _context;
        public datosBecasAyudas()
        {
            _context = new bddColegiaturasV2();

        }

        #region metodos de Lectura
        public List<Becas_Ayudas_Financieras> Listar()
        {
            return _context.Becas_Ayudas_Financieras.Where(b => b.borrado_logico == false).ToList();
        }

        public Becas_Ayudas_Financieras leerPorId(int id)
        {
            return _context.Becas_Ayudas_Financieras.Where(b => b.id_beca == id && b.borrado_logico == false).FirstOrDefault();
        }


        #endregion

        #region metodos de escritura
        public void Insertar(Becas_Ayudas_Financieras becaAyuda)
        {
            becaAyuda.borrado_logico = false;
            _context.Becas_Ayudas_Financieras.Add(becaAyuda);
            _context.SaveChanges();
        }

        public bool Actualizar(Becas_Ayudas_Financieras becaAyuda)
        {
            Becas_Ayudas_Financieras becaAyudaModificar = leerPorId(becaAyuda.id_beca);
            if (becaAyudaModificar != null) { 
            becaAyudaModificar.id_estudiante = becaAyuda.id_estudiante;
            becaAyudaModificar.tipo_beca = becaAyuda.tipo_beca;
            becaAyudaModificar.monto = becaAyuda.monto;
            becaAyudaModificar.semestre = becaAyuda.semestre;
            _context.SaveChanges();
            return true;
            }
            return false;
        }

        public bool Eliminar(int id_beca)
        {
            Becas_Ayudas_Financieras becaAyudaEliminar = leerPorId(id_beca);
            if (becaAyudaEliminar != null)
            {
                becaAyudaEliminar.borrado_logico = true;
                becaAyudaEliminar.fecha_borrado_logico = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion
    }
}
