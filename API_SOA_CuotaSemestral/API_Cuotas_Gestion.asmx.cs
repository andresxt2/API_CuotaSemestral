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
    /// Descripción breve de API_Cuotas_Gestion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_Cuotas_Gestion : System.Web.Services.WebService
    {
        logicaEstudiantes logica = new logicaEstudiantes();
        [WebMethod]
        public List<Estudiantes> Listar()
        {
            return logica.Listar();
        }

        [WebMethod]
        public List<Estudiantes> ListarPorPrograma(string programa)
        {
            return logica.ListarPorPrograma(programa);
        }

        [WebMethod]
        public List<Estudiantes> ListarPorEstadoMatricula(string estado)
        {
            return logica.ListarPorEstadoMatricula(estado);
        }

        [WebMethod]
        public Estudiantes leer(string ci)
        {
            return logica.leer(ci);
        }

        [WebMethod]
        public void Insertar(Estudiantes estudiante)
        {
            logica.Insertar(estudiante);
        }

        [WebMethod]
        public void Actualizar(Estudiantes estudiante)
        {
            logica.Actualizar(estudiante);
        }

        [WebMethod]
        public bool Eliminar(Estudiantes estudiante)
        {
            return logica.Eliminar(estudiante);
        }
    }
}
