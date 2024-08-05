namespace TestWindows_WCF_Matriculas
{
    partial class ProfesorMan02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorMan02));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNomProfesor = new TextBox();
            txtApeProfesor = new TextBox();
            txtEspecialidad = new TextBox();
            txtCorreoProfesor = new TextBox();
            txtTelfProfesor = new TextBox();
            cboUbigeo = new ComboBox();
            txtUsuRegistro = new TextBox();
            groupBox1 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            pcbFoto = new PictureBox();
            chkActivo = new CheckBox();
            mskDni = new MaskedTextBox();
            btnCargarImagen = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del profesor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 32);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido del profesor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 89);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI del profesor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 89);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Especialidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 138);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Imagen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 272);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 11;
            label6.Text = "Correo eléctronico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(428, 272);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "Teléfono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 330);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 15;
            label8.Text = "Ubigeo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 330);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 17;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 388);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 19;
            label10.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(492, 430);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 30);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(645, 430);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNomProfesor
            // 
            txtNomProfesor.Location = new Point(168, 26);
            txtNomProfesor.Name = "txtNomProfesor";
            txtNomProfesor.Size = new Size(177, 23);
            txtNomProfesor.TabIndex = 1;
            // 
            // txtApeProfesor
            // 
            txtApeProfesor.Location = new Point(571, 26);
            txtApeProfesor.Name = "txtApeProfesor";
            txtApeProfesor.Size = new Size(177, 23);
            txtApeProfesor.TabIndex = 3;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(571, 81);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(177, 23);
            txtEspecialidad.TabIndex = 7;
            // 
            // txtCorreoProfesor
            // 
            txtCorreoProfesor.Location = new Point(168, 269);
            txtCorreoProfesor.Name = "txtCorreoProfesor";
            txtCorreoProfesor.Size = new Size(177, 23);
            txtCorreoProfesor.TabIndex = 12;
            // 
            // txtTelfProfesor
            // 
            txtTelfProfesor.Location = new Point(571, 269);
            txtTelfProfesor.Name = "txtTelfProfesor";
            txtTelfProfesor.Size = new Size(177, 23);
            txtTelfProfesor.TabIndex = 14;
            // 
            // cboUbigeo
            // 
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(168, 330);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(177, 23);
            cboUbigeo.TabIndex = 16;
            // 
            // txtUsuRegistro
            // 
            txtUsuRegistro.Location = new Point(168, 385);
            txtUsuRegistro.Name = "txtUsuRegistro";
            txtUsuRegistro.Size = new Size(177, 23);
            txtUsuRegistro.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optFemenino);
            groupBox1.Controls.Add(optMasculino);
            groupBox1.Location = new Point(173, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 92);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(17, 57);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(78, 19);
            optFemenino.TabIndex = 1;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(17, 32);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // pcbFoto
            // 
            pcbFoto.Image = (Image)resources.GetObject("pcbFoto.Image");
            pcbFoto.Location = new Point(571, 129);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(177, 85);
            pcbFoto.TabIndex = 21;
            pcbFoto.TabStop = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.CheckAlign = ContentAlignment.TopLeft;
            chkActivo.Location = new Point(571, 329);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 18;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // mskDni
            // 
            mskDni.Location = new Point(168, 81);
            mskDni.Mask = "99999999";
            mskDni.Name = "mskDni";
            mskDni.Size = new Size(177, 23);
            mskDni.TabIndex = 5;
            mskDni.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(601, 220);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(116, 23);
            btnCargarImagen.TabIndex = 10;
            btnCargarImagen.Text = "Subir Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // ProfesorMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 491);
            Controls.Add(btnCargarImagen);
            Controls.Add(mskDni);
            Controls.Add(chkActivo);
            Controls.Add(pcbFoto);
            Controls.Add(groupBox1);
            Controls.Add(txtUsuRegistro);
            Controls.Add(cboUbigeo);
            Controls.Add(txtTelfProfesor);
            Controls.Add(txtCorreoProfesor);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtApeProfesor);
            Controls.Add(txtNomProfesor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProfesorMan02";
            Text = "Nuevo Profesor";
            Load += ProfesorMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNomProfesor;
        private TextBox txtApeProfesor;
        private TextBox txtEspecialidad;
        private TextBox txtCorreoProfesor;
        private TextBox txtTelfProfesor;
        private ComboBox cboUbigeo;
        private TextBox txtUsuRegistro;
        private GroupBox groupBox1;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
        private PictureBox pcbFoto;
        private CheckBox chkActivo;
        private MaskedTextBox mskDni;
        private Button btnCargarImagen;
    }
}