using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos.DTO;
using AccesoDatos;
namespace API_SOA_CuotaSemestral
{
    /// <summary>
    /// Descripción breve de API_MostrarServicioPCA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    //[System.Web.Script.Services.ScriptService] // Línea descomentada para permitir llamadas desde scripts.
    public class API_MostrarServicioPCA : System.Web.Services.WebService
    {
        Servicio servicio = new Servicio("Pago de Colegiaturas", "Servicio para pagar la colegiatura semestral de la universidad Bullworth");
        MostrarPagosPCA mostrarPagosPCA = new MostrarPagosPCA();
        logicaPagos logicaPagos = new logicaPagos();

        [WebMethod]
        public Servicio mostrarServicio()
        {
            return servicio;
        }
        

        [WebMethod]
        
        public List<MostrarPagosPCA> mostrarPagosPCAs(string cedula)
        {
            return logicaPagos.mostrarPagosPCAs(cedula);
        }


        [WebMethod]
        public bool ActualizarEstado(string cod_pago)
        {
            return logicaPagos.ActualizarEstado(cod_pago);
        }



    }
}
