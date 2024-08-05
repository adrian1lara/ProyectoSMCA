namespace TestWindows_WCF_SistemaMatricula
{
    partial class AlumnoMan03
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            dtpNacimiento = new DateTimePicker();
            groupBox1 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            label8 = new Label();
            chkEstado = new CheckBox();
            cboDistrito = new ComboBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            lblCodigo = new TextBox();
            txtUbigeo = new TextBox();
            txtDniApo = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 103);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 144);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 204);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 103);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 4;
            label5.Text = "Dni Apoderado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 248);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Ubigeo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 204);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Distrito:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(135, 144);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(244, 23);
            txtApellidos.TabIndex = 8;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(196, 201);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(105, 23);
            dtpNacimiento.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optFemenino);
            groupBox1.Controls.Add(optMasculino);
            groupBox1.Location = new Point(70, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 76);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo:";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(105, 39);
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
            optMasculino.Location = new Point(6, 39);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 353);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 13;
            label8.Text = "Estado:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(121, 352);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 14;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(539, 201);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(146, 23);
            cboDistrito.TabIndex = 16;
            cboDistrito.SelectedValueChanged += cboDistrito_SelectedValueChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(521, 385);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(631, 385);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 38);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 19;
            label9.Text = "Dni del estudiante:";
            // 
            // lblCodigo
            // 
            lblCodigo.Enabled = false;
            lblCodigo.Location = new Point(181, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(198, 23);
            lblCodigo.TabIndex = 20;
            // 
            // txtUbigeo
            // 
            txtUbigeo.Enabled = false;
            txtUbigeo.Location = new Point(539, 245);
            txtUbigeo.Name = "txtUbigeo";
            txtUbigeo.Size = new Size(146, 23);
            txtUbigeo.TabIndex = 21;
            // 
            // txtDniApo
            // 
            txtDniApo.Location = new Point(539, 100);
            txtDniApo.Mask = "99999999";
            txtDniApo.Name = "txtDniApo";
            txtDniApo.Size = new Size(143, 23);
            txtDniApo.TabIndex = 23;
            // 
            // AlumnoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(txtDniApo);
            Controls.Add(txtUbigeo);
            Controls.Add(lblCodigo);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(cboDistrito);
            Controls.Add(chkEstado);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(dtpNacimiento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlumnoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Estudiante";
            Load += AlumnoMan03_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private DateTimePicker dtpNacimiento;
        private GroupBox groupBox1;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
        private Label label8;
        private CheckBox chkEstado;
        private ComboBox cboDistrito;
        private Button btnActualizar;
        private Button btnCancelar;
        private Label label9;
        private TextBox lblCodigo;
        private TextBox txtUbigeo;
        private MaskedTextBox txtDniApo;
    }
}