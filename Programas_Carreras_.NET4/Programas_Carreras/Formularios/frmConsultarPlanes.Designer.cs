namespace Programas_Carreras.Formularios
{
    partial class frmConsultarPlanes
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
            this.dsPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes = new Programas_Carreras.Reportes.dsPlanes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPlanesTableAdapter = new Programas_Carreras.Reportes.dsPlanesTableAdapters.dtPlanesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPlanesBindingSource
            // 
            this.dsPlanesBindingSource.DataSource = this.dsPlanes;
            this.dsPlanesBindingSource.Position = 0;
            // 
            // dsPlanes
            // 
            this.dsPlanes.DataSetName = "dsPlanes";
            this.dsPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtPlanesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Programas_Carreras.Reportes.ListadoPlanes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(195, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtPlanesBindingSource
            // 
            this.dtPlanesBindingSource.DataMember = "dtPlanes";
            this.dtPlanesBindingSource.DataSource = this.dsPlanesBindingSource;
            // 
            // dtPlanesTableAdapter
            // 
            this.dtPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultarPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConsultarPlanes";
            this.Text = "frmConsultarPlanes";
            this.Load += new System.EventHandler(this.frmConsultarPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsPlanesBindingSource;
        private Reportes.dsPlanes dsPlanes;
        private System.Windows.Forms.BindingSource dtPlanesBindingSource;
        private Reportes.dsPlanesTableAdapters.dtPlanesTableAdapter dtPlanesTableAdapter;
    }
}