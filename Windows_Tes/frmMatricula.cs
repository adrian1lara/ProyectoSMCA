namespace AplicacionWindows_ESCUELA
{
    public partial class frmMatricula : Form
    {
        ProxyMatricula.ServicioMatriculaClient objServiceMatricula = new ProxyMatricula.ServicioMatriculaClient();
        public frmMatricula()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgMatricula.DataSource = objServiceMatricula.ListarMatricula();
            lblRegistros.Text = dtgMatricula.Rows.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            try
            {
                dtgMatricula.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmInsertar objInsertar = new frmInsertar();
                objInsertar.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmActualizar objActualizar = new frmActualizar();

                String strCodigo = dtgMatricula.CurrentRow.Cells[0].Value.ToString();
                objActualizar.Codigo = strCodigo;
                objActualizar.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigo = dtgMatricula.CurrentRow.Cells[0].Value.ToString();
                objServiceMatricula.EliminarMatricula(strCodigo);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoBuscar = txtCodigoBuscar.Text.Trim();

                if (codigoBuscar == "")
                {
                    CargarDatos();
                }
                else
                {
                    var resultado = objServiceMatricula.ConsultarMatricula(codigoBuscar);
                    if (resultado.COD_MATRICULA != String.Empty)
                    {
                        dtgMatricula.DataSource = new List<object> { resultado };

                    }
                    else
                    {
                        MessageBox.Show("Error: Ingrese un codigo valido");
                    }
                }

                lblRegistros.Text = dtgMatricula.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
