//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public int id_pago { get; set; }
        public string cod_pago { get; set; }
        public string id_estudiante { get; set; }
        public System.DateTime fecha_pago { get; set; }
        public decimal saldo { get; set; }
        public string semestre { get; set; }
        public string estado { get; set; }
        public Nullable<bool> borrado_logico { get; set; }
        public Nullable<System.DateTime> fecha_borrado_logico { get; set; }
    
        public virtual Estudiantes Estudiantes { get; set; }
    }
}
