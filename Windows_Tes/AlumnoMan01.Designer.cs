namespace TestWindows_WCF_SistemaMatricula
{
    partial class AlumnoMan01
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
            dtgResultados = new DataGridView();
            DNI_EST = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            SEXO_EST = new DataGridViewTextBoxColumn();
            FEC_NAC_EST = new DataGridViewTextBoxColumn();
            DNI_APO = new DataGridViewTextBoxColumn();
            Nom_Apo = new DataGridViewTextBoxColumn();
            Ape_Apo = new DataGridViewTextBoxColumn();
            Tel_Apo = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            EST_EST = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgResultados).BeginInit();
            SuspendLayout();
            // 
            // dtgResultados
            // 
            dtgResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgResultados.Columns.AddRange(new DataGridViewColumn[] { DNI_EST, Nombre, Apellido, SEXO_EST, FEC_NAC_EST, DNI_APO, Nom_Apo, Ape_Apo, Tel_Apo, Distrito, EST_EST });
            dtgResultados.Location = new Point(28, 63);
            dtgResultados.Name = "dtgResultados";
            dtgResultados.RowTemplate.Height = 25;
            dtgResultados.Size = new Size(1040, 318);
            dtgResultados.TabIndex = 0;
            // 
            // DNI_EST
            // 
            DNI_EST.DataPropertyName = "DNI_EST";
            DNI_EST.HeaderText = "DNI Estudiante";
            DNI_EST.Name = "DNI_EST";
            DNI_EST.Width = 101;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "NOM_EST";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "APE_EST";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 76;
            // 
            // SEXO_EST
            // 
            SEXO_EST.DataPropertyName = "SEXO_EST";
            SEXO_EST.HeaderText = "Sexo";
            SEXO_EST.Name = "SEXO_EST";
            SEXO_EST.Width = 57;
            // 
            // FEC_NAC_EST
            // 
            FEC_NAC_EST.DataPropertyName = "FEC_NAC_EST";
            FEC_NAC_EST.HeaderText = "Fecha Nacimiento";
            FEC_NAC_EST.Name = "FEC_NAC_EST";
            FEC_NAC_EST.Width = 117;
            // 
            // DNI_APO
            // 
            DNI_APO.DataPropertyName = "DNI_APO";
            DNI_APO.HeaderText = "DNI Apoderado";
            DNI_APO.Name = "DNI_APO";
            DNI_APO.Width = 105;
            // 
            // Nom_Apo
            // 
            Nom_Apo.DataPropertyName = "Nom_Apo";
            Nom_Apo.HeaderText = "Nombre Apoderado";
            Nom_Apo.Name = "Nom_Apo";
            Nom_Apo.Width = 126;
            // 
            // Ape_Apo
            // 
            Ape_Apo.DataPropertyName = "Ape_Apo";
            Ape_Apo.HeaderText = "Apellido Apoderado";
            Ape_Apo.Name = "Ape_Apo";
            Ape_Apo.Width = 126;
            // 
            // Tel_Apo
            // 
            Tel_Apo.DataPropertyName = "Tel_Apo";
            Tel_Apo.HeaderText = "Telefono";
            Tel_Apo.Name = "Tel_Apo";
            Tel_Apo.Width = 77;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            Distrito.Width = 70;
            // 
            // EST_EST
            // 
            EST_EST.DataPropertyName = "EST_EST";
            EST_EST.HeaderText = "Estado";
            EST_EST.Name = "EST_EST";
            EST_EST.Width = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(940, 403);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1005, 397);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(63, 26);
            lblRegistros.TabIndex = 12;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(720, 455);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(801, 455);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(993, 455);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(882, 455);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 24);
            label2.Name = "label2";
            label2.Size = new Size(219, 15);
            label2.TabIndex = 17;
            label2.Text = "Ingrese filtro por apellido del estudiante:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(262, 21);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(205, 23);
            txtFiltro.TabIndex = 18;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // AlumnoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 504);
            Controls.Add(txtFiltro);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(dtgResultados);
            Name = "AlumnoMan01";
            Text = "Mantenimiento de Estudiantes";
            Load += AlumnoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgResultados;
        private Label label1;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtFiltro;
        private DataGridViewTextBoxColumn DNI_EST;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn SEXO_EST;
        private DataGridViewTextBoxColumn FEC_NAC_EST;
        private DataGridViewTextBoxColumn DNI_APO;
        private DataGridViewTextBoxColumn Nom_Apo;
        private DataGridViewTextBoxColumn Ape_Apo;
        private DataGridViewTextBoxColumn Tel_Apo;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn EST_EST;
    }
}