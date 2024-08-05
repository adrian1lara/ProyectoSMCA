using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioConsultas" in both code and config file together.
    [ServiceContract]
    public interface IServicioConsultas
    {
        [OperationContract]
        List<SeccionDC> ConsultarSeccionesPorProfesorId(string strCodigo);

        [OperationContract]
        Int16 ContarAlumnosPorSeccionId(int id);

        [OperationContract]
        MatriculaDC ConsultarMatriculaPorAlumnoDNI(int dni);

        [OperationContract]
        List<MatriculaDC> ConsultarMatriculadosPorFechas(DateTime Fec_ini, DateTime Fec_Fin);

        [OperationContract]
        List<ProfesorDC> ConsultarProfesoresPorEspecialidad(String Especialidad);

        [OperationContract]
        List<EstudianteDC> ConsultarEstudiantesPorGradoId(int id);
    }

    [DataContract]
    [Serializable]
    public class SeccionDC
    {
        [DataMember]
        public int Cod_Seccion;

        [DataMember]
        public string Nom_Seccion;

        [DataMember]
        public int Cod_Grado;

        [DataMember]
        public string Cod_Profesor;

        [DataMember]
        public string Turno_Profesor;

        [DataMember]
        public int Est_Seccion;

        [DataMember]
        public string Estado;
    }

}
