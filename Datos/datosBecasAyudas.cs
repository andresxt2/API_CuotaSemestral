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
        bddColegiaturas bdd;
        public datosBecasAyudas()
        {
            bdd = new bddColegiaturas();

        }

        #region metodos de Lectura
        public List<Becas_Ayudas_Financieras> Listar()
        {
            return bdd.Becas_Ayudas_Financieras.ToList();
        }

        public Becas_Ayudas_Financieras leer(int id)
        {
            return bdd.Becas_Ayudas_Financieras.Where(b => b.id_beca == id).FirstOrDefault();
        }

        public Becas_Ayudas_Financieras leer(string id)
        {return null;
        }

        #endregion

        #region metodos de escritura
        public void Insertar(Becas_Ayudas_Financieras becaAyuda)
        {
            bdd.Becas_Ayudas_Financieras.Add(becaAyuda);
            bdd.SaveChanges();
        }

        public void Actualizar(Becas_Ayudas_Financieras becaAyuda)
        {
            Becas_Ayudas_Financieras becaAyudaModificar = leer(becaAyuda.id_beca);
            becaAyudaModificar.ci_estudiante = becaAyuda.ci_estudiante;
            becaAyudaModificar.tipo_beca = becaAyuda.tipo_beca;
            becaAyudaModificar.monto = becaAyuda.monto;
            becaAyudaModificar.semestre = becaAyuda.semestre;
            bdd.SaveChanges();
        }

        public bool Eliminar(Becas_Ayudas_Financieras beca)
        {
            Becas_Ayudas_Financieras becaAyudaEliminar = leer(beca.id_beca);
            if (becaAyudaEliminar != null)
            {
                bdd.Becas_Ayudas_Financieras.Remove(becaAyudaEliminar);
                bdd.SaveChanges();
                return true;
            }else
                return false;
        }
        #endregion
    }
}
