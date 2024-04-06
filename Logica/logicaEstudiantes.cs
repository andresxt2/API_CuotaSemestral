﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Cache;
using Datos;
namespace Logica
{
    public class logicaEstudiantes
    {
        cacheGeneral<Estudiantes, datosEstudiantes> cacheEstudiantes = new cacheGeneral<Estudiantes, datosEstudiantes>();

        public List<Estudiantes> Listar()
        {
            // Serializar y deserializar
            List<Estudiantes> estudiantes = cacheEstudiantes.ObtenerTodos();
            return estudiantes;
        }

        //listar por id
        public Estudiantes leerPorId(int id)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.id_estudiante == id).FirstOrDefault();
        }

        //listar por cedula
        public Estudiantes ListarPorCedula(string cedula)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.ci_estudiante == cedula).FirstOrDefault();
        }

        //Listar por programa academico
        public List<Estudiantes> ListarPorPrograma(string programa)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.programa_academico == programa).ToList();
        }

        public List<Estudiantes> ListarPorEstadoMatricula(string estado)
        {
            return cacheEstudiantes.ObtenerTodos().Where(e => e.estado_matricula == estado).ToList();
        }


        public void Insertar(Estudiantes estudiante)
        {
            cacheEstudiantes.Insertar(estudiante);
        }

        public bool Actualizar(Estudiantes estudiante)
        {
            return cacheEstudiantes.Actualizar(estudiante);
        }

        public bool Eliminar(int id)
        {
            return cacheEstudiantes.Eliminar(id);
        }  
    }
}
