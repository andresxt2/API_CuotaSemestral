using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using AccesoDatos;
namespace API_SOA_CuotaSemestral
{
    /// <summary>
    /// Descripción breve de API_GestionBecas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_GestionBecas : System.Web.Services.WebService
    {
        logicaBecas logicaBecas = new logicaBecas();

        [WebMethod]
        public List<Becas_Ayudas_Financieras> Listar()
        {
            return logicaBecas.Listar();
        }

        [WebMethod]
        public List<Becas_Ayudas_Financieras> ListarPorEstudiante(int id)
        {
            return logicaBecas.ListarPorEstudiante(id);
        }

        [WebMethod]
        public List<Becas_Ayudas_Financieras> ListarPorTipo(string tipo)
        {
            return logicaBecas.ListarPorTipo(tipo);
        }

        [WebMethod]
        public Becas_Ayudas_Financieras ListarPorTipoBeca(string tipo)
        {
            return logicaBecas.ListarPorTipoBeca(tipo);
        }

        [WebMethod]
        public Becas_Ayudas_Financieras leerPorId(int id)
        {
            return logicaBecas.leerPorId(id);
        }

        [WebMethod]
        public void Insertar(Becas_Ayudas_Financieras beca)
        {
            logicaBecas.Insertar(beca);
        }

        [WebMethod]
        public bool Actualizar(Becas_Ayudas_Financieras beca)
        {
            return logicaBecas.Actualizar(beca);
        }

        [WebMethod]
        public bool Eliminar(int id)
        {
            return logicaBecas.Eliminar(id);
        }


    }
}
