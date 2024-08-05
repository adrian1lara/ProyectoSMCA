namespace AplicacionWindows_ESCUELA
{
    partial class frmInsertar
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
            cboMatricula = new GroupBox();
            mskDNI = new MaskedTextBox();
            cboSeccion = new ComboBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkEstado = new CheckBox();
            lblEstado = new Label();
            lblSeccion = new Label();
            lblDNI = new Label();
            cboMatricula.SuspendLayout();
            SuspendLayout();
            // 
            // cboMatricula
            // 
            cboMatricula.Controls.Add(mskDNI);
            cboMatricula.Controls.Add(cboSeccion);
            cboMatricula.Controls.Add(btnCancelar);
            cboMatricula.Controls.Add(btnGrabar);
            cboMatricula.Controls.Add(chkEstado);
            cboMatricula.Controls.Add(lblEstado);
            cboMatricula.Controls.Add(lblSeccion);
            cboMatricula.Controls.Add(lblDNI);
            cboMatricula.Location = new Point(11, 4);
            cboMatricula.Name = "cboMatricula";
            cboMatricula.Padding = new Padding(4, 3, 4, 3);
            cboMatricula.Size = new Size(435, 238);
            cboMatricula.TabIndex = 0;
            cboMatricula.TabStop = false;
            cboMatricula.Text = "Datos";
            cboMatricula.Enter += cboMatricula_Enter;
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(112, 44);
            mskDNI.Mask = "99999999";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(71, 23);
            mskDNI.TabIndex = 9;
            mskDNI.TextAlign = HorizontalAlignment.Right;
            // 
            // cboSeccion
            // 
            cboSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Location = new Point(148, 87);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(234, 23);
            cboSeccion.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(321, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(231, 189);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(69, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(113, 133);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 3;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            chkEstado.CheckedChanged += chkEstado_CheckedChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(46, 132);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Location = new Point(48, 90);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(95, 15);
            lblSeccion.TabIndex = 1;
            lblSeccion.Text = "Sección y Grado:";
            lblSeccion.Click += lblSeccion_Click;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(48, 47);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 258);
            Controls.Add(cboMatricula);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInsertar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Matricula";
            Load += frmInsertar_Load;
            cboMatricula.ResumeLayout(false);
            cboMatricula.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox cboMatricula;
        private Label lblSeccion;
        private Label lblDNI;
        private Label lblEstado;
        private CheckBox chkEstado;
        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboSeccion;
        private MaskedTextBox mskDNI;
    }
}