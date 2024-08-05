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
    public partial class frmActualizar : Form
    {

        ProxyMatricula.ServicioMatriculaClient objServiceMatricula = new ProxyMatricula.ServicioMatriculaClient();
        ProxyMatricula.MatriculaDC objMatriculaDC = new ProxyMatricula.MatriculaDC();
        ProxyEstudiante.ServicioEstudianteClient objServiceEstudiante = new ProxyEstudiante.ServicioEstudianteClient();
        ProxyEstudiante.EstudianteDC objEstudianteDC = new ProxyEstudiante.EstudianteDC();
        ProxySeccion.ServicioSeccionClient objServiceSeccion = new ProxySeccion.ServicioSeccionClient();

        public frmActualizar()
        {
            InitializeComponent();
        }

        public String Codigo
        {
            get; set;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
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

                int dniActual = objMatriculaDC.DNI_EST;
                int dniActualizar = Convert.ToInt32(mskDNI.Text.Trim());

                objMatriculaDC = objServiceMatricula.ConsultarMatricula(this.Codigo);
                objEstudianteDC = objServiceEstudiante.ConsultarEstudiante(dniActualizar);

                int dniBuscado = objEstudianteDC.DNI_EST;

                int resutado = objServiceMatricula.ConsultarPorDni(dniActualizar);

                if (dniActual == dniActualizar)
                {
                    objMatriculaDC.DNI_EST = Convert.ToInt32(mskDNI.Text.Trim());
                    objMatriculaDC.ID_SECCION = Convert.ToInt16(cboSeccion.SelectedValue.ToString());
                    objMatriculaDC.Usu_Ult_Mod = "vcruces";
                    if (chkEstado.Checked)
                    {
                        objMatriculaDC.ESTADO_MATRI = 1;
                    }
                    else
                    {
                        objMatriculaDC.ESTADO_MATRI = 0;
                    }

                    if (objServiceMatricula.ActualizarMatricula(objMatriculaDC) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("No se Actualizo el registro, contacte con TI");
                    }

                }
                else
                {
                    if (resutado != 2)
                    {
                        if(dniBuscado != 0)
                        {
                            objMatriculaDC.DNI_EST = Convert.ToInt32(mskDNI.Text.Trim());
                            objMatriculaDC.ID_SECCION = Convert.ToInt16(cboSeccion.SelectedValue.ToString());
                            objMatriculaDC.Usu_Ult_Mod = "vcruces";
                            if (chkEstado.Checked)
                            {
                                objMatriculaDC.ESTADO_MATRI = 1;
                            }
                            else
                            {
                                objMatriculaDC.ESTADO_MATRI = 0;
                            }

                            if (objServiceMatricula.ActualizarMatricula(objMatriculaDC) == true)
                            {
                                this.Close();
                            }
                            else
                            {
                                throw new Exception("No se Actualizo el registro, contacte con TI");
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            try
            {
                objMatriculaDC = objServiceMatricula.ConsultarMatricula(this.Codigo);

                lblCodigo.Text = objMatriculaDC.COD_MATRICULA.ToString();
                mskDNI.Text = objMatriculaDC.DNI_EST.ToString();

                cboSeccion.DataSource = objServiceSeccion.ListarSeccion();
                cboSeccion.ValueMember = "Id_Seccion";
                cboSeccion.DisplayMember = "GradoYSeccion";

                cboSeccion.SelectedValue = objMatriculaDC.ID_SECCION;

                if (objMatriculaDC.ESTADO_MATRI ==1)
                {
                    chkEstado.Checked = true;
                }
                else 
                { 
                    chkEstado.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
