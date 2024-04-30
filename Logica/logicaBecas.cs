using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
namespace Logica
{
    public class logicaBecas
    {
        datosBecasAyudas DatosBecas = new datosBecasAyudas();

        public List<Becas_Ayudas_Financieras> Listar()
        {
            return DatosBecas.Listar();
        }

        public List<Becas_Ayudas_Financieras> ListarPorEstudiante(string id)
        {
            return DatosBecas.Listar().Where(b => b.id_estudiante == id).ToList();
        }

        public List<Becas_Ayudas_Financieras> ListarPorTipo(string tipo)
        {
            return DatosBecas.Listar().Where(e => e.tipo_beca == tipo).ToList();
        }

        public Becas_Ayudas_Financieras ListarPorTipoBeca(string tipo)
        {
            return DatosBecas.Listar().Where(e => e.tipo_beca == tipo).FirstOrDefault();
        }

        public Becas_Ayudas_Financieras leerPorId(int id)
        {
            return DatosBecas.Listar().Where(b => b.id_beca == id).FirstOrDefault();
        }


        public void Insertar(Becas_Ayudas_Financieras beca)
        {
            DatosBecas.Insertar(beca);
        }

        public bool Actualizar(Becas_Ayudas_Financieras beca)
        {
            return DatosBecas.Actualizar(beca);
        }

        public bool Eliminar(int id)
        {
            return DatosBecas.Eliminar(id);
        }
    }
}
