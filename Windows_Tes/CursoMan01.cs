
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar
using ProxyCurso;


namespace SYSMCA_GUI

{
    public partial class CursoMan01 : Form
    {
       ServicioCursoClient servicioCursoClient = new ServicioCursoClient();
        DataView dtv;

        public CursoMan01()
        {
            InitializeComponent();
        }

        private void CursoMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            try
            {
                var listaCursos = servicioCursoClient.ListarCurso();
                var dataTable = ConvertToDataTable(listaCursos);

                dtv = new DataView(dataTable);
                dtv.RowFilter = "Nom_Curso like '%" + strFiltro + "%'";
                dtgDatos.DataSource = dtv;
                lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private DataTable ConvertToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);

            // Obtener todas las propiedades de la clase T
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CursoMan02 objMan02 = new CursoMan02();
                objMan02.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Agrega la siguiente línea para verificar el valor antes de pasarlo
                MessageBox.Show("Código del curso seleccionado: " + dtgDatos.CurrentRow.Cells[0].Value.ToString());

                CursoMan03 objMan03 = new CursoMan03();
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 strCodigo = Convert.ToInt16(dtgDatos.CurrentRow.Cells[0].Value);
                if (servicioCursoClient.EliminarCurso(strCodigo) == true)
                {
                    CargarDatos(txtFiltro.Text.Trim());
                }
                else
                {
                    throw new Exception("No se elimino el registro, verifique su vincunlo en otra tabla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());

        }
    }
}
