namespace SYSMCA_GUI
{
    partial class CursoMan01
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
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            dtgDatos = new DataGridView();
            COD_CURSO = new DataGridViewTextBoxColumn();
            Nom_Curso = new DataGridViewTextBoxColumn();
            Nom_Grado = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por nombre del curso:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(243, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(314, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(820, 421);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(899, 421);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(509, 466);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 32);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(625, 466);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(740, 466);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(886, 466);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { COD_CURSO, Nom_Curso, Nom_Grado, Estado });
            dtgDatos.Location = new Point(13, 50);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(971, 340);
            dtgDatos.TabIndex = 4;
            // 
            // COD_CURSO
            // 
            COD_CURSO.DataPropertyName = "COD_CURSO";
            COD_CURSO.HeaderText = "Codigo";
            COD_CURSO.Name = "COD_CURSO";
            COD_CURSO.ReadOnly = true;
            COD_CURSO.Resizable = DataGridViewTriState.True;
            // 
            // Nom_Curso
            // 
            Nom_Curso.DataPropertyName = "Nom_Curso";
            Nom_Curso.HeaderText = "Curso";
            Nom_Curso.Name = "Nom_Curso";
            Nom_Curso.ReadOnly = true;
            // 
            // Nom_Grado
            // 
            Nom_Grado.DataPropertyName = "Nom_Grado";
            Nom_Grado.HeaderText = "Grado";
            Nom_Grado.Name = "Nom_Grado";
            Nom_Grado.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // CursoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 510);
            Controls.Add(dtgDatos);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CursoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Cursos";
            Load += CursoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn COD_CURSO;
        private DataGridViewTextBoxColumn Nom_Curso;
        private DataGridViewTextBoxColumn Nom_Grado;
        private DataGridViewTextBoxColumn Estado;
    }
}