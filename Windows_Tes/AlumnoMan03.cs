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
    public partial class AlumnoMan03 : Form
    {
        ProxyEstudiante.ServicioEstudianteClient objServicioEstudiante = new ProxyEstudiante.ServicioEstudianteClient();
        ProxyEstudiante.EstudianteDC objEstudianteDC = new ProxyEstudiante.EstudianteDC();


        //Apoderado..
        ProxyApoderado.ServicioApoderadoClient objServicioApoderado = new ProxyApoderado.ServicioApoderadoClient();

        //Combox...
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        public AlumnoMan03()
        {
            InitializeComponent();
        }

        public Int32 StrCodigo { get; set; }

        /*
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */

        private void AlumnoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                cboDistrito.DataSource = objServicioUbicacion.ListarUbicacion();
                cboDistrito.DisplayMember = "Distrito";
                cboDistrito.ValueMember = "Id_Ubigeo";

                /*
                cboDniApo.DataSource = objServicioEstudiante.ListarEstudiante();
                cboDniApo.ValueMember = "DNI_APO";
                */


                dtpNacimiento.MinDate = new DateTime(1905, 1, 01);
                dtpNacimiento.MaxDate = DateTime.Today;

                if (StrCodigo > 0)
                {

                    objEstudianteDC = objServicioEstudiante.ConsultarEstudiante(this.StrCodigo);

                    lblCodigo.Text = this.StrCodigo.ToString();
                    //txtDNI.Text = objEstudianteDC.DNI_EST.ToString();
                    txtNombre.Text = objEstudianteDC.NOM_EST;
                    txtApellidos.Text = objEstudianteDC.APE_EST;
                    optMasculino.Checked = objEstudianteDC.SEXO_EST == "M";
                    optFemenino.Checked = objEstudianteDC.SEXO_EST == "F";
                    dtpNacimiento.Value = Convert.ToDateTime(objEstudianteDC.FEC_NAC_EST);
                    txtDniApo.Text = objEstudianteDC.DNI_APO.ToString(); //
                    txtUbigeo.Text = objEstudianteDC.ID_UBIGEO.ToString();
                    //cboDistrito.SelectedValue = objEstudianteDC.ID_UBIGEO;
                    chkEstado.Checked = Convert.ToBoolean(objEstudianteDC.EST_EST);
                    cboDistrito.SelectedValue = objEstudianteDC.ID_UBIGEO;
                    //cboDniApo.SelectedValue = objEstudianteDC.DNI_APO;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void cboDistrito_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDistrito.SelectedItem is UbicacionDC distrito)
            {
                txtUbigeo.Text = distrito.Id_Ubigeo.ToString();
                objEstudianteDC.ID_UBIGEO = distrito.Id_Ubigeo;
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellidos.Text.Trim() == ""
                    || txtDniApo.Text.Trim() == "" 
                    || dtpNacimiento.Text.Trim() == ""
                    || cboDistrito.Text.Trim() == ""
                    //|| cboDniApo.Text.Trim() == ""
                    //cboUbigeo.SelectedIndex == 0
                    )
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

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


                objEstudianteDC.DNI_EST = Convert.ToInt32(lblCodigo.Text.Trim());
                objEstudianteDC.NOM_EST = txtNombre.Text.Trim();
                objEstudianteDC.APE_EST = txtApellidos.Text.Trim();
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
                objEstudianteDC.DNI_APO = Convert.ToInt32(txtDniApo.Text.Trim()); // 
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
                if (objServicioEstudiante.ActualizarEstudiante(objEstudianteDC))
                {
                    MessageBox.Show("Estudiante actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar el estudiante, contacte con IT.");
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
    }
}



