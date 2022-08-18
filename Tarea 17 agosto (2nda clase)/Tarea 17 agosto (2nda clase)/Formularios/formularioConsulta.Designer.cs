namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    partial class formularioConsulta
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
            this.lblSeleccioneBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccioneBusqueda
            // 
            this.lblSeleccioneBusqueda.AutoSize = true;
            this.lblSeleccioneBusqueda.Location = new System.Drawing.Point(64, 49);
            this.lblSeleccioneBusqueda.Name = "lblSeleccioneBusqueda";
            this.lblSeleccioneBusqueda.Size = new System.Drawing.Size(160, 15);
            this.lblSeleccioneBusqueda.TabIndex = 0;
            this.lblSeleccioneBusqueda.Text = "Ingrese nombre de la carrera ";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(64, 67);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(150, 23);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(64, 112);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowTemplate.Height = 25;
            this.dgvConsultas.Size = new System.Drawing.Size(262, 130);
            this.dgvConsultas.TabIndex = 2;
            // 
            // formularioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblSeleccioneBusqueda);
            this.Name = "formularioConsulta";
            this.Text = "Consultar carreras existentes";
            this.Load += new System.EventHandler(this.formularioConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeleccioneBusqueda;
        private TextBox txtBusqueda;
        private DataGridView dgvConsultas;
    }
}