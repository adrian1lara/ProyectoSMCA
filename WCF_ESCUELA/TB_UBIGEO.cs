//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_ESCUELA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_UBIGEO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_UBIGEO()
        {
            this.TB_APODERADO = new HashSet<TB_APODERADO>();
            this.TB_ESTUDIANTE = new HashSet<TB_ESTUDIANTE>();
            this.TB_PROFESOR = new HashSet<TB_PROFESOR>();
        }
    
        public int ID_UBIGEO { get; set; }
        public string ID_DEPA { get; set; }
        public string ID_PROV { get; set; }
        public string ID_DIST { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string PROVINCIA { get; set; }
        public string DISTRITO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_APODERADO> TB_APODERADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ESTUDIANTE> TB_ESTUDIANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PROFESOR> TB_PROFESOR { get; set; }
    }
}