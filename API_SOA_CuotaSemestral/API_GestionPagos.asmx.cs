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
    /// Descripción breve de API_GestionPagos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_GestionPagos : System.Web.Services.WebService
    {
        logicaPagos logicaPagos = new logicaPagos();

        [WebMethod]
        public List<Pagos> Listar()
        {
            return logicaPagos.Listar();
        }

        [WebMethod]
        public List<Pagos> ListarPorEstudiante(string id)
        {
            return logicaPagos.ListarPorEstudiante(id);
        }

        [WebMethod]
        public List<Pagos> ListarPorEstado(string tipo)
        {
            return logicaPagos.ListarPorEstado(tipo);
        }

        [WebMethod]
        public Pagos leerPorId(int id)
        {
            return logicaPagos.leerPorId(id);
        }

        [WebMethod]
        public void Insertar(Pagos pago)
        {
            logicaPagos.Insertar(pago);
        }

        [WebMethod]
        public bool Actualizar(Pagos pago)
        {
            return logicaPagos.Actualizar(pago);
        }

        [WebMethod]
        public bool ActualizarEstado(string cod_pago)
        {
            return logicaPagos.ActualizarEstado(cod_pago);
        }

        [WebMethod]
        public bool Eliminar(int id)
        {
            return logicaPagos.Eliminar(id);
        }

    }
}
