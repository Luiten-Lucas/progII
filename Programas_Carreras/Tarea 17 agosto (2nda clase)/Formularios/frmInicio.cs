using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void crearNuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPrincipal = new Formularios.frmPrincipal();
            frmPrincipal.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumno: Luiten Lucas \nLegajo: 112862\nCurso: 1W3\nAño: 2022", "Acerca de este proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
