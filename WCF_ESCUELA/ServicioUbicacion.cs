using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbicacion" en el código y en el archivo de configuración a la vez.
    public class ServicioUbicacion : IServicioUbicacion
    {
        public List<UbicacionDC> ListarUbicacion()
        {
            SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

            try
            {
                List<UbicacionDC> objLista = new List<UbicacionDC>();

                var query = from miSistema in MiSistema.TB_UBIGEO
                            orderby miSistema.ID_UBIGEO
                            select miSistema;

                foreach (var objConsulta in query)
                {
                    UbicacionDC objUbicacionDC = new UbicacionDC();

                    objUbicacionDC.Id_Ubigeo = Convert.ToInt32(objConsulta.ID_UBIGEO);
                    objUbicacionDC.Distrito = objConsulta.DISTRITO;

                    objLista.Add(objUbicacionDC);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

