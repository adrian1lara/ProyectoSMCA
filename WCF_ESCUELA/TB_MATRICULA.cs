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
    
    public partial class TB_MATRICULA
    {
        public string COD_MATRICULA { get; set; }
        public int DNI_EST { get; set; }
        public int ID_SECCION { get; set; }
        public int ESTADO_MATRI { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
    
        public virtual TB_ESTUDIANTE TB_ESTUDIANTE { get; set; }
        public virtual TB_SECCION TB_SECCION { get; set; }
    }
}