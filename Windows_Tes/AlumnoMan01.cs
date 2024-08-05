using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_SistemaMatricula
{
    public partial class AlumnoMan01 : Form
    {
        ProxyEstudiante.ServicioEstudianteClient objServicioEstudiante = new ProxyEstudiante.ServicioEstudianteClient();


        public AlumnoMan01()
        {
            InitializeComponent();
        }
        // private void btnConsultar_Click(object sender, EventArgs e)

        private void AlumnoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgResultados.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void CargarDatos(String strFiltro)
        {
            /*
            dtgResultados.DataSource = objServicioEstudiante.ListarEstudiante();
            lblRegistros.Text = dtgResultados.Rows.Count.ToString();
            */

            var estudiantes = objServicioEstudiante.ListarEstudiante();

            // Aplicamos el filtro si se ha proporcionado uno
            if (!string.IsNullOrWhiteSpace(strFiltro))
            {
                estudiantes = estudiantes.Where(e => e.APE_EST.Contains(strFiltro) || e.DNI_EST.ToString().Contains(strFiltro)).ToList();
            }
            dtgResultados.DataSource = estudiantes;
            lblRegistros.Text = dtgResultados.Rows.Count.ToString();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoMan02 alumnoMan02 = new AlumnoMan02();
                alumnoMan02.ShowDialog();
                CargarDatos("");
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
                if (dtgResultados.CurrentRow != null)
                {
                    // Obtener el DNI del estudiante seleccionado en el DataGridView
                    string dni = dtgResultados.CurrentRow.Cells["DNI_EST"].Value.ToString();

                    // Asegurarse de que el DNI sea un entero válido
                    if (int.TryParse(dni, out int dniEstudiante))
                    {
                        AlumnoMan03 alumnoMan03 = new AlumnoMan03
                        {
                            StrCodigo = dniEstudiante
                        };
                        alumnoMan03.ShowDialog();
                        CargarDatos("");
                    }
                    else
                    {
                        MessageBox.Show("El DNI seleccionado no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 strCodigo = Convert.ToInt32(dtgResultados.CurrentRow.Cells[0].Value);
                if (objServicioEstudiante.EliminarEstudiante(strCodigo) == true)
                {
                    CargarDatos("");
                }
                else
                {
                    throw new Exception("No se eliminó el registro, contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

    }
}

