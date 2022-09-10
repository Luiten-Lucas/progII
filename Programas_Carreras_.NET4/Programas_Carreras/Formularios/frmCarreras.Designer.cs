
namespace Programas_Carreras.Formularios
{
    partial class frmCarreras
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.cboCuatrimestre = new System.Windows.Forms.ComboBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.dgvAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(112, 44);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(112, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(112, 118);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(112, 152);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(112, 187);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 4;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(189, 44);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(213, 20);
            this.txtCarrera.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(189, 77);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(213, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(189, 115);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(121, 21);
            this.cboMateria.TabIndex = 7;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(189, 147);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(39, 21);
            this.cboAnio.TabIndex = 8;
            // 
            // cboCuatrimestre
            // 
            this.cboCuatrimestre.FormattingEnabled = true;
            this.cboCuatrimestre.Location = new System.Drawing.Point(189, 184);
            this.cboCuatrimestre.Name = "cboCuatrimestre";
            this.cboCuatrimestre.Size = new System.Drawing.Size(39, 21);
            this.cboCuatrimestre.TabIndex = 9;
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
            this.dgvPlan.Location = new System.Drawing.Point(115, 235);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.Size = new System.Drawing.Size(544, 149);
            this.dgvPlan.TabIndex = 10;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            // 
            // dgvAnio
            // 
            this.dgvAnio.HeaderText = "Año";
            this.dgvAnio.Name = "dgvAnio";
            // 
            // dgvCuatrimestre
            // 
            this.dgvCuatrimestre.HeaderText = "Cuatrimestre";
            this.dgvCuatrimestre.Name = "dgvCuatrimestre";
            // 
            // dgvMateria
            // 
            this.dgvMateria.HeaderText = "Materia";
            this.dgvMateria.Name = "dgvMateria";
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.HeaderText = "Carrera";
            this.dgvCarrera.Name = "dgvCarrera";
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.HeaderText = "Acciones";
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvAcciones.Text = "Eliminar";
            this.dgvAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(584, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(432, 402);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.cboCuatrimestre);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarrera);
            this.Name = "frmCarreras";
            this.Text = "frmCarreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.ComboBox cboCuatrimestre;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrera;
        private System.Windows.Forms.DataGridViewButtonColumn dgvAcciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}