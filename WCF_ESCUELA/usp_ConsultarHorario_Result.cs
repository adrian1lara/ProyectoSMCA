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
    
    public partial class usp_ConsultarHorario_Result
    {
        public int Id_Horario { get; set; }
        public string Dia_Semana { get; set; }
        public System.TimeSpan Hora_Inicio { get; set; }
        public System.TimeSpan Hora_Fin { get; set; }
        public int Cod_Curso { get; set; }
        public int Id_Seccion { get; set; }
    }
}