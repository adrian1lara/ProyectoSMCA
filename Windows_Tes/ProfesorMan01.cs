using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_Matriculas
{
    public partial class ProfesorMan01 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        DataView dtv;
        public ProfesorMan01()
        {
            InitializeComponent();
        }

        private void ProfesorMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(string strFiltro)
        {
            try
            {
                var listaProfesores = objServiceProfesor.ListarProfesor();
                var dataTable = ConvertToDataTable(listaProfesores);

                dtv = new DataView(dataTable);
                dtv.RowFilter = "NOM_PROF LIKE '%" + strFiltro + "%'";

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
                ProfesorMan02 objPro02 = new ProfesorMan02();
                objPro02.ShowDialog();
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Código del profesor seleccionado: " + dtgDatos.CurrentRow.Cells[0].Value.ToString());

                ProfesorMan03 objPro03 = new ProfesorMan03();

                objPro03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objPro03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                if (objServiceProfesor.EliminarProfesor(strCodigo) == true)
                {
                    CargarDatos(txtFiltro.Text.Trim());
                }
                else
                {
                    throw new Exception("No se eliminó el registro, verifíque su vínculo en otra tabla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
