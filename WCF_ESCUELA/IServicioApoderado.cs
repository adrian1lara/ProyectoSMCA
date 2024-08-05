using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioApoderado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioApoderado
    {
        [OperationContract]
        List<ApoderadoDC> ListarApoderado();
    }

    [DataContract]
    [Serializable]

    public class ApoderadoDC
    {
        [DataMember]
        public Int32 DNI_APO { get; set; }
        [DataMember]
        public String NOM_APO { get; set; }
        [DataMember]
        public String APE_APO { get; set; }
        [DataMember]
        public String ApellNom_APO
        { get { return APE_APO + ", " + NOM_APO; } set { } }
        [DataMember]
        public String SEXO_APO { get; set; }
        [DataMember]
        public Int32 ID_UBIGEO { get; set; }
        [DataMember]
        public byte[] FOTO_APO { get; set; }
        [DataMember]
        public String TEL_APO { get; set; }
        [DataMember]
        public String CORREO_APO { get; set; }

        [DataMember]
        public String Departamento { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public Int16 Estado { get; set; }
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
