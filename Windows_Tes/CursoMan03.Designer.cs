namespace SYSMCA_GUI
{
    partial class CursoMan03
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
            txtNomCurso = new TextBox();
            cboGrado = new ComboBox();
            chkActivo = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            lblCodigo = new Label();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 75);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 125);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Grado:";
            // 
            // txtNomCurso
            // 
            txtNomCurso.Location = new Point(166, 75);
            txtNomCurso.Name = "txtNomCurso";
            txtNomCurso.Size = new Size(220, 23);
            txtNomCurso.TabIndex = 4;
            // 
            // cboGrado
            // 
            cboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrado.FormattingEnabled = true;
            cboGrado.Location = new Point(166, 125);
            cboGrado.Name = "cboGrado";
            cboGrado.Size = new Size(220, 23);
            cboGrado.TabIndex = 7;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(166, 183);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 8;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(283, 222);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 9;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(416, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(166, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(0, 270);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(623, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            lbl1.BackColor = SystemColors.ActiveCaptionText;
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 17);
            lbl1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(16, 17);
            lblUsuario.Text = "...";
            // 
            // CursoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 292);
            Controls.Add(statusStrip1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkActivo);
            Controls.Add(cboGrado);
            Controls.Add(lblCodigo);
            Controls.Add(txtNomCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CursoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Curso";
            Load += CursoMan03_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomCurso;
        private ComboBox cboGrado;
        private CheckBox chkActivo;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label lblCodigo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl1;
        private ToolStripStatusLabel lblUsuario;
    }
}