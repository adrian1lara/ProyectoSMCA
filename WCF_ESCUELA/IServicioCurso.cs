using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCurso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCurso
    {
        [OperationContract]
        CursoDC ConsultarCurso(Int16 Codigo);
        [OperationContract]
        List<CursoDC> ListarCurso();
        [OperationContract]
        Boolean InsertarCurso(CursoDC objCursoDC);
        [OperationContract]
        Boolean ActualizarCurso(CursoDC objCursoDC);
        [OperationContract]
        Boolean EliminarCurso(Int16 Codigo);
        [OperationContract]
        Boolean ExisteCurso(Int16 codCurso, String nombreCurso);

    }

    [DataContract]
    [Serializable]
    public class CursoDC
    {

        [DataMember]
        public Int16 COD_CURSO { get; set; }

        [DataMember]
        public Int16 ID_GRADO { get; set; }

        [DataMember]
        public String Nom_Grado { get; set; }

        [DataMember]
        public String Nom_Curso { get; set; }
        [DataMember]
        public DateTime Fec_Registro { get; set; }
        [DataMember]
        public String Usu_Registro { get; set; }
        [DataMember]
        public DateTime? Fec_Ult_Mod { get; set; }
        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public Int16 Est_Curso { get; set; }
        [DataMember]
        public String Estado { get; set; }


    }

}
