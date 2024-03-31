﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Cache
{
    public class cacheGeneral<TEntidad, TDatos> where TDatos : IDatos<TEntidad>, new() where TEntidad : class
    {
        private static List<TEntidad> _cache = new List<TEntidad>();
        private TDatos _datos = new TDatos();


        public List<TEntidad> ObtenerTodos()
        {
            if (!_cache.Any())
            {
                CargarDesdeBD();
            }
            return _cache;
        }

        public void Insertar(TEntidad entidad)
        {
            _datos.Insertar(entidad);
            CargarDesdeBD();
        }

        public void Actualizar(TEntidad entidad)
        {
            _datos.Actualizar(entidad);
            CargarDesdeBD();
        }

        public bool Eliminar(TEntidad entidad)
        {
            bool resultado = _datos.Eliminar(entidad);
            CargarDesdeBD();
            return resultado;
        }

        private void CargarDesdeBD()
        {
            var accesoDatos = new TDatos();
            _cache = accesoDatos.Listar();
        }
    }
}
