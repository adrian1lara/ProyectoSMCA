namespace AplicacionWindows_ESCUELA
{
    partial class frmActualizar
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
            gbInsertar = new GroupBox();
            mskDNI = new MaskedTextBox();
            cboSeccion = new ComboBox();
            lblCodigo = new Label();
            lblCod = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkEstado = new CheckBox();
            lblEstado = new Label();
            lblSeccion = new Label();
            lblDNI = new Label();
            gbInsertar.SuspendLayout();
            SuspendLayout();
            // 
            // gbInsertar
            // 
            gbInsertar.Controls.Add(mskDNI);
            gbInsertar.Controls.Add(cboSeccion);
            gbInsertar.Controls.Add(lblCodigo);
            gbInsertar.Controls.Add(lblCod);
            gbInsertar.Controls.Add(btnCancelar);
            gbInsertar.Controls.Add(btnGrabar);
            gbInsertar.Controls.Add(chkEstado);
            gbInsertar.Controls.Add(lblEstado);
            gbInsertar.Controls.Add(lblSeccion);
            gbInsertar.Controls.Add(lblDNI);
            gbInsertar.Location = new Point(12, 12);
            gbInsertar.Name = "gbInsertar";
            gbInsertar.Size = new Size(435, 238);
            gbInsertar.TabIndex = 1;
            gbInsertar.TabStop = false;
            gbInsertar.Text = "Datos";
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(117, 77);
            mskDNI.Mask = "99999999";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(83, 23);
            mskDNI.TabIndex = 13;
            mskDNI.TextAlign = HorizontalAlignment.Right;
            // 
            // cboSeccion
            // 
            cboSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Location = new Point(153, 120);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(222, 23);
            cboSeccion.TabIndex = 12;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(117, 28);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(63, 26);
            lblCodigo.TabIndex = 11;
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(50, 29);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(49, 15);
            lblCod.TabIndex = 8;
            lblCod.Text = "Codigo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(339, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(252, 198);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(69, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnInsertar_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(117, 166);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(66, 19);
            chkEstado.TabIndex = 3;
            chkEstado.Text = "Estado?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(54, 166);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Location = new Point(52, 123);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(95, 15);
            lblSeccion.TabIndex = 1;
            lblSeccion.Text = "Sección y Grado:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(52, 80);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 262);
            Controls.Add(gbInsertar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmActualizar";
            Load += frmActualizar_Load;
            gbInsertar.ResumeLayout(false);
            gbInsertar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInsertar;
        private Button btnCancelar;
        private Button btnGrabar;
        private CheckBox chkEstado;
        private Label lblEstado;
        private Label lblSeccion;
        private Label lblDNI;
        private Label lblCod;
        private Label lblCodigo;
        private ComboBox cboSeccion;
        private MaskedTextBox mskDNI;
    }
}