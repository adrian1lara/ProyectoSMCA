using ProxyUbicacion;
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
    public partial class AlumnoMan02 : Form
    {

        ProxyEstudiante.ServicioEstudianteClient objServicioEstudiante = new ProxyEstudiante.ServicioEstudianteClient();

        ProxyEstudiante.EstudianteDC objEstudianteDC = new ProxyEstudiante.EstudianteDC();
        
        //Apoderado..
        ProxyApoderado.ServicioApoderadoClient objServicioApoderado = new ProxyApoderado.ServicioApoderadoClient();

        //Combox...
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        public AlumnoMan02()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlumnoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CboDistrito.DataSource = objServicioUbicacion.ListarUbicacion();
                CboDistrito.DisplayMember = "Distrito";
                CboDistrito.ValueMember = "Id_Ubigeo";
                /*
                cboDniApo.DataSource = objServicioEstudiante.ListarEstudiante();
                //cboDniApo.DisplayMember = "DNI_EST";
                cboDniApo.ValueMember = "DNI_APO";
                */

                dtpNacimiento.MinDate = new DateTime(1905, 1, 01);
                dtpNacimiento.MaxDate = DateTime.Today;

                //activar estado por defecto:
                chkEstado.Checked = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == ""
                    || txtDNI.Text.Trim() == "" ||
                    txtDniApo.Text.Trim() == "" ||
                    dtpNacimiento.Text.Trim() == "" || CboDistrito.Text.Trim() == ""
                    //|| cboDniApo.Text.Trim() == ""
                    //cboUbigeo.SelectedIndex == 0

                    )
                {
                    throw new Exception("Todos los datos son obligatorios");
                }
                /*
                if (txtDniApo.MaskFull == false)
                {
                    throw new Exception("Ingrese el DNI del apoderado registrado en la base de datos.");
                }
            */

                /*
                // Verificar si el DNI del apoderado está registrado
                var apoderado = objServicioEstudiante.ListarEstudiante().FirstOrDefault(a => a.DNI_APO == Convert.ToInt32(txtDniApo.Text.Trim()));
                if (apoderado == null)
                {
                    throw new Exception("Ingrese el DNI del apoderado registrado en la base de datos.");
                }
                */

                var apoderado = objServicioApoderado.ListarApoderado().FirstOrDefault(a => a.DNI_APO == Convert.ToInt32(txtDniApo.Text.Trim()));
                if (apoderado == null)
                {
                    throw new Exception("Ingrese el DNI del apoderado registrado en la base de datos.");
                }


                objEstudianteDC.DNI_EST = Convert.ToInt32(txtDNI.Text.Trim());
                objEstudianteDC.NOM_EST = txtNombre.Text.Trim();
                objEstudianteDC.APE_EST = txtApellido.Text.Trim();
                if (optMasculino.Checked)
                {
                    objEstudianteDC.SEXO_EST = "M";
                }
                if (optFemenino.Checked)
                {
                    objEstudianteDC.SEXO_EST = "F";
                }
                objEstudianteDC.FOTO_EST = Array.Empty<byte>();
                objEstudianteDC.FEC_NAC_EST = dtpNacimiento.Value;
                objEstudianteDC.DNI_APO = Convert.ToInt32(txtDniApo.Text.Trim()); // <---
                //objEstudianteDC.DNI_APO = Convert.ToInt32(cboDniApo.SelectedValue);
                objEstudianteDC.ID_UBIGEO = Convert.ToInt32(txtUbigeo.Text.Trim());
                //objEstudianteDC.EST_EST = Convert.ToInt16(chkEstado.Checked);

                if (chkEstado.Checked)
                {
                    objEstudianteDC.EST_EST = 1;
                }
                else
                {
                    objEstudianteDC.EST_EST = 0;
                }
                objEstudianteDC.Usu_Registro = "vcruces"; // <---- 


                if (objServicioEstudiante.InsertarEstudiante(objEstudianteDC))
                {
                    MessageBox.Show("Estudiante ingresado correctamente.");
                    this.Close();
                }

                else
                {
                    throw new Exception("No se pudo ingresar al estudiante, contacte con IT.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CboDistrito_SelectedValueChanged(object sender, EventArgs e)
        {
            UbicacionDC distrito = (UbicacionDC)CboDistrito.SelectedItem;
            txtUbigeo.Text = distrito.Id_Ubigeo.ToString();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // https://stackoverflow.com/a/8321942
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
