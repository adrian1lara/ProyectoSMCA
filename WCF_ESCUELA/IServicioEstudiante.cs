using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEstudiante" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEstudiante
    {
        [OperationContract]
        EstudianteDC ConsultarEstudiante(Int32 strCodigo);

        [OperationContract]
        List<EstudianteDC> ListarEstudiante();

        [OperationContract]
        Boolean InsertarEstudiante(EstudianteDC objEstudianteDC);

        [OperationContract]
        Boolean ActualizarEstudiante(EstudianteDC objEstudianteDC);

        [OperationContract]
        Boolean EliminarEstudiante(Int32 strCodigo);
    }


    [DataContract]
    [Serializable]

    public class EstudianteDC
    {
        [DataMember]
        public Int32 DNI_EST { get; set; }
        [DataMember]
        public String NOM_EST { get; set; }
        [DataMember]
        public String APE_EST { get; set; }
        [DataMember]
        public String ApellNom_EST
        { get { return APE_EST + ", " + NOM_EST; } set { } }
        [DataMember]
        public String SEXO_EST { get; set; }
        [DataMember]
        public byte[] FOTO_EST { get; set; }
        [DataMember]
        public DateTime FEC_NAC_EST { get; set; }
        [DataMember]
        public Int32 DNI_APO { get; set; }
        [DataMember]
        public String Nom_Apo { get; set; }
        [DataMember]
        public String Ape_Apo { get; set; }
        [DataMember]
        public String Tel_Apo { get; set; }
        [DataMember]
        public Int32 ID_UBIGEO { get; set; }
        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public Int16 EST_EST { get; set; }
        [DataMember]
        //public String ESTADO_NOMBRE { get; set; }
        public String Estado { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        //Agregue nombre de grado del estudiante
        [DataMember]
        public String Grado_Nom { get; set; }
    }
}
