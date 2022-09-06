using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programas_Carreras
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCarreras = new Formularios.frmCarreras();
            frmCarreras.Show();
        }
    }
}
