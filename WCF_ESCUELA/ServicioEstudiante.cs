using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstudiante" en el código y en el archivo de configuración a la vez.
    public class ServicioEstudiante : IServicioEstudiante
    {
        public EstudianteDC ConsultarEstudiante(Int32 strCodigo)
        {
            try
            {
                // Instanciamos el modelo
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                TB_ESTUDIANTE objEstudiante = (from miEstudiante in MisMatriculas.TB_ESTUDIANTE
                                               where miEstudiante.DNI_EST == strCodigo
                                               select miEstudiante).FirstOrDefault();

                // Declaramos la instancia de DC a estudiante
                EstudianteDC objEstudianteDC = new EstudianteDC();

                if (objEstudiante == null)
                {
                    objEstudianteDC.DNI_EST = 0;
                }
                else
                {
                    objEstudianteDC.DNI_EST = Convert.ToInt32(objEstudiante.DNI_EST);
                    objEstudianteDC.NOM_EST = objEstudiante.NOM_EST;
                    objEstudianteDC.APE_EST = objEstudiante.APE_EST;
                    objEstudianteDC.SEXO_EST = objEstudiante.SEXO_EST;
                    objEstudianteDC.FEC_NAC_EST = objEstudiante.FEC_NAC_EST;
                    objEstudianteDC.DNI_APO = Convert.ToInt32(objEstudiante.DNI_APO);
                    objEstudianteDC.ID_UBIGEO = Convert.ToInt32(objEstudiante.ID_UBIGEO);
                    objEstudianteDC.EST_EST = Convert.ToInt16(objEstudiante.EST_EST);
                    objEstudianteDC.Estado = Convert.ToString(objEstudiante.EST_EST);
                    if (objEstudianteDC.EST_EST == 1)
                    {
                        objEstudianteDC.Estado = "Activo";
                    }
                    else
                    {
                        objEstudianteDC.Estado = "Inactivo";
                    }
                    objEstudianteDC.Usu_Registro = objEstudiante.Usu_Registro;
                    objEstudianteDC.Fec_Registro = (DateTime)objEstudiante.Fec_Registro;
                    objEstudianteDC.Usu_Ult_Mod = objEstudiante.Usu_Ult_Mod;
                    objEstudianteDC.Fec_Ult_Mod = Convert.ToDateTime(objEstudiante.Fec_Ult_Mod);
                }
                return objEstudianteDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<EstudianteDC> ListarEstudiante()
        {
            try
            {
                // Instanciamos el modelo
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                // Instanciamos lista a retornar
                List<EstudianteDC> objListaEstudianteDC = new List<EstudianteDC>();

                // Lista de estudiantes ordenado por apellido
                var query = (from miEstudiante in MisMatriculas.TB_ESTUDIANTE
                             orderby miEstudiante.APE_EST
                             select miEstudiante).ToList();

                foreach (var objEstudiante in query)
                {
                    EstudianteDC objEstudianteDC = new EstudianteDC();

                    objEstudianteDC.DNI_EST = Convert.ToInt32(objEstudiante.DNI_EST);
                    objEstudianteDC.NOM_EST = objEstudiante.NOM_EST;
                    objEstudianteDC.APE_EST = objEstudiante.APE_EST;
                    objEstudianteDC.ApellNom_EST = objEstudiante.NOM_EST + ", " + objEstudiante.APE_EST;
                    objEstudianteDC.SEXO_EST = objEstudiante.SEXO_EST;
                    objEstudianteDC.FOTO_EST = objEstudiante.FOTO_EST;
                    objEstudianteDC.FEC_NAC_EST = objEstudiante.FEC_NAC_EST;
                    objEstudianteDC.DNI_APO = Convert.ToInt32(objEstudiante.DNI_APO);
                    objEstudianteDC.Nom_Apo = objEstudiante.TB_APODERADO.NOM_APO;
                    objEstudianteDC.Ape_Apo = objEstudiante.TB_APODERADO.APE_APO;
                    objEstudianteDC.Tel_Apo = objEstudiante.TB_APODERADO.TEL_APO;
                    objEstudianteDC.ID_UBIGEO = Convert.ToInt32(objEstudiante.ID_UBIGEO);
                    objEstudianteDC.Departamento = objEstudiante.TB_UBIGEO.DEPARTAMENTO;
                    objEstudianteDC.Provincia = objEstudiante.TB_UBIGEO.PROVINCIA;
                    objEstudianteDC.Distrito = objEstudiante.TB_UBIGEO.DISTRITO;
                    objEstudianteDC.EST_EST = Convert.ToInt16(objEstudiante.EST_EST);
                    //objEstudianteDC.ESTADO_NOMBRE = objEstudiante.EST_EST == 1 ? "Activo" : "Inactivo";
                    objEstudianteDC.Estado = Convert.ToString(objEstudiante.EST_EST);
                    if (objEstudianteDC.EST_EST == 1)
                    {
                        objEstudianteDC.Estado = "Activo";
                    }
                    else
                    {
                        objEstudianteDC.Estado = "Inactivo";
                    }
                    objEstudianteDC.Fec_Registro = (DateTime)objEstudiante.Fec_Registro;
                    objEstudianteDC.Usu_Registro = objEstudiante.Usu_Registro;
                    objEstudianteDC.Fec_Ult_Mod = Convert.ToDateTime(objEstudiante.Fec_Ult_Mod);
                    objEstudianteDC.Usu_Ult_Mod = objEstudiante.Usu_Ult_Mod;

                    // Agregamos la instancia DC a la lista a devolver
                    objListaEstudianteDC.Add(objEstudianteDC);
                }
                return objListaEstudianteDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean InsertarEstudiante(EstudianteDC objEstudianteDC)
        {
            try
            {
                //  Instanciamos el modelo
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();


                // Invocamos el store procedure
                MisMatriculas.usp_InsertarEstudiante
                    (Convert.ToInt32(objEstudianteDC.DNI_EST),
                    objEstudianteDC.NOM_EST, 
                    objEstudianteDC.APE_EST,
                    objEstudianteDC.SEXO_EST, 
                    objEstudianteDC.FOTO_EST,
                    Convert.ToDateTime(objEstudianteDC.FEC_NAC_EST),
                    Convert.ToInt32(objEstudianteDC.DNI_APO),
                    Convert.ToInt32(objEstudianteDC.ID_UBIGEO),
                    Convert.ToInt16(objEstudianteDC.EST_EST),
                    objEstudianteDC.Usu_Registro);

                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);

            }
        }


        public Boolean ActualizarEstudiante(EstudianteDC objEstudianteDC)
        {
            try
            {
                //  Instanciamos el modelo
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                // Invocamos el store procedure
                MisMatriculas.usp_ActualizarEstudiante
                    (Convert.ToString(objEstudianteDC.DNI_EST),
                    objEstudianteDC.NOM_EST, objEstudianteDC.APE_EST,
                    objEstudianteDC.SEXO_EST, objEstudianteDC.FOTO_EST,
                    Convert.ToDateTime(objEstudianteDC.FEC_NAC_EST),
                    Convert.ToInt32(objEstudianteDC.DNI_APO),
                    Convert.ToInt32(objEstudianteDC.ID_UBIGEO),
                    Convert.ToInt16(objEstudianteDC.EST_EST),
                    objEstudianteDC.Usu_Ult_Mod);

                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);

            }
        }


        public Boolean EliminarEstudiante(Int32 strCodigo)
        {
            try
            {
                //  Instanciamos el modelo
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                // Invocamos el store procedure
                MisMatriculas.usp_EliminarEstudiante(strCodigo);

                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);

            }
        }
    }
}
