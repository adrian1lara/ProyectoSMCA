using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioMatricula" in both code and config file together.
    [ServiceContract]
    public interface IServicioMatricula
    {
        [OperationContract]
        MatriculaDC ConsultarMatricula(String strCodigo);
        [OperationContract]
        Boolean InsertarMatricula(MatriculaDC objMatriculaDC);
        [OperationContract]
        Boolean ActualizarMatricula(MatriculaDC objMatriculaDC);
        [OperationContract]
        Boolean EliminarMatricula(String strCodigo);
        [OperationContract]
        List<MatriculaDC> ListarMatricula();
        [OperationContract]
        Int16 ConsultarPorDni(int DNI);

    }

    [DataContract]
    [Serializable]

    public class MatriculaDC
    {
        [DataMember]
        public String COD_MATRICULA { get; set; }
        [DataMember]
        public Int32 DNI_EST { get; set; }
        [DataMember]
        public Int16 ID_SECCION { get; set; }
        [DataMember]
        public DateTime FEC_MATRI { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public Int16 ESTADO_MATRI { get; set; }
        [DataMember]
        public String Estado { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }
        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }
        [DataMember]
        public String Nom_Est { get; set; }
        [DataMember]
        public String Ape_Est { get; set; }
        [DataMember]
        public String Nom_Secc { get; set; }
        [DataMember]
        public String ApellNom_ven { get; set; }
    }
}
