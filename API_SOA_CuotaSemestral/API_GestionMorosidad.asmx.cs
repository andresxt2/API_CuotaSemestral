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
    /// Descripción breve de API_GestionMorosidad
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_GestionMorosidad : System.Web.Services.WebService
    {
        logicaMorosidad logicaMorosidad = new logicaMorosidad();
        [WebMethod]
        public List<Morosidad> Listar()
        {
            return logicaMorosidad.Listar();
        }

        [WebMethod]
        public List<Morosidad> ListarPorEstudiante(string id)
        {
            return logicaMorosidad.ListarPorEstudiante(id);
        }

        [WebMethod]
        public List<Morosidad> ListarPorDiasDeRetraso (int dias)
        {
            return logicaMorosidad.ListarPorDiasRetraso(dias);
        }

        [WebMethod]
        public Morosidad leerPorId(int id)
        {
            return logicaMorosidad.leerPorId(id);
        }

        [WebMethod]
        public void Insertar(Morosidad morosidad)
        {
            logicaMorosidad.Insertar(morosidad);
        }

        [WebMethod]
        public bool Actualizar(Morosidad morosidad)
        {
            return logicaMorosidad.Actualizar(morosidad);
        }

        [WebMethod]
        public bool Eliminar(int id)
        {
            return logicaMorosidad.Eliminar(id);
        }
       
    }
}
