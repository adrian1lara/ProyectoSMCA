namespace SYSMCA_GUI
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            estudiantesToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            matrículasToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cursosToolStripMenuItem, estudiantesToolStripMenuItem, profesoresToolStripMenuItem, matrículasToolStripMenuItem });
            mantenimientosToolStripMenuItem.Image = Windows_Tes.Properties.Resources.icons8_mantenimiento_48;
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(126, 24);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Image = Windows_Tes.Properties.Resources.icons8_curso_48;
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(184, 26);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += CursosToolStripMenuItem_Click;
            // 
            // estudiantesToolStripMenuItem
            // 
            estudiantesToolStripMenuItem.Image = Windows_Tes.Properties.Resources.estudianteToolStripMenuItem_Image1;
            estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            estudiantesToolStripMenuItem.Size = new Size(184, 26);
            estudiantesToolStripMenuItem.Text = "Estudiantes";
            estudiantesToolStripMenuItem.Click += estudiantesToolStripMenuItem_Click;
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.Image = Windows_Tes.Properties.Resources.icons8_profesor_48;
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(184, 26);
            profesoresToolStripMenuItem.Text = "Profesores";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
            // 
            // matrículasToolStripMenuItem
            // 
            matrículasToolStripMenuItem.Image = Windows_Tes.Properties.Resources.icons8_buscar_en_la_lista_48;
            matrículasToolStripMenuItem.Name = "matrículasToolStripMenuItem";
            matrículasToolStripMenuItem.Size = new Size(184, 26);
            matrículasToolStripMenuItem.Text = "Matrículas";
            matrículasToolStripMenuItem.Click += matrículasToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Image = Windows_Tes.Properties.Resources.icons8_cerrar_ventana_48;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(124, 24);
            salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            salirDelSistemaToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Windows_Tes.Properties.Resources._306859062_467054782110551_1457397748612698247_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIPrincipal";
            Text = "Menú Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Click += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem estudiantesToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem matrículasToolStripMenuItem;
    }
}