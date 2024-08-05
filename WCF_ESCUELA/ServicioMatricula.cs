using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioMatricula" in both code and config file together.
    public class ServicioMatricula : IServicioMatricula
    {
        public MatriculaDC ConsultarMatricula(String strCodigo)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                TB_MATRICULA objMatricula = (from miMatricula in MiSistema.TB_MATRICULA
                                             where miMatricula.COD_MATRICULA == strCodigo
                                             select miMatricula).FirstOrDefault();

                MatriculaDC objMatriculaDC = new MatriculaDC();
                if (objMatricula == null)
                {
                    objMatriculaDC.COD_MATRICULA = String.Empty;
                }
                else
                {
                    objMatriculaDC.COD_MATRICULA = objMatricula.COD_MATRICULA;
                    objMatriculaDC.DNI_EST = Convert.ToInt32(objMatricula.DNI_EST);
                    objMatriculaDC.Nom_Est = objMatricula.TB_ESTUDIANTE.NOM_EST;
                    objMatriculaDC.Ape_Est = objMatricula.TB_ESTUDIANTE.APE_EST;
                    objMatriculaDC.ID_SECCION = Convert.ToInt16(objMatricula.ID_SECCION);
                    objMatriculaDC.Nom_Secc = objMatricula.TB_SECCION.NOM_SECC;
                    objMatriculaDC.ESTADO_MATRI = Convert.ToInt16(objMatricula.ESTADO_MATRI);
                    objMatriculaDC.Estado = Convert.ToString(objMatricula.ESTADO_MATRI);
                    if (objMatricula.ESTADO_MATRI == 1)
                    {
                        objMatriculaDC.Estado = "Activo";
                    }
                    else
                    {
                        objMatriculaDC.Estado = "Inactivo";
                    }
                }
                return objMatriculaDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InsertarMatricula(MatriculaDC objMatriculaDC)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                MiSistema.usp_InsertarMatricula
                    (
                    Convert.ToInt32(objMatriculaDC.DNI_EST),
                    Convert.ToInt16(objMatriculaDC.ID_SECCION),
                    objMatriculaDC.Usu_Registro,
                    Convert.ToInt16(objMatriculaDC.ESTADO_MATRI)
                    );
                MiSistema.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
        public Boolean ActualizarMatricula(MatriculaDC objMatriculaDC)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                MiSistema.usp_ActualizarMatricula
                        (
                        objMatriculaDC.COD_MATRICULA,
                        Convert.ToInt32(objMatriculaDC.DNI_EST),
                        Convert.ToInt16(objMatriculaDC.ID_SECCION),
                        Convert.ToInt16(objMatriculaDC.ESTADO_MATRI),
                        objMatriculaDC.Usu_Ult_Mod
                        );
                MiSistema.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean EliminarMatricula(String strCodigo)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                MiSistema.usp_EliminarMatricula(strCodigo);

                MiSistema.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
        public List<MatriculaDC> ListarMatricula()
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                List<MatriculaDC> objListaMatricula = new List<MatriculaDC>();

                var query = (from miSistema in MiSistema.TB_MATRICULA
                             select miSistema
                            ).ToList();

                foreach (var objMatriculados in query)
                {
                    MatriculaDC objVendedorDC = new MatriculaDC();
                    objVendedorDC.COD_MATRICULA = objMatriculados.COD_MATRICULA;
                    objVendedorDC.DNI_EST = Convert.ToInt32(objMatriculados.DNI_EST);
                    objVendedorDC.Nom_Est = objMatriculados.TB_ESTUDIANTE.NOM_EST;
                    objVendedorDC.Ape_Est = objMatriculados.TB_ESTUDIANTE.APE_EST;
                    objVendedorDC.Nom_Secc = objMatriculados.TB_SECCION.NOM_SECC;
                    objVendedorDC.ESTADO_MATRI = Convert.ToInt16(objMatriculados.ESTADO_MATRI);
                    objVendedorDC.Estado = Convert.ToString(objMatriculados.ESTADO_MATRI);
                    if (objVendedorDC.ESTADO_MATRI == 1)
                    {
                        objVendedorDC.Estado = "Activo";
                    }
                    else
                    {
                        objVendedorDC.Estado = "Inactivo";
                    }
                    objListaMatricula.Add(objVendedorDC);
                }
                return objListaMatricula;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Int16 ConsultarPorDni(Int32 DNI)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                Int16 resultado = Convert.ToInt16((from miMatricula in MiSistema.TB_MATRICULA
                                             where miMatricula.DNI_EST == DNI
                                             select miMatricula).Count());

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
