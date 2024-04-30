using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
namespace Logica
{
    public class logicaMorosidad
    {
        datosMorosidad DatosMorosidad = new datosMorosidad();

        public List<Morosidad> Listar()
        {
            return DatosMorosidad.Listar();
        }

        public List<Morosidad> ListarPorEstudiante (string id_estudiante)
        {
            return DatosMorosidad.Listar().Where(e => e.id_estudiante == id_estudiante).ToList();
        }

        public List<Morosidad> ListarPorDiasRetraso(int dias)
        {
            return DatosMorosidad.Listar().Where(e => e.dias_retraso == dias).ToList();
        }

        public Morosidad leerPorId(int id)
        {
            return DatosMorosidad.Listar().Where(m => m.id_morosidad == id).FirstOrDefault();
        }

        public void Insertar(Morosidad morosidad)
        {
            DatosMorosidad.Insertar(morosidad);
        }

        public bool Actualizar(Morosidad morosidad)
        {
           return DatosMorosidad.Actualizar(morosidad);
        }

        public bool Eliminar(int id )
        {
            return DatosMorosidad.Eliminar(id);
        }

    }
}
