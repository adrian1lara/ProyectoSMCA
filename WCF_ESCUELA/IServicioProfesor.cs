using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProfesor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProfesor
    {
        [OperationContract]
        ProfesorDC ConsultarProfesor(String strCodigo);
        [OperationContract]
        List<ProfesorDC> ListarProfesor();
        [OperationContract]
        Boolean InsertarProfesor(ProfesorDC objProfesorDC);
        [OperationContract]
        Boolean ActualizarProfesor(ProfesorDC objProfesorDC);
        [OperationContract]
        Boolean EliminarProfesor(String strCodigo);
        [OperationContract]
        Boolean ExisteProfesor(String dni);
    }

    [DataContract]
    [Serializable]
    public class ProfesorDC
    {
        [DataMember]
        public String COD_PROF { get; set; }
        [DataMember]
        public String NOM_PROF { get; set; }
        [DataMember]
        public String APE_PROF { get; set; }
        [DataMember]
        public String ApeNom_Prof
        { get { return APE_PROF + ", " + NOM_PROF; } set { } }
        [DataMember]
        public String SEXO_PROF { get; set; }
        [DataMember]
        public byte[] FOTO_PROF { get; set; }
        [DataMember]
        public String DNI_PROF { get; set; }
        [DataMember]
        public Int32 ID_UBIGEO { get; set; }
        [DataMember]
        public String DEPARTAMENTO { get; set; }
        [DataMember]
        public String PROVINCIA { get; set; }
        [DataMember]
        public String DISTRITO { get; set; }
        [DataMember]
        public String CORREO_PROF { get; set; }
        [DataMember]
        public String ESPECIALIDAD { get; set; }
        [DataMember]
        public String TELF_PROF { get; set; }
        [DataMember]
        public Int16 ESTADO_PROF { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }
    }

}
