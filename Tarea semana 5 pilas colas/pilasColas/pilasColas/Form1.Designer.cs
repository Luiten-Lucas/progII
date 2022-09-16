namespace pilasColas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.rbtPila = new System.Windows.Forms.RadioButton();
            this.rbtCola = new System.Windows.Forms.RadioButton();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnVacia = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(32, 39);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(160, 23);
            this.txtElemento.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 15;
            this.lstPila.Location = new System.Drawing.Point(32, 89);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(93, 184);
            this.lstPila.TabIndex = 2;
            // 
            // rbtPila
            // 
            this.rbtPila.AutoSize = true;
            this.rbtPila.Location = new System.Drawing.Point(143, 116);
            this.rbtPila.Name = "rbtPila";
            this.rbtPila.Size = new System.Drawing.Size(44, 19);
            this.rbtPila.TabIndex = 3;
            this.rbtPila.TabStop = true;
            this.rbtPila.Text = "Pila";
            this.rbtPila.UseVisualStyleBackColor = true;
            // 
            // rbtCola
            // 
            this.rbtCola.AutoSize = true;
            this.rbtCola.Location = new System.Drawing.Point(143, 163);
            this.rbtCola.Name = "rbtCola";
            this.rbtCola.Size = new System.Drawing.Size(49, 19);
            this.rbtCola.TabIndex = 4;
            this.rbtCola.TabStop = true;
            this.rbtCola.Text = "Cola";
            this.rbtCola.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(50, 335);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click_1);
            // 
            // btnVacia
            // 
            this.btnVacia.Location = new System.Drawing.Point(131, 335);
            this.btnVacia.Name = "btnVacia";
            this.btnVacia.Size = new System.Drawing.Size(75, 23);
            this.btnVacia.TabIndex = 6;
            this.btnVacia.Text = "¿Vacia?";
            this.btnVacia.UseVisualStyleBackColor = true;
            this.btnVacia.Click += new System.EventHandler(this.btnVacia_Click_1);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(212, 335);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 7;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click_1);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 15;
            this.lstCola.Location = new System.Drawing.Point(202, 89);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(93, 184);
            this.lstCola.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnVacia);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.rbtCola);
            this.Controls.Add(this.rbtPila);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtElemento);
            this.Name = "Form1";
            this.Text = "Pilas-Colas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtElemento;
        private Button button1;
        private ListBox lstPila;
        private RadioButton rbtPila;
        private RadioButton rbtCola;
        private Button btnPrimero;
        private Button btnVacia;
        private Button btnExtraer;
        private ListBox lstCola;
    }
}