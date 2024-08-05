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
    public partial class ProfesorMan03 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
        ProxyUbicacion.ServicioUbicacionClient objServiceUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        ProxyUbicacion.UbicacionDC objUbicacionDC = new ProxyUbicacion.UbicacionDC();
        List<ProxyUbicacion.UbicacionDC> listaDistritos;
        private byte[] imagenBytes;


        public ProfesorMan03()
        {
            InitializeComponent();
        }

        private Image RedimensionarImagen(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return b;
        }

        public String Codigo { get; set; }

        private void ProfesorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                listaDistritos = objServiceUbicacion.ListarUbicacion().ToList();
                cboUbigeo.DataSource = listaDistritos;
                cboUbigeo.ValueMember = "Id_Ubigeo";
                cboUbigeo.DisplayMember = "Distrito";

                objProfesorDC = objServiceProfesor.ConsultarProfesor(Codigo);

                lblCodigo.Text = objProfesorDC.COD_PROF.ToString();
                txtNomProfesor.Text = objProfesorDC.NOM_PROF;
                txtApeProfesor.Text = objProfesorDC.APE_PROF;
                txtCorreoProfesor.Text = objProfesorDC.CORREO_PROF;
                lblDni.Text = objProfesorDC.DNI_PROF;
                txtTelfProfesor.Text = objProfesorDC.TELF_PROF;
                txtEspecialidad.Text = objProfesorDC.ESPECIALIDAD;
                txtUsuUltMod.Text = objProfesorDC.Usu_Registro;
                cboUbigeo.SelectedValue = objProfesorDC.ID_UBIGEO;
                chkActivo.Checked = Convert.ToBoolean(objProfesorDC.ESTADO_PROF);

                if (objProfesorDC.SEXO_PROF == "F")
                {
                    optFemenino.Checked = true;
                }
                else if (objProfesorDC.SEXO_PROF == "M")
                {
                    optMasculino.Checked = true;
                }

                if (objProfesorDC.FOTO_PROF != null && objProfesorDC.FOTO_PROF.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(objProfesorDC.FOTO_PROF))
                    {
                        Image img = Image.FromStream(ms);
                        pcbFoto.Image = RedimensionarImagen(img, 100, 100);
                    }
                    imagenBytes = objProfesorDC.FOTO_PROF;
                }
                else
                {
                    pcbFoto.Image = Windows_Tes.Properties.Resources.imagenprederteminada;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomProfesor.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del profesor es obligatorio");
                }
                if (txtApeProfesor.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido del profesor es obligatorio");
                }
                if (txtEspecialidad.Text.Trim() == String.Empty)
                {
                    throw new Exception("La Especialidad del profesor es obligatorio");
                }
                if (txtCorreoProfesor.Text.Trim() == String.Empty)
                {
                    throw new Exception("El correo del profesor es obligatorio");
                }
                if (txtTelfProfesor.Text.Trim() == String.Empty)
                {
                    throw new Exception("El teléfono del profesor es obligatorio");
                }

                objProfesorDC.COD_PROF = lblCodigo.Text;
                objProfesorDC.NOM_PROF = txtNomProfesor.Text.Trim();
                objProfesorDC.APE_PROF = txtApeProfesor.Text.Trim();
                objProfesorDC.DNI_PROF = lblDni.Text;
                objProfesorDC.ESPECIALIDAD = txtEspecialidad.Text.Trim();
                objProfesorDC.CORREO_PROF = txtCorreoProfesor.Text.Trim();
                objProfesorDC.TELF_PROF = txtTelfProfesor.Text.Trim();
                objProfesorDC.Usu_Ult_Mod = txtUsuUltMod.Text.Trim();
                objProfesorDC.ID_UBIGEO = Convert.ToInt32(cboUbigeo.SelectedValue);
                objProfesorDC.ESTADO_PROF = Convert.ToInt16(chkActivo.Checked);

                if (optFemenino.Checked == true)
                {
                    objProfesorDC.SEXO_PROF = "F";
                }
                else if (optMasculino.Checked == true)
                {
                    objProfesorDC.SEXO_PROF = "M";
                }
                else
                {
                    throw new Exception("Debe seleccionar un sexo");
                }

                if (imagenBytes != null)
                {
                    objProfesorDC.FOTO_PROF = imagenBytes;
                }

                if (objServiceProfesor.ActualizarProfesor(objProfesorDC) == true)
                {
                    MessageBox.Show("Registro actualizado correctamente");
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

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Image imgOriginal = Image.FromFile(ofd.FileName);
                        Image imgRedimensionada = RedimensionarImagen(imgOriginal, 100, 100); // Ajusta el tamaño según tus necesidades

                        pcbFoto.Image = imgRedimensionada;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            imgRedimensionada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Cambia a JPEG o el formato que prefieras
                            imagenBytes = ms.ToArray();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
