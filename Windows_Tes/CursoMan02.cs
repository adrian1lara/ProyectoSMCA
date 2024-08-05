using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSMCA_GUI
{
    public partial class CursoMan02 : Form
    {
        ProxyCurso.ServicioCursoClient objServiceCurso = new ProxyCurso.ServicioCursoClient();
        ProxyGrado.ServicioGradoClient objServiceGrado = new ProxyGrado.ServicioGradoClient();
        
        ProxyCurso.CursoDC objCursoDC = new ProxyCurso.CursoDC();
        ProxyGrado.GradoDC objGradoDC = new ProxyGrado.GradoDC();

        public CursoMan02()
        {
            InitializeComponent();
        }

        private void CursoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                var listaGrados = objServiceGrado.ListarGrado();
                DataTable dt = ConvertToDataTable(listaGrados);
                DataRow dr = dt.NewRow();
                dr["ID_GRADO"] = 0;
                dr["NOM_GRADO"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboGrado.DataSource = dt;
                cboGrado.ValueMember = "ID_GRADO";
                cboGrado.DisplayMember = "NOM_GRADO";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomCurso.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del curso es obligatorio");
                }
                if (cboGrado.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar grado");
                }

                bool existeCurso = objServiceCurso.ExisteCurso(objCursoDC.COD_CURSO, txtNomCurso.Text.Trim());

                if (existeCurso)
                {
                    throw new Exception("Ya existe un Curso con el mismo nombre");
                }

                objCursoDC.Nom_Curso = txtNomCurso.Text.Trim();
                objCursoDC.Est_Curso = Convert.ToInt16(chkActivo.Checked ? 1 : 0);
                objCursoDC.Usu_Registro = "vcruces"; // Reemplaza con el usuario actual
                objCursoDC.ID_GRADO = Convert.ToInt16(cboGrado.SelectedValue);
                objCursoDC.Fec_Registro = DateTime.Now;

                if (objServiceCurso.InsertarCurso(objCursoDC))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error en el proceso, contacte con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable ConvertToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);

            var props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

    }
}
