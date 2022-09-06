
namespace Programas_Carreras.Formularios
{
    partial class frmAgregarMateria
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
            this.lblMateriaNueva = new System.Windows.Forms.Label();
            this.txtMateriaNueva = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMateriaNueva
            // 
            this.lblMateriaNueva.AutoSize = true;
            this.lblMateriaNueva.Location = new System.Drawing.Point(41, 41);
            this.lblMateriaNueva.Name = "lblMateriaNueva";
            this.lblMateriaNueva.Size = new System.Drawing.Size(107, 13);
            this.lblMateriaNueva.TabIndex = 0;
            this.lblMateriaNueva.Text = "Nombre de la materia";
            // 
            // txtMateriaNueva
            // 
            this.txtMateriaNueva.Location = new System.Drawing.Point(44, 77);
            this.txtMateriaNueva.Name = "txtMateriaNueva";
            this.txtMateriaNueva.Size = new System.Drawing.Size(154, 20);
            this.txtMateriaNueva.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(44, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(150, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnCrearMateria_Click);
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 175);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMateriaNueva);
            this.Controls.Add(this.lblMateriaNueva);
            this.Name = "frmAgregarMateria";
            this.Text = "Agregar nueva materia";
            this.Load += new System.EventHandler(this.frmAgregarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateriaNueva;
        private System.Windows.Forms.TextBox txtMateriaNueva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}