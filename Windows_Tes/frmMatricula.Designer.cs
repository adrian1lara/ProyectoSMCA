namespace AplicacionWindows_ESCUELA
{
    partial class frmMatricula
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgMatricula = new DataGridView();
            Cod_Matricula = new DataGridViewTextBoxColumn();
            Dni_Est = new DataGridViewTextBoxColumn();
            Nom_Est = new DataGridViewTextBoxColumn();
            Ape_Est = new DataGridViewTextBoxColumn();
            Sección = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            button3 = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            btnBuscar = new Button();
            txtCodigoBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgMatricula).BeginInit();
            SuspendLayout();
            // 
            // dtgMatricula
            // 
            dtgMatricula.AllowUserToAddRows = false;
            dtgMatricula.AllowUserToDeleteRows = false;
            dtgMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgMatricula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMatricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMatricula.Columns.AddRange(new DataGridViewColumn[] { Cod_Matricula, Dni_Est, Nom_Est, Ape_Est, Sección, Estado });
            dtgMatricula.Location = new Point(12, 94);
            dtgMatricula.Name = "dtgMatricula";
            dtgMatricula.ReadOnly = true;
            dtgMatricula.RowHeadersVisible = false;
            dtgMatricula.RowTemplate.Height = 25;
            dtgMatricula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMatricula.Size = new Size(723, 322);
            dtgMatricula.TabIndex = 0;
            dtgMatricula.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Cod_Matricula
            // 
            Cod_Matricula.DataPropertyName = "Cod_Matricula";
            Cod_Matricula.HeaderText = "Codigo";
            Cod_Matricula.Name = "Cod_Matricula";
            Cod_Matricula.ReadOnly = true;
            // 
            // Dni_Est
            // 
            Dni_Est.DataPropertyName = "Dni_Est";
            Dni_Est.HeaderText = "Dni";
            Dni_Est.Name = "Dni_Est";
            Dni_Est.ReadOnly = true;
            // 
            // Nom_Est
            // 
            Nom_Est.DataPropertyName = "Nom_Est";
            Nom_Est.HeaderText = "Nombre";
            Nom_Est.Name = "Nom_Est";
            Nom_Est.ReadOnly = true;
            // 
            // Ape_Est
            // 
            Ape_Est.DataPropertyName = "Ape_Est";
            Ape_Est.HeaderText = "Apellido";
            Ape_Est.Name = "Ape_Est";
            Ape_Est.ReadOnly = true;
            // 
            // Sección
            // 
            Sección.DataPropertyName = "Nom_Secc";
            Sección.HeaderText = "Sección";
            Sección.Name = "Sección";
            Sección.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(558, 434);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(638, 434);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(69, 30);
            lblRegistros.TabIndex = 11;
            lblRegistros.Click += lblRegistros_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.Location = new Point(470, 477);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(70, 28);
            btnInsertar.TabIndex = 12;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += button1_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.Location = new Point(546, 477);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(70, 28);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(637, 477);
            button3.Name = "button3";
            button3.Size = new Size(70, 28);
            button3.TabIndex = 14;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(394, 477);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(70, 28);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 39);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 16;
            label2.Text = "Codigo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(247, 35);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(64, 29);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodigoBuscar
            // 
            txtCodigoBuscar.Location = new Point(105, 39);
            txtCodigoBuscar.Name = "txtCodigoBuscar";
            txtCodigoBuscar.Size = new Size(100, 23);
            txtCodigoBuscar.TabIndex = 18;
            // 
            // frmMatricula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 517);
            Controls.Add(txtCodigoBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(button3);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgMatricula);
            Name = "frmMatricula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Matricula";
            Load += frmMatricula_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMatricula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgMatricula;
        private Label label1;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button button3;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Cod_Matricula;
        private DataGridViewTextBoxColumn Dni_Est;
        private DataGridViewTextBoxColumn Nom_Est;
        private DataGridViewTextBoxColumn Ape_Est;
        private DataGridViewTextBoxColumn Sección;
        private DataGridViewTextBoxColumn Estado;
        private Label label2;
        private Button btnBuscar;
        private TextBox txtCodigoBuscar;
    }
}
