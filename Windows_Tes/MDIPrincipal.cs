using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TestWindows_WCF_SistemaMatricula;
using TestWindows_WCF_Matriculas;
using AplicacionWindows_ESCUELA;

namespace SYSMCA_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        // Método para manejar el evento del menú "Cursos"
        private void CursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario para el manejo de cursos como un formulario secundario en el MDI
            CursoMan01 curso01 = new CursoMan01();
            curso01.MdiParent = this;
            curso01.Show();
        }

        // Método para manejar el evento de carga del formulario principal
        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
                // Hace visible el menú de mantenimientos
                mantenimientosToolStripMenuItem.Visible = true;
        }

        // Método para manejar el evento del menú "Salir"
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pregunta al usuario si está seguro de salir y cierra la aplicación si la respuesta es sí
            if (MessageBox.Show("¿Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Método para manejar el evento de cierre del formulario principal
        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Pregunta al usuario si está seguro de salir y cancela el cierre si la respuesta es no
            if (MessageBox.Show("¿Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // Método para manejar el evento de cierre del formulario principal
        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cierra la aplicación cuando se cierra el formulario principal
            Application.Exit();
        }

        // Método para manejar el evento del menú "Estudiantes"
        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario para el manejo de estudiantes como un formulario secundario en el MDI
            AlumnoMan01 estu01 = new AlumnoMan01();
            estu01.MdiParent = this;
            estu01.Show();
        }

        // Método para manejar el evento del menú "Profesores"
        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario para el manejo de profesores como un formulario secundario en el MDI
            ProfesorMan01 prof01 = new ProfesorMan01();
            prof01.MdiParent = this;
            prof01.Show();
        }

        // Método para manejar el evento de cambio de tamaño del formulario principal
        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            // Refresca el formulario cuando cambia de tamaño (puede no ser necesario)
            this.Refresh();
        }

        private void matrículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario para el manejo de matriculas como un formulario secundario en el MDI
            frmMatricula matri = new frmMatricula();
            matri.MdiParent = this;
            matri.Show();
        }
    }
}
