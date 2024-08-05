using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioConsultas" in both code and config file together.
    public class ServicioConsultas : IServicioConsultas
    {
        // Obtener todas las secciones en la que enseña un profesor
        public List<SeccionDC> ConsultarSeccionesPorProfesorId(string strCodigo)
        {

            // Instanciamos el modelo
            SistemaDeMatriculaCAEntities objSMCA = new SistemaDeMatriculaCAEntities();

            // Instanciamos la lista a retornar
            List<SeccionDC> objListaSecciones = new List<SeccionDC>();

            // Obtenemos la lista de secciones por profesor
            var query = (
                from misSecciones in objSMCA.TB_SECCION
                where misSecciones.COD_PROFESOR == strCodigo
                select misSecciones).ToList();

            foreach (var objSeccion in query)
            {
                SeccionDC seccionDC = new SeccionDC();
                seccionDC.Cod_Seccion = objSeccion.ID_SECCION;
                seccionDC.Nom_Seccion = objSeccion.NOM_SECC;
                seccionDC.Cod_Grado = objSeccion.ID_GRADO;
                seccionDC.Cod_Profesor = objSeccion.COD_PROFESOR;
                seccionDC.Turno_Profesor = objSeccion.TURNO_PROF;
                seccionDC.Est_Seccion = Convert.ToInt16(objSeccion.Est_Matricula);
                if(objSeccion.Est_Matricula == 1)
                {
                    seccionDC.Estado = "Activo";
                } else
                {
                    seccionDC.Estado = "Inactivo";
                }

                objListaSecciones.Add(seccionDC);
            }



            return objListaSecciones;
        }

        // obtener cantidad de alumnos en una misma seccion por matricula
        public Int16 ContarAlumnosPorSeccionId(int id)
        {
            // Instanciamos el modelo
            SistemaDeMatriculaCAEntities objSMCA = new SistemaDeMatriculaCAEntities();

            Int16 cantAlumnos = Convert.ToInt16(
                (
                    from misMatriculas in objSMCA.TB_MATRICULA
                    where misMatriculas.ID_SECCION == id
                    select misMatriculas
                ).Count());

            return cantAlumnos;
        }

        public MatriculaDC ConsultarMatriculaPorAlumnoDNI(int dni)
        {
            try
            {
                SistemaDeMatriculaCAEntities objSMCA = new SistemaDeMatriculaCAEntities();

                MatriculaDC matriculaDC = new MatriculaDC();

                TB_MATRICULA objMatricula = (
                        from miMatricula in objSMCA.TB_MATRICULA
                        where miMatricula.DNI_EST == dni
                        select miMatricula
                    ).FirstOrDefault();

                if (objMatricula == null)
                {
                    matriculaDC.DNI_EST = 0;
                }
                else
                {
                    matriculaDC.COD_MATRICULA = objMatricula.COD_MATRICULA;
                    matriculaDC.DNI_EST =   Convert.ToInt32(objMatricula.DNI_EST);
                    matriculaDC.ID_SECCION = Convert.ToInt16(objMatricula.ID_SECCION);
                    matriculaDC.ESTADO_MATRI = Convert.ToInt16(objMatricula.ESTADO_MATRI);
                    if(objMatricula.ESTADO_MATRI == 1)
                    {
                        matriculaDC.Estado = "Activo";
                    } else
                    {
                        matriculaDC.Estado = "Inactivo";
                    }

                }

                return matriculaDC;

            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<MatriculaDC> ConsultarMatriculadosPorFechas(DateTime Fec_ini, DateTime Fec_Fin)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                List<MatriculaDC> objListaMatriculados = new List<MatriculaDC>();

                var query = (from miMatricula in MiSistema.TB_MATRICULA
                             where miMatricula.Fec_Registro >= Fec_ini && miMatricula.Fec_Registro <= Fec_Fin
                             select miMatricula);

                foreach (var resultado in query)
                {
                    MatriculaDC objMatriculaDC = new MatriculaDC();
                    objMatriculaDC.COD_MATRICULA = resultado.COD_MATRICULA;
                    objMatriculaDC.DNI_EST = Convert.ToInt32(resultado.DNI_EST);
                    objMatriculaDC.ApellNom_ven = resultado.TB_ESTUDIANTE.NOM_EST + ", " + resultado.TB_ESTUDIANTE.APE_EST;
                    objMatriculaDC.Nom_Secc = resultado.TB_SECCION.NOM_SECC;
                    objMatriculaDC.ESTADO_MATRI = Convert.ToInt16(resultado.ESTADO_MATRI);
                    if (resultado.ESTADO_MATRI == 1)
                    {
                        objMatriculaDC.Estado = "Activo";
                    }
                    else
                    {
                        objMatriculaDC.Estado = "Inactivo";
                    }
                    objListaMatriculados.Add(objMatriculaDC);
                }
                return objListaMatriculados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProfesorDC> ConsultarProfesoresPorEspecialidad(String Especialidad)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                List<ProfesorDC> objListaProfesorDC = new List<ProfesorDC>();

                var query = (from miProfesor in MiSistema.TB_PROFESOR
                             where miProfesor.ESPECIALIDAD == Especialidad
                             select miProfesor);

                foreach (var objPROFESOR in query)
                {
                    ProfesorDC objProfesorDC = new ProfesorDC();
                    objProfesorDC.COD_PROF = objPROFESOR.COD_PROF;
                    objProfesorDC.NOM_PROF = objPROFESOR.NOM_PROF;
                    objProfesorDC.APE_PROF = objPROFESOR.APE_PROF;
                    objProfesorDC.ApeNom_Prof = objPROFESOR.APE_PROF + ", " + objPROFESOR.NOM_PROF;
                    objProfesorDC.SEXO_PROF = objPROFESOR.SEXO_PROF;
                    objProfesorDC.FOTO_PROF = objPROFESOR.FOTO_PROF;
                    objProfesorDC.DNI_PROF = objPROFESOR.DNI_PROF;
                    objProfesorDC.DEPARTAMENTO = objPROFESOR.TB_UBIGEO.DEPARTAMENTO;
                    objProfesorDC.PROVINCIA = objPROFESOR.TB_UBIGEO.PROVINCIA;
                    objProfesorDC.DISTRITO = objPROFESOR.TB_UBIGEO.DISTRITO;
                    objProfesorDC.CORREO_PROF = objPROFESOR.CORREO_PROF;
                    objProfesorDC.ESPECIALIDAD = objPROFESOR.ESPECIALIDAD;
                    objProfesorDC.TELF_PROF = objPROFESOR.TELF_PROF;
                    objProfesorDC.Usu_Registro = objPROFESOR.Usu_Registro;
                    objProfesorDC.ESTADO_PROF = Convert.ToInt16(objPROFESOR.ESTADO_PROF);
                    if (objPROFESOR.ESTADO_PROF == 1)
                    {
                        objProfesorDC.Estado = "Activo";
                    }
                    else
                    {
                        objProfesorDC.Estado = "Inactivo";
                    }
                    objListaProfesorDC.Add(objProfesorDC);
                }
                return objListaProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // obtenemos estudiantes por el id de grado
        public List<EstudianteDC> ConsultarEstudiantesPorGradoId(int id)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                List<EstudianteDC> listaEstudianteDC = new List<EstudianteDC>();

                var query = (from miEstudiante in MiSistema.TB_ESTUDIANTE
                             join matricula in MiSistema.TB_MATRICULA on miEstudiante.DNI_EST equals matricula.DNI_EST
                             join seccion in MiSistema.TB_SECCION on matricula.ID_SECCION equals seccion.ID_SECCION
                             join grado in MiSistema.TB_GRADO on seccion.ID_GRADO equals grado.ID_GRADO
                             where grado.ID_GRADO == id
                             select new
                             {
                                 miEstudiante.DNI_EST,
                                 miEstudiante.NOM_EST,
                                 miEstudiante.APE_EST,
                                 Grado_Nom = grado.NOM_GRADO  // Agrega y selecciona el nombre del grado
                             }
                    );

                foreach (var objEstudiante in query)
                {
                    EstudianteDC estudianteDC = new EstudianteDC();
                    estudianteDC.DNI_EST = objEstudiante.DNI_EST;
                    estudianteDC.NOM_EST = objEstudiante.NOM_EST;
                    estudianteDC.APE_EST = objEstudiante.APE_EST;
                    estudianteDC.Grado_Nom = objEstudiante.Grado_Nom;

                    listaEstudianteDC.Add(estudianteDC);
                }

                return listaEstudianteDC;
                
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
