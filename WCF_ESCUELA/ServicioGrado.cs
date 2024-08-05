using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioGrado" en el código y en el archivo de configuración a la vez.
    public class ServicioGrado : IServicioGrado
    {
        public List<GradoDC> ListarGrado()
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                var query = MiSistema.Database.SqlQuery<GradoDC>("EXEC usp_ListarGrado").ToList();

                return query;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
