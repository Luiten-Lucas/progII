namespace Programas_Carreras.Formularios
{
    partial class frmConsultarCarreras
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsMateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterias = new Programas_Carreras.Reportes.dsMaterias();
            this.dtCarrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCarrerasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtCarrerasTableAdapter = new Programas_Carreras.Reportes.dsMateriasTableAdapters.dtCarrerasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtCarrerasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrerasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrerasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsMateriasBindingSource
            // 
            this.dsMateriasBindingSource.DataSource = this.dsMaterias;
            this.dsMateriasBindingSource.Position = 0;
            // 
            // dsMaterias
            // 
            this.dsMaterias.DataSetName = "dsMaterias";
            this.dsMaterias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtCarrerasBindingSource
            // 
            this.dtCarrerasBindingSource.DataMember = "dtCarreras";
            this.dtCarrerasBindingSource.DataSource = this.dsMaterias;
            // 
            // dtCarrerasBindingSource1
            // 
            this.dtCarrerasBindingSource1.DataMember = "dtCarreras";
            this.dtCarrerasBindingSource1.DataSource = this.dsMateriasBindingSource;
            // 
            // dtCarrerasTableAdapter
            // 
            this.dtCarrerasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtCarrerasBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Programas_Carreras.Reportes.ListadoCarreras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtCarrerasBindingSource2
            // 
            this.dtCarrerasBindingSource2.DataMember = "dtCarreras";
            this.dtCarrerasBindingSource2.DataSource = this.dsMaterias;
            // 
            // frmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConsultarCarreras";
            this.Text = "Consultar carreras";
            this.Load += new System.EventHandler(this.frmConsultarCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrerasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarrerasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dsMateriasBindingSource;
        private Reportes.dsMaterias dsMaterias;
        private System.Windows.Forms.BindingSource dtCarrerasBindingSource;
        private System.Windows.Forms.BindingSource dtCarrerasBindingSource1;
        private Reportes.dsMateriasTableAdapters.dtCarrerasTableAdapter dtCarrerasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtCarrerasBindingSource2;
    }
}