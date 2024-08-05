using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSeccion" en el código y en el archivo de configuración a la vez.
    public class ServicioSeccion : IServicioSeccion
    {
        public List<SeccionnDC> ListarSeccion()
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                List<SeccionnDC> objListaSecciones = new List<SeccionnDC>();

                var query = (from miSistema in MiSistema.TB_SECCION
                             select miSistema
                                        ).ToList();

                foreach (var objSecciones in query)
                {
                    SeccionnDC objSeccionDC = new SeccionnDC();
                    objSeccionDC.ID_SECCION = Convert.ToInt16(objSecciones.ID_SECCION);
                    objSeccionDC.Nom_Secc = objSecciones.NOM_SECC;
                    objSeccionDC.Id_Grado = Convert.ToInt32(objSecciones.TB_GRADO.ID_GRADO);
                    objSeccionDC.Nom_Grado = objSecciones.TB_GRADO.NOM_GRADO;
                    objSeccionDC.GradoYSeccion = objSecciones.TB_GRADO.NOM_GRADO + ", " + objSecciones.NOM_SECC;
                    objSeccionDC.Cod_Prof = objSecciones.TB_PROFESOR.COD_PROF;
                    objSeccionDC.Nom_Prof = objSecciones.TB_PROFESOR.NOM_PROF;
                    objSeccionDC.Ape_Prof = objSecciones.TB_PROFESOR.APE_PROF;
                    objSeccionDC.Turno_prof = objSecciones.TURNO_PROF;
                    objSeccionDC.Especialidad = objSecciones.TB_PROFESOR.ESPECIALIDAD;
                    objSeccionDC.Estado_prof = Convert.ToInt16(objSecciones.TB_PROFESOR.ESTADO_PROF);

                    objListaSecciones.Add(objSeccionDC);
                }
                return objListaSecciones;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
