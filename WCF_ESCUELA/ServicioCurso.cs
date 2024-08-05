using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ESCUELA
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCurso" en el código y en el archivo de configuración a la vez.
    public class ServicioCurso : IServicioCurso
    {
        public CursoDC ConsultarCurso(Int16 Codigo)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                CursoDC objCursoDC = new CursoDC();

                var objConsulta = (from miCurso in MiSistema.TB_CURSO
                                   join miGrado in MiSistema.TB_GRADO
                                   on miCurso.ID_GRADO equals miGrado.ID_GRADO
                                   where miCurso.COD_CURSO == Codigo
                                   select new { miCurso, miGrado }).FirstOrDefault();

                if (objConsulta == null)
                {
                    objCursoDC.COD_CURSO = 0;
                }
                else
                {
                    objCursoDC.COD_CURSO = Convert.ToInt16(objConsulta.miCurso.COD_CURSO);
                    objCursoDC.ID_GRADO = Convert.ToInt16(objConsulta.miCurso.ID_GRADO);
                    objCursoDC.Nom_Curso = objConsulta.miCurso.Nom_Curso;
                    objCursoDC.Fec_Registro = Convert.ToDateTime(objConsulta.miCurso.Fec_Registro);
                    objCursoDC.Usu_Registro = objConsulta.miCurso.Usu_Registro;
                    objCursoDC.Fec_Ult_Mod = Convert.ToDateTime(objConsulta.miCurso.Fec_Ult_Mod);
                    objCursoDC.Usu_Ult_Mod = objConsulta.miCurso.Usu_Ult_Mod;
                    objCursoDC.Est_Curso = Convert.ToInt16(objConsulta.miCurso.Est_Curso);
                    objCursoDC.Nom_Grado = objConsulta.miGrado.NOM_GRADO; // Poblar Nom_Grado

                    objCursoDC.Estado = objCursoDC.Est_Curso == 1 ? "Activo" : "Inactivo";
                }
                return objCursoDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<CursoDC> ListarCurso()
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                List<CursoDC> objListaCursoDC = new List<CursoDC>();

                var query = (from miCurso in MiSistema.TB_CURSO
                             join miGrado in MiSistema.TB_GRADO
                             on miCurso.ID_GRADO equals miGrado.ID_GRADO
                             orderby miCurso.COD_CURSO
                             select new { miCurso, miGrado }).ToList();

                foreach (var obj in query)
                {
                    CursoDC objCursoDC = new CursoDC
                    {
                        COD_CURSO = Convert.ToInt16(obj.miCurso.COD_CURSO),
                        ID_GRADO = Convert.ToInt16(obj.miCurso.ID_GRADO),
                        Nom_Curso = obj.miCurso.Nom_Curso,
                        Fec_Registro = Convert.ToDateTime(obj.miCurso.Fec_Registro),
                        Usu_Registro = obj.miCurso.Usu_Registro,
                        Fec_Ult_Mod = Convert.ToDateTime(obj.miCurso.Fec_Ult_Mod),
                        Usu_Ult_Mod = obj.miCurso.Usu_Ult_Mod,
                        Est_Curso = Convert.ToInt16(obj.miCurso.Est_Curso),
                        Nom_Grado = obj.miGrado.NOM_GRADO, // Poblar Nom_Grado
                        Estado = obj.miCurso.Est_Curso == 1 ? "Activo" : "Inactivo"
                    };
                    objListaCursoDC.Add(objCursoDC);
                }
                return objListaCursoDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InsertarCurso(CursoDC objCursoDC)
        {
            try
            {
                using (var MiSistema = new SistemaDeMatriculaCAEntities())
                {
                    // Llamar al procedimiento almacenado
                    MiSistema.Database.ExecuteSqlCommand(
                        "usp_InsertarCurso @Id_Grado, @NOM_CURSO, @Usu_Registro, @Usu_Ult_Mod, @Est_Curso",
                        new SqlParameter("@Id_Grado", objCursoDC.ID_GRADO),
                        new SqlParameter("@NOM_CURSO", objCursoDC.Nom_Curso),
                        new SqlParameter("@Usu_Registro", objCursoDC.Usu_Registro),
                        new SqlParameter("@Usu_Ult_Mod", objCursoDC.Usu_Ult_Mod ?? (object)DBNull.Value),
                        new SqlParameter("@Est_Curso", objCursoDC.Est_Curso)
                    );

                    MiSistema.SaveChanges();
                    return true;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean ActualizarCurso(CursoDC objCursoDC)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                MiSistema.usp_ActualizarCurso
                    (
                        objCursoDC.COD_CURSO,
                        objCursoDC.ID_GRADO,
                        objCursoDC.Nom_Curso,
                        objCursoDC.Usu_Ult_Mod,
                        objCursoDC.Est_Curso
                    );
                MiSistema.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarCurso(Int16 Codigo)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                MiSistema.usp_EliminarCurso(Codigo);
                MiSistema.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ExisteCurso(Int16 codCurso, string nombreCurso)
        {
            try
            {
                SistemaDeMatriculaCAEntities MiSistema = new SistemaDeMatriculaCAEntities();

                var cursoExistente = MiSistema.TB_CURSO
                    .Any(p => p.COD_CURSO != codCurso && p.Nom_Curso == nombreCurso);

                return cursoExistente;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
