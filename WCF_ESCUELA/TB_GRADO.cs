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
    
    public partial class TB_GRADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_GRADO()
        {
            this.TB_CURSO = new HashSet<TB_CURSO>();
            this.TB_SECCION = new HashSet<TB_SECCION>();
        }
    
        public int ID_GRADO { get; set; }
        public string NOM_GRADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CURSO> TB_CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SECCION> TB_SECCION { get; set; }
    }
}
