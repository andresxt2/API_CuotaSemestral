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
    
    public partial class Estudiantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiantes()
        {
            this.Becas_Ayudas_Financieras = new List<Becas_Ayudas_Financieras>();
            this.Morosidad = new List<Morosidad>();
            this.Pagos = new List<Pagos>();
        }
    
        public int id_estudiante { get; set; }
        public string ci_estudiante { get; set; }
        public string nombre { get; set; }
        public string correo_electronico { get; set; }
        public string programa_academico { get; set; }
        public string estado_matricula { get; set; }
        public Nullable<bool> borrado_logico { get; set; }
        public Nullable<System.DateTime> fecha_borrado_logico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Becas_Ayudas_Financieras> Becas_Ayudas_Financieras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Morosidad> Morosidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Pagos> Pagos { get; set; }
    }
}