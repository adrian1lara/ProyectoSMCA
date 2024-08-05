using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows_ESCUELA
{
    public partial class frmInsertar : Form
    {
        ProxyMatricula.ServicioMatriculaClient objServiceMatricula = new ProxyMatricula.ServicioMatriculaClient();
        ProxyMatricula.MatriculaDC objMatriculaDC = new ProxyMatricula.MatriculaDC();
        ProxyEstudiante.ServicioEstudianteClient objServiceEstudiante = new ProxyEstudiante.ServicioEstudianteClient();
        ProxyEstudiante.EstudianteDC objEstudianteDC = new ProxyEstudiante.EstudianteDC(); 
        ProxySeccion.ServicioSeccionClient objServiceSeccion = new ProxySeccion.ServicioSeccionClient();

        public frmInsertar()
        {
            InitializeComponent();
        }

        private void frmInsertar_Load(object sender, EventArgs e)
        {
            try
            {
                cboSeccion.DataSource = objServiceSeccion.ListarSeccion();
                cboSeccion.ValueMember = "Id_Seccion";
                cboSeccion.DisplayMember = "GradoYSeccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskDNI.Text.Length == 0)
                {
                    throw new Exception("Debe ingresar un DNI");
                }

                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }


                int resultado = Convert.ToInt32(mskDNI.Text.Trim());

                int resutado2 = objServiceMatricula.ConsultarPorDni(resultado);

                objEstudianteDC = objServiceEstudiante.ConsultarEstudiante(resultado);

                int dniBuscado = objEstudianteDC.DNI_EST;


                if (resutado2 != 2)
                {
                    if(dniBuscado != 0)
                    {
                        objMatriculaDC.DNI_EST = Convert.ToInt32(mskDNI.Text.Trim());
                        objMatriculaDC.ID_SECCION = Convert.ToInt16(cboSeccion.SelectedValue.ToString());
                        objMatriculaDC.Usu_Registro = "vcruces";
                        if (chkEstado.Checked)
                        {
                            objMatriculaDC.ESTADO_MATRI = 1;
                        }
                        else
                        {
                            objMatriculaDC.ESTADO_MATRI = 0;
                        }

                        if (objServiceMatricula.InsertarMatricula(objMatriculaDC) == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("No se inserto el registro, contacte con TI");
                        }
                    }
                    else
                    {
                        throw new Exception("No existe ese DNI registrado");
                    }
                }
                else
                {
                    throw new Exception("Evite introducir un DNI registrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSeccion_Click(object sender, EventArgs e)
        {

        }

        private void cboMatricula_Enter(object sender, EventArgs e)
        {

        }
    }
}
