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
        logicaEstudiantes logicaEstudiantes = new logicaEstudiantes();
        logicaBecas logicaBecas = new logicaBecas();

        #region Estudiantes
        [WebMethod]
        public List<Estudiantes> Listar()
        {
            return logicaEstudiantes.Listar();
        }

        [WebMethod]
        public List<Estudiantes> ListarPorPrograma(string programa)
        {
            return logicaEstudiantes.ListarPorPrograma(programa);
        }

        [WebMethod]
        public List<Estudiantes> ListarPorEstadoMatricula(string estado)
        {
            return logicaEstudiantes.ListarPorEstadoMatricula(estado);
        }

        [WebMethod]
        public Estudiantes leerPorId(int id)
        {
            return logicaEstudiantes.leerPorId(id);
        }

        [WebMethod]
        public void Insertar(Estudiantes estudiante)
        {
            logicaEstudiantes.Insertar(estudiante);
        }

        [WebMethod]
        public void Actualizar(Estudiantes estudiante)
        {
            logicaEstudiantes.Actualizar(estudiante);
        }

        [WebMethod]
        public bool Eliminar(int id)
        {
            return logicaEstudiantes.Eliminar(id);
        }
        #endregion



        [WebMethod]
        public List<Becas_Ayudas_Financieras> ListarBecasAyudas()
        {
            return logicaBecas.Listar();
        }


    }
}
