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
    public partial class ProfesorMan02 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();       
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
        ProxyUbicacion.ServicioUbicacionClient objServiceUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        ProxyUbicacion.UbicacionDC objUbicacionDC = new ProxyUbicacion.UbicacionDC();
        List<ProxyUbicacion.UbicacionDC> listaDistritos;
        private byte[] imagenBytes;

        public ProfesorMan02()
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

        private void ProfesorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                listaDistritos = objServiceUbicacion.ListarUbicacion().ToList();
                cboUbigeo.DataSource = listaDistritos;
                cboUbigeo.ValueMember = "Id_Ubigeo";
                cboUbigeo.DisplayMember = "Distrito";
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
                if (mskDni.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
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

                bool existeProfesor = objServiceProfesor.ExisteProfesor(mskDni.Text);

                if (existeProfesor)
                {
                    throw new Exception("Ya existe un profesor con el mismo DNI");
                }

                objProfesorDC.NOM_PROF = txtNomProfesor.Text.Trim();
                objProfesorDC.APE_PROF = txtApeProfesor.Text.Trim();
                objProfesorDC.DNI_PROF = mskDni.Text;
                objProfesorDC.ESPECIALIDAD = txtEspecialidad.Text.Trim();
                objProfesorDC.CORREO_PROF = txtCorreoProfesor.Text.Trim();
                objProfesorDC.TELF_PROF = txtTelfProfesor.Text.Trim();
                objProfesorDC.Usu_Registro = txtUsuRegistro.Text.Trim();
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


                if (objServiceProfesor.InsertarProfesor(objProfesorDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con TI");
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
