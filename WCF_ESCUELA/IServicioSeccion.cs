using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSeccion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSeccion
    {
        [OperationContract]
        List<SeccionnDC> ListarSeccion();
    }

    [DataContract]
    [Serializable]
    public class SeccionnDC
    {
        [DataMember]
        public Int16 ID_SECCION { get; set; }
        [DataMember]
        public String Nom_Secc { get; set; }
        [DataMember]
        public Int32 Id_Grado { get; set; }
        [DataMember]
        public String Nom_Grado { get; set; }
        [DataMember]
        public String Cod_Prof { get; set; }
        [DataMember]
        public String Ape_Prof { get; set; }
        [DataMember]
        public String Nom_Prof { get; set; }
        [DataMember]
        public String Turno_prof { get; set; }
        [DataMember]
        public String Especialidad { get; set; }
        [DataMember]
        public Int16 Estado_prof { get; set; }
        [DataMember]
        public String GradoYSeccion
        { get { return Nom_Grado + ", " + Nom_Secc; } set { } }
    }
}
