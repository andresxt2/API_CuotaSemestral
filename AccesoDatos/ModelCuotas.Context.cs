﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bddColegiaturasV2 : DbContext
    {
        public bddColegiaturasV2()
            : base("name=bddColegiaturasV2")
        {
            this.Configuration.ProxyCreationEnabled = false; // Añade esta línea para deshabilitar la creación de proxies
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Becas_Ayudas_Financieras> Becas_Ayudas_Financieras { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        public virtual DbSet<Morosidad> Morosidad { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
    }
}