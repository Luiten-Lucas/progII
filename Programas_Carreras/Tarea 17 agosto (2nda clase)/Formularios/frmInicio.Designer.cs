namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.carrerasToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmArchivo.Text = "Archivo";
            this.tsmArchivo.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.menuToolStripMenuItem.Text = "Salir";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCarrerasToolStripMenuItem,
            this.crearNuevaCarreraToolStripMenuItem});
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            // 
            // consultarCarrerasToolStripMenuItem
            // 
            this.consultarCarrerasToolStripMenuItem.Name = "consultarCarrerasToolStripMenuItem";
            this.consultarCarrerasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarCarrerasToolStripMenuItem.Text = "Consultar carreras";
            // 
            // crearNuevaCarreraToolStripMenuItem
            // 
            this.crearNuevaCarreraToolStripMenuItem.Name = "crearNuevaCarreraToolStripMenuItem";
            this.crearNuevaCarreraToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.crearNuevaCarreraToolStripMenuItem.Text = "Crear nueva carrera";
            this.crearNuevaCarreraToolStripMenuItem.Click += new System.EventHandler(this.crearNuevaCarreraToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMateriasToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // consultarMateriasToolStripMenuItem
            // 
            this.consultarMateriasToolStripMenuItem.Name = "consultarMateriasToolStripMenuItem";
            this.consultarMateriasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consultarMateriasToolStripMenuItem.Text = "Consultar materias";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmArchivo;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem carrerasToolStripMenuItem;
        private ToolStripMenuItem consultarCarrerasToolStripMenuItem;
        private ToolStripMenuItem crearNuevaCarreraToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem consultarMateriasToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}