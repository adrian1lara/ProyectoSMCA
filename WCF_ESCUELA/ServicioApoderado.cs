using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioApoderado" en el código y en el archivo de configuración a la vez.
    public class ServicioApoderado : IServicioApoderado
    {
        public List<ApoderadoDC> ListarApoderado()
        {
            try
            {
                // Instanciamos el modelo
                SistemaDeMatriculaCAEntities MisMatriculas = new SistemaDeMatriculaCAEntities();

                // Instanciamos lista a retornar
                List<ApoderadoDC> objListaApoderadoDC = new List<ApoderadoDC>();

                var query = (from miApoderado in MisMatriculas.TB_APODERADO
                             orderby miApoderado.APE_APO
                             select miApoderado).ToList();

                foreach (var objApoderado in query)
                {
                    ApoderadoDC objApoderadoDC = new ApoderadoDC();

                    objApoderadoDC.DNI_APO = Convert.ToInt32(objApoderado.DNI_APO);
                    objApoderadoDC.NOM_APO = objApoderado.NOM_APO;
                    objApoderadoDC.APE_APO = objApoderado.APE_APO;
                    objApoderadoDC.ApellNom_APO = objApoderado.NOM_APO + ", " + objApoderado.APE_APO;
                    objApoderadoDC.SEXO_APO = objApoderado.SEXO_APO;
                    objApoderadoDC.ID_UBIGEO = Convert.ToInt32(objApoderado.ID_UBIGEO);
                    objApoderadoDC.FOTO_APO = objApoderado.FOTO_APO;
                    objApoderadoDC.TEL_APO = objApoderado.TEL_APO;
                    objApoderadoDC.CORREO_APO = objApoderado.CORREO_APO;                    
                    objApoderadoDC.Departamento = objApoderado.TB_UBIGEO.DEPARTAMENTO;
                    objApoderadoDC.Provincia = objApoderado.TB_UBIGEO.PROVINCIA;
                    objApoderadoDC.Distrito = objApoderado.TB_UBIGEO.DISTRITO;
                    objApoderadoDC.Estado = Convert.ToInt16(objApoderado.Estado);
                    objApoderadoDC.Fec_Registro = (DateTime)objApoderado.Fec_Registro;
                    objApoderadoDC.Usu_Registro = objApoderado.Usu_Registro;
                    objApoderadoDC.Fec_Ult_Mod = Convert.ToDateTime(objApoderado.Fec_Ult_Mod);
                    objApoderadoDC.Usu_Ult_Mod = objApoderado.Usu_Ult_Mod;

                    // Agregamos la instancia DC a la lista a devolver
                    objListaApoderadoDC.Add(objApoderadoDC);
                }
                return objListaApoderadoDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
