using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProfesor" en el código y en el archivo de configuración a la vez.
    public class ServicioProfesor : IServicioProfesor
    {
        public ProfesorDC ConsultarProfesor(String strCodigo)
        {
            try
            {
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();
                //LINQ
                TB_PROFESOR objPROFESOR = ( from miProfesor in MisMatriculas.TB_PROFESOR
                                            where miProfesor.COD_PROF == strCodigo
                                            select miProfesor ).FirstOrDefault();
                ProfesorDC objProfesorDC = new ProfesorDC();

                if (objPROFESOR == null)
                {
                    objProfesorDC.COD_PROF = String.Empty;
                }
                else
                {
                    objProfesorDC.COD_PROF = objPROFESOR.COD_PROF;
                    objProfesorDC.NOM_PROF = objPROFESOR.NOM_PROF;
                    objProfesorDC.APE_PROF = objPROFESOR.APE_PROF;
                    objProfesorDC.SEXO_PROF = objPROFESOR.SEXO_PROF;
                    objProfesorDC.FOTO_PROF = objPROFESOR.FOTO_PROF;
                    objProfesorDC.DNI_PROF = objPROFESOR.DNI_PROF;
                    objProfesorDC.ID_UBIGEO = objPROFESOR.ID_UBIGEO;
                    objProfesorDC.DEPARTAMENTO = objPROFESOR.TB_UBIGEO.DEPARTAMENTO;
                    objProfesorDC.PROVINCIA = objPROFESOR.TB_UBIGEO.PROVINCIA;
                    objProfesorDC.DISTRITO = objPROFESOR.TB_UBIGEO.DISTRITO;
                    objProfesorDC.CORREO_PROF = objPROFESOR.CORREO_PROF;
                    objProfesorDC.ESPECIALIDAD = objPROFESOR.ESPECIALIDAD;
                    objProfesorDC.TELF_PROF = objPROFESOR.TELF_PROF;
                    objProfesorDC.ESTADO_PROF = Convert.ToInt16(objPROFESOR.ESTADO_PROF);
                    objProfesorDC.Usu_Registro = objPROFESOR.Usu_Registro;
                    objProfesorDC.Fec_Registro = Convert.ToDateTime(objPROFESOR.Fec_Registro);
                    objProfesorDC.Usu_Ult_Mod = objPROFESOR.Usu_Ult_Mod;
                    objProfesorDC.Fec_Ult_Mod = Convert.ToDateTime(objPROFESOR.Fec_Ult_Mod);
                }
                return objProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<ProfesorDC> ListarProfesor()
        {
            try
            {
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                List<ProfesorDC> objListaProfesorDC = new List<ProfesorDC>();

                var query = (from miProfesor in MisMatriculas.TB_PROFESOR
                             orderby miProfesor.COD_PROF
                             select miProfesor).ToList();
                foreach(var objPROFESOR in query)
                {
                    ProfesorDC objProfesorDC = new ProfesorDC();
                    objProfesorDC.COD_PROF = objPROFESOR.COD_PROF;
                    objProfesorDC.NOM_PROF = objPROFESOR.NOM_PROF;
                    objProfesorDC.APE_PROF = objPROFESOR.APE_PROF;
                    objProfesorDC.ApeNom_Prof = objPROFESOR.APE_PROF + ", " + objPROFESOR.NOM_PROF;
                    objProfesorDC.SEXO_PROF = objPROFESOR.SEXO_PROF;
                    objProfesorDC.FOTO_PROF = objPROFESOR.FOTO_PROF;
                    objProfesorDC.DNI_PROF = objPROFESOR.DNI_PROF;
                    objProfesorDC.ID_UBIGEO = objPROFESOR.ID_UBIGEO;
                    objProfesorDC.DEPARTAMENTO = objPROFESOR.TB_UBIGEO.DEPARTAMENTO;
                    objProfesorDC.PROVINCIA = objPROFESOR.TB_UBIGEO.PROVINCIA;
                    objProfesorDC.DISTRITO = objPROFESOR.TB_UBIGEO.DISTRITO;
                    objProfesorDC.CORREO_PROF = objPROFESOR.CORREO_PROF;
                    objProfesorDC.ESPECIALIDAD = objPROFESOR.ESPECIALIDAD;
                    objProfesorDC.TELF_PROF = objPROFESOR.TELF_PROF;
                    objProfesorDC.Usu_Registro = objPROFESOR.Usu_Registro;
                    objProfesorDC.ESTADO_PROF = Convert.ToInt16(objPROFESOR.ESTADO_PROF);
                    if(objPROFESOR.ESTADO_PROF == 1)
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
        public Boolean InsertarProfesor(ProfesorDC objProfesorDC)
        {
            try
            {
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                MisMatriculas.usp_InsertarProfesor
                    (
                        objProfesorDC.NOM_PROF, 
                        objProfesorDC.APE_PROF, 
                        objProfesorDC.SEXO_PROF,
                        objProfesorDC.FOTO_PROF, 
                        objProfesorDC.DNI_PROF, 
                        Convert.ToInt32(objProfesorDC.ID_UBIGEO),
                        objProfesorDC.CORREO_PROF, 
                        objProfesorDC.ESPECIALIDAD, 
                        objProfesorDC.TELF_PROF, 
                        Convert.ToInt16(objProfesorDC.ESTADO_PROF), 
                        objProfesorDC.Usu_Registro
                    );
                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean ActualizarProfesor (ProfesorDC objProfesorDC)
        {
            try
            {
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                MisMatriculas.usp_ActualizarProfesor
                    (
                        objProfesorDC.COD_PROF,
                        objProfesorDC.NOM_PROF, 
                        objProfesorDC.APE_PROF, 
                        objProfesorDC.SEXO_PROF,
                        objProfesorDC.FOTO_PROF, 
                        objProfesorDC.DNI_PROF,
                        Convert.ToInt32(objProfesorDC.ID_UBIGEO), 
                        objProfesorDC.CORREO_PROF,
                        objProfesorDC.ESPECIALIDAD, 
                        objProfesorDC.TELF_PROF, 
                        Convert.ToInt16(objProfesorDC.ESTADO_PROF), 
                        objProfesorDC.Usu_Ult_Mod
                    );
                MisMatriculas.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarProfesor (String strCodigo)
        {
            try
            {
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                MisMatriculas.usp_EliminarProfesor(strCodigo);
                MisMatriculas.SaveChanges ();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ExisteProfesor(string dni)
        {
            try
            {
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                var profesorExistente = MisMatriculas.TB_PROFESOR
                    .Any(p => p.DNI_PROF == dni);

                return profesorExistente;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
