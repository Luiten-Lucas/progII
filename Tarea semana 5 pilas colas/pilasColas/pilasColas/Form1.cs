using pilasColas.Clases;
using pilasColas.Interfaces;

namespace pilasColas
{
    public partial class Form1 : Form
    {
        private Pila pila;
        private Cola cola;
        public Form1()
        {
            InitializeComponent();
            pila = new Pila(20);
            cola = new Cola();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtElemento.Text))
            {
                object elemento = txtElemento.Text;
                if (this.rbtPila.Checked)
                {
                    if (pila.añadir(elemento))
                    {
                        lstPila.Items.Add(elemento);
                        MessageBox.Show("Elemento Añadido a la pila", "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lista llena!", "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    if (cola.añadir(elemento))
                    {
                        lstCola.Items.Add(elemento);
                        MessageBox.Show("Elemento Añadido a la cola", "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cola llena!", "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            if (this.rbtPila.Checked)
            {
                if (!pila.estaVacia())
                    MessageBox.Show("Primer elemento en pila: " + pila.primero(), "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                if (!cola.estaVacia())
                    MessageBox.Show("Primer elemento en cola: " + cola.primero(), "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVacia_Click_1(object sender, EventArgs e)
        {
            if (this.rbtPila.Checked){
                string mensaje = pila.estaVacia() ? "Pila vacía" : "Pila con elementos";
                MessageBox.Show(mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                string mensaje = cola.estaVacia() ? "Cola vacía" : "Cola con elementos";
                MessageBox.Show(mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExtraer_Click_1(object sender, EventArgs e)
        {
            if (this.rbtPila.Checked) {
                object elemento = pila.extraer();
                lstPila.Items.Remove(elemento);
                if (pila.estaVacia()){
                    txtElemento.Clear();
                }
            } else {
                object elemento = cola.extraer();
                lstCola.Items.Remove(elemento);
                if (cola.estaVacia())
                {
                    txtElemento.Clear();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.rbtPila.Select();
        }
    }
}