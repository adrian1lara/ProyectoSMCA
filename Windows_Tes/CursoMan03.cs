using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SYSMCA_GUI
{
    public partial class CursoMan03 : Form
    {
        ProxyCurso.ServicioCursoClient objServiceCurso = new ProxyCurso.ServicioCursoClient();
        ProxyGrado.ServicioGradoClient objServiceGrado = new ProxyGrado.ServicioGradoClient();

        ProxyCurso.CursoDC objCursoDC = new ProxyCurso.CursoDC();
        ProxyGrado.GradoDC objGradoDC = new ProxyGrado.GradoDC();

        public CursoMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void CursoMan03_Load(object sender, EventArgs e)
        {

            try
            {
                // Llamada al servicio WCF para obtener los grados
                var listaGrados = objServiceGrado.ListarGrado();
                DataTable dt = ConvertToDataTable(listaGrados);
                DataRow dr = dt.NewRow();
                dr["ID_GRADO"] = 0;
                dr["NOM_GRADO"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboGrado.DataSource = dt;
                cboGrado.ValueMember = "ID_GRADO";
                cboGrado.DisplayMember = "NOM_GRADO";

                // Llamada al servicio WCF para obtener los datos del curso
                objCursoDC = objServiceCurso.ConsultarCurso(Convert.ToInt16(this.Codigo));

                // Mostrar los datos del curso en el formulario
                lblCodigo.Text = objCursoDC.COD_CURSO.ToString();
                txtNomCurso.Text = objCursoDC.Nom_Curso;
                cboGrado.SelectedValue = objCursoDC.ID_GRADO;
                chkActivo.Checked = objCursoDC.Est_Curso == 1;
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
                if (string.IsNullOrWhiteSpace(txtNomCurso.Text))
                {
                    throw new Exception("El nombre del curso es obligatorio");
                }
                if (cboGrado.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar grado");
                }

                bool existeCurso = objServiceCurso.ExisteCurso(objCursoDC.COD_CURSO ,txtNomCurso.Text.Trim());

                if (existeCurso)
                {
                    throw new Exception("Ya existe un Curso con el mismo nombre");
                }

                // Asignar valores actualizados al objeto curso
                objCursoDC.ID_GRADO = Convert.ToInt16(cboGrado.SelectedValue);
                objCursoDC.Nom_Curso = txtNomCurso.Text.Trim();
                objCursoDC.Est_Curso = Convert.ToInt16(chkActivo.Checked);
                objCursoDC.Usu_Ult_Mod = "Usuario"; // Reemplaza con el usuario actual
                objCursoDC.Fec_Ult_Mod = DateTime.Now;

                // Llamada al servicio WCF para actualizar el curso
                if (objServiceCurso.ActualizarCurso(objCursoDC))
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
