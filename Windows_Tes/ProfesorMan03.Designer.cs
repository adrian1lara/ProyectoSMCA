namespace TestWindows_WCF_Matriculas
{
    partial class ProfesorMan03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorMan03));
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
            label11 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblCodigo = new Label();
            txtNomProfesor = new TextBox();
            txtApeProfesor = new TextBox();
            txtEspecialidad = new TextBox();
            txtCorreoProfesor = new TextBox();
            txtTelfProfesor = new TextBox();
            txtUsuUltMod = new TextBox();
            cboUbigeo = new ComboBox();
            chkActivo = new CheckBox();
            groupBox1 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            pcbFoto = new PictureBox();
            btnCargarImagen = new Button();
            lblDni = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre del profesor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 74);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido del profesor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 27);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 2;
            label4.Text = "DNI del profesor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 103);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 8;
            label5.Text = "Especialidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 139);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Imagen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 272);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 13;
            label7.Text = "Correo electrónico:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(419, 272);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Teléfono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 329);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 17;
            label9.Text = "Ubigeo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(419, 329);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 19;
            label10.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 386);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 21;
            label11.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(529, 428);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 30);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(652, 428);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(176, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(177, 23);
            lblCodigo.TabIndex = 1;
            // 
            // txtNomProfesor
            // 
            txtNomProfesor.Location = new Point(176, 69);
            txtNomProfesor.Name = "txtNomProfesor";
            txtNomProfesor.Size = new Size(177, 23);
            txtNomProfesor.TabIndex = 5;
            // 
            // txtApeProfesor
            // 
            txtApeProfesor.Location = new Point(549, 69);
            txtApeProfesor.Name = "txtApeProfesor";
            txtApeProfesor.Size = new Size(177, 23);
            txtApeProfesor.TabIndex = 7;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(176, 100);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(177, 23);
            txtEspecialidad.TabIndex = 9;
            // 
            // txtCorreoProfesor
            // 
            txtCorreoProfesor.Location = new Point(176, 269);
            txtCorreoProfesor.Name = "txtCorreoProfesor";
            txtCorreoProfesor.Size = new Size(177, 23);
            txtCorreoProfesor.TabIndex = 14;
            // 
            // txtTelfProfesor
            // 
            txtTelfProfesor.Location = new Point(549, 269);
            txtTelfProfesor.Name = "txtTelfProfesor";
            txtTelfProfesor.Size = new Size(177, 23);
            txtTelfProfesor.TabIndex = 16;
            // 
            // txtUsuUltMod
            // 
            txtUsuUltMod.Location = new Point(176, 383);
            txtUsuUltMod.Name = "txtUsuUltMod";
            txtUsuUltMod.Size = new Size(177, 23);
            txtUsuUltMod.TabIndex = 22;
            // 
            // cboUbigeo
            // 
            cboUbigeo.FormattingEnabled = true;
            cboUbigeo.Location = new Point(176, 329);
            cboUbigeo.Name = "cboUbigeo";
            cboUbigeo.Size = new Size(177, 23);
            cboUbigeo.TabIndex = 18;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.CheckAlign = ContentAlignment.TopLeft;
            chkActivo.Location = new Point(549, 325);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 20;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optFemenino);
            groupBox1.Controls.Add(optMasculino);
            groupBox1.Location = new Point(176, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 92);
            groupBox1.TabIndex = 10;
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
            pcbFoto.Location = new Point(549, 139);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(177, 76);
            pcbFoto.TabIndex = 24;
            pcbFoto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(584, 221);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(116, 23);
            btnCargarImagen.TabIndex = 12;
            btnCargarImagen.Text = "Subir Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // lblDni
            // 
            lblDni.BorderStyle = BorderStyle.FixedSingle;
            lblDni.Location = new Point(549, 25);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(177, 23);
            lblDni.TabIndex = 3;
            // 
            // ProfesorMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 478);
            Controls.Add(lblDni);
            Controls.Add(btnCargarImagen);
            Controls.Add(pcbFoto);
            Controls.Add(groupBox1);
            Controls.Add(chkActivo);
            Controls.Add(cboUbigeo);
            Controls.Add(txtUsuUltMod);
            Controls.Add(txtTelfProfesor);
            Controls.Add(txtCorreoProfesor);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtApeProfesor);
            Controls.Add(txtNomProfesor);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label11);
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
            Name = "ProfesorMan03";
            Text = "Actualizar Profesor";
            Load += ProfesorMan03_Load;
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
        private Label label11;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblCodigo;
        private TextBox txtNomProfesor;
        private TextBox txtApeProfesor;
        private TextBox txtEspecialidad;
        private TextBox txtCorreoProfesor;
        private TextBox txtTelfProfesor;
        private TextBox txtUsuUltMod;
        private ComboBox cboUbigeo;
        private CheckBox chkActivo;
        private GroupBox groupBox1;
        private PictureBox pcbFoto;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
        private Button btnCargarImagen;
        private Label lblDni;
    }
}