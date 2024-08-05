namespace TestWindows_WCF_Matriculas
{
    partial class ProfesorMan01
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
            dtgDatos = new DataGridView();
            COD_PROF = new DataGridViewTextBoxColumn();
            NOM_PROF = new DataGridViewTextBoxColumn();
            APE_PROF = new DataGridViewTextBoxColumn();
            DNI_PROF = new DataGridViewTextBoxColumn();
            CORREO_PROF = new DataGridViewTextBoxColumn();
            ESPECIALIDAD = new DataGridViewTextBoxColumn();
            TELF_PROF = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToResizeRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { COD_PROF, NOM_PROF, APE_PROF, DNI_PROF, CORREO_PROF, ESPECIALIDAD, TELF_PROF, Estado });
            dtgDatos.Location = new Point(12, 71);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(971, 340);
            dtgDatos.TabIndex = 2;
            // 
            // COD_PROF
            // 
            COD_PROF.DataPropertyName = "COD_PROF";
            COD_PROF.HeaderText = "Código";
            COD_PROF.Name = "COD_PROF";
            COD_PROF.ReadOnly = true;
            // 
            // NOM_PROF
            // 
            NOM_PROF.DataPropertyName = "NOM_PROF";
            NOM_PROF.HeaderText = "Nombre";
            NOM_PROF.Name = "NOM_PROF";
            NOM_PROF.ReadOnly = true;
            // 
            // APE_PROF
            // 
            APE_PROF.DataPropertyName = "APE_PROF";
            APE_PROF.HeaderText = "Apellido";
            APE_PROF.Name = "APE_PROF";
            APE_PROF.ReadOnly = true;
            // 
            // DNI_PROF
            // 
            DNI_PROF.DataPropertyName = "DNI_PROF";
            DNI_PROF.HeaderText = "DNI";
            DNI_PROF.Name = "DNI_PROF";
            DNI_PROF.ReadOnly = true;
            // 
            // CORREO_PROF
            // 
            CORREO_PROF.DataPropertyName = "CORREO_PROF";
            CORREO_PROF.HeaderText = "Correo";
            CORREO_PROF.Name = "CORREO_PROF";
            CORREO_PROF.ReadOnly = true;
            // 
            // ESPECIALIDAD
            // 
            ESPECIALIDAD.DataPropertyName = "ESPECIALIDAD";
            ESPECIALIDAD.HeaderText = "Especialidad";
            ESPECIALIDAD.Name = "ESPECIALIDAD";
            ESPECIALIDAD.ReadOnly = true;
            // 
            // TELF_PROF
            // 
            TELF_PROF.DataPropertyName = "TELF_PROF";
            TELF_PROF.HeaderText = "Teléfono";
            TELF_PROF.Name = "TELF_PROF";
            TELF_PROF.ReadOnly = true;
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
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre del profesor:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(230, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(394, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(498, 466);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 32);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(611, 466);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(726, 466);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 32);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(886, 466);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(835, 433);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(899, 429);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProfesorMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 510);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProfesorMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Profesores";
            Load += ProfesorMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn COD_PROF;
        private DataGridViewTextBoxColumn NOM_PROF;
        private DataGridViewTextBoxColumn APE_PROF;
        private DataGridViewTextBoxColumn DNI_PROF;
        private DataGridViewTextBoxColumn CORREO_PROF;
        private DataGridViewTextBoxColumn ESPECIALIDAD;
        private DataGridViewTextBoxColumn TELF_PROF;
        private DataGridViewTextBoxColumn Estado;
    }
}