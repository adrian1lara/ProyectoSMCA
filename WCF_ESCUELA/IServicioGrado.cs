using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioGrado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioGrado
    {
        [OperationContract]
        List<GradoDC> ListarGrado();
    }

    [DataContract]
    [Serializable]
    public class GradoDC
    {
        [DataMember]
        public Int32 ID_GRADO { get; set; }

        [DataMember]
        public String NOM_GRADO { get; set; }
    }

}
