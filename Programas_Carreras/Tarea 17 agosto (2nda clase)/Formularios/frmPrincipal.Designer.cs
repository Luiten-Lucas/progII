namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    partial class frmPrincipal
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.cboCuatrimestre = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.dgvAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(169, 58);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(45, 15);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(187, 145);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 15);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año";
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(234, 142);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(45, 23);
            this.cboAnio.TabIndex = 3;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(140, 177);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(75, 15);
            this.lblCuatrimestre.TabIndex = 4;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // cboCuatrimestre
            // 
            this.cboCuatrimestre.FormattingEnabled = true;
            this.cboCuatrimestre.Location = new System.Drawing.Point(234, 174);
            this.cboCuatrimestre.Name = "cboCuatrimestre";
            this.cboCuatrimestre.Size = new System.Drawing.Size(45, 23);
            this.cboCuatrimestre.TabIndex = 5;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(168, 114);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(47, 15);
            this.lblMateria.TabIndex = 6;
            this.lblMateria.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(235, 110);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(121, 23);
            this.cboMateria.TabIndex = 7;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAnio,
            this.dgvCuatrimestre,
            this.dgvMateria,
            this.dgvCarrera,
            this.dgvAcciones});
            this.dgvPlan.Location = new System.Drawing.Point(140, 217);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowTemplate.Height = 25;
            this.dgvPlan.Size = new System.Drawing.Size(398, 150);
            this.dgvPlan.TabIndex = 8;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            // 
            // dgvAnio
            // 
            this.dgvAnio.HeaderText = "Año";
            this.dgvAnio.Name = "dgvAnio";
            this.dgvAnio.ReadOnly = true;
            this.dgvAnio.Width = 54;
            // 
            // dgvCuatrimestre
            // 
            this.dgvCuatrimestre.HeaderText = "Cuatrimestre";
            this.dgvCuatrimestre.Name = "dgvCuatrimestre";
            this.dgvCuatrimestre.ReadOnly = true;
            // 
            // dgvMateria
            // 
            this.dgvMateria.HeaderText = "Materia";
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.ReadOnly = true;
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.HeaderText = "Carrera";
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.ReadOnly = true;
            this.dgvCarrera.Visible = false;
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.HeaderText = "Acciones";
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.ReadOnly = true;
            this.dgvAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvAcciones.Text = "Eliminar";
            this.dgvAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(346, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(204, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(463, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(170, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 15);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(235, 52);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 23);
            this.txtCarrera.TabIndex = 14;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(235, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 23);
            this.txtTitulo.TabIndex = 15;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(362, 110);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(20, 23);
            this.btnAgregarMateria.TabIndex = 17;
            this.btnAgregarMateria.Text = "+";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cboCuatrimestre);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblCarrera);
            this.Name = "frmPrincipal";
            this.Text = "Gestor de carreras";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarrera;
        private Label lblAnio;
        private ComboBox cboAnio;
        private Label lblCuatrimestre;
        private ComboBox cboCuatrimestre;
        private Label lblMateria;
        private ComboBox cboMateria;
        private DataGridView dgvPlan;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnAgregar;
        private Label lblTitulo;
        private TextBox txtCarrera;
        private TextBox txtTitulo;
        private DataGridViewTextBoxColumn dgvAnio;
        private DataGridViewTextBoxColumn dgvCuatrimestre;
        private DataGridViewTextBoxColumn dgvMateria;
        private DataGridViewTextBoxColumn dgvCarrera;
        private DataGridViewButtonColumn dgvAcciones;
        private Button btnAgregarMateria;
    }
}