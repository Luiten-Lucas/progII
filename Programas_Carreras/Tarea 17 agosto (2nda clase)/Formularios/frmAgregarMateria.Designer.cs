namespace Tarea_17_agosto__2nda_clase_.Formularios
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
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtMateriaNueva = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(27, 54);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(122, 15);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Nombre de la materia";
            // 
            // txtMateriaNueva
            // 
            this.txtMateriaNueva.Location = new System.Drawing.Point(27, 84);
            this.txtMateriaNueva.Name = "txtMateriaNueva";
            this.txtMateriaNueva.Size = new System.Drawing.Size(170, 23);
            this.txtMateriaNueva.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(27, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(140, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 168);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMateriaNueva);
            this.Controls.Add(this.lblMateria);
            this.Name = "frmAgregarMateria";
            this.Text = "Agregar nueva materia";
            this.Load += new System.EventHandler(this.frmAgregarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMateria;
        private TextBox txtMateriaNueva;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}