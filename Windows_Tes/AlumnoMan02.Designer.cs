namespace TestWindows_WCF_SistemaMatricula
{
    partial class AlumnoMan02
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
            label4 = new Label();
            label5 = new Label();
            groupBoxSexo = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            dtpNacimiento = new DateTimePicker();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label6 = new Label();
            CboDistrito = new ComboBox();
            chkEstado = new CheckBox();
            label8 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtUbigeo = new TextBox();
            txtDNI = new MaskedTextBox();
            txtDniApo = new MaskedTextBox();
            groupBoxSexo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 36);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 130);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 79);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 6;
            label5.Text = "DNI apoderado:";
            // 
            // groupBoxSexo
            // 
            groupBoxSexo.Controls.Add(optFemenino);
            groupBoxSexo.Controls.Add(optMasculino);
            groupBoxSexo.Location = new Point(74, 184);
            groupBoxSexo.Name = "groupBoxSexo";
            groupBoxSexo.Size = new Size(192, 70);
            groupBoxSexo.TabIndex = 10;
            groupBoxSexo.TabStop = false;
            groupBoxSexo.Text = "Sexo:";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(108, 33);
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
            optMasculino.Location = new Point(6, 33);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(211, 124);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(107, 23);
            dtpNacimiento.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(139, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(237, 23);
            txtApellido.TabIndex = 3;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 204);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 13;
            label6.Text = "Distrito:";
            // 
            // CboDistrito
            // 
            CboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDistrito.FormattingEnabled = true;
            CboDistrito.Location = new Point(537, 201);
            CboDistrito.Name = "CboDistrito";
            CboDistrito.Size = new Size(179, 23);
            CboDistrito.TabIndex = 14;
            CboDistrito.SelectedValueChanged += CboDistrito_SelectedValueChanged;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(125, 277);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 12;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 278);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 11;
            label8.Text = "Estado:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(537, 336);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(641, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 243);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 20;
            label7.Text = "Ubigeo:";
            // 
            // txtUbigeo
            // 
            txtUbigeo.Enabled = false;
            txtUbigeo.Location = new Point(537, 240);
            txtUbigeo.Name = "txtUbigeo";
            txtUbigeo.Size = new Size(179, 23);
            txtUbigeo.TabIndex = 22;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(537, 33);
            txtDNI.Mask = "99999999";
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(179, 23);
            txtDNI.TabIndex = 5;
            // 
            // txtDniApo
            // 
            txtDniApo.Location = new Point(537, 76);
            txtDniApo.Mask = "99999999";
            txtDniApo.Name = "txtDniApo";
            txtDniApo.Size = new Size(176, 23);
            txtDniApo.TabIndex = 23;
            // 
            // AlumnoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 393);
            Controls.Add(txtDniApo);
            Controls.Add(txtDNI);
            Controls.Add(txtUbigeo);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label8);
            Controls.Add(chkEstado);
            Controls.Add(CboDistrito);
            Controls.Add(label6);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dtpNacimiento);
            Controls.Add(groupBoxSexo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlumnoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Estudiante";
            Load += AlumnoMan02_Load;
            groupBoxSexo.ResumeLayout(false);
            groupBoxSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBoxSexo;
        private RadioButton optMasculino;
        private RadioButton optFemenino;
        private DateTimePicker dtpNacimiento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label6;
        private ComboBox CboDistrito;
        private CheckBox chkEstado;
        private Label label8;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label7;
        private TextBox txtUbigeo;
        private MaskedTextBox txtDNI;
        private MaskedTextBox txtDniApo;
    }
}