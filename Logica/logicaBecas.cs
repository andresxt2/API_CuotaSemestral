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
    public class logicaBecas
    {
        cacheGeneral<Becas_Ayudas_Financieras, datosBecasAyudas> cacheBecas = new cacheGeneral<Becas_Ayudas_Financieras, datosBecasAyudas>();

        public List<Becas_Ayudas_Financieras> Listar()
        {
            return cacheBecas.ObtenerTodos();
        }

        public List<Becas_Ayudas_Financieras> ListarPorEstudiante(int id)
        {
            return cacheBecas.ObtenerTodos().Where(b => b.id_estudiante == id).ToList();
        }

        public List<Becas_Ayudas_Financieras> ListarPorTipo(string tipo)
        {
            return cacheBecas.ObtenerTodos().Where(e => e.tipo_beca == tipo).ToList();
        }

        public Becas_Ayudas_Financieras ListarPorTipoBeca(string tipo)
        {
            return cacheBecas.ObtenerTodos().Where(e => e.tipo_beca == tipo).FirstOrDefault();
        }

        public Becas_Ayudas_Financieras leerPorId(int id)
        {
            return cacheBecas.ObtenerTodos().Where(b => b.id_beca == id).FirstOrDefault();
        }


        public void Insertar(Becas_Ayudas_Financieras beca)
        {
            cacheBecas.Insertar(beca);
        }

        public bool Actualizar(Becas_Ayudas_Financieras beca)
        {
            return cacheBecas.Actualizar(beca);
        }

        public bool Eliminar(int id)
        {
            return cacheBecas.Eliminar(id);
        }
    }
}
