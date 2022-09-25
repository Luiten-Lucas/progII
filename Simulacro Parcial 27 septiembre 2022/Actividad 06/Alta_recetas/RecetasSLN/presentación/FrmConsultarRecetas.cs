using RecetasSLN.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        Helper helper = new Helper();
        public FrmConsultarRecetas()
        {
            InitializeComponent();
            MessageBox.Show("Alumno: Luiten Lucas\nComisión: 1W3\nLegajo: 112862\nAño: 2022", "UTN-FRC 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTotal.Text = lblTotal.Text + " " + helper.ObtenerUltimoId().ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmRecetas = new frmAltaRecetas(helper.ObtenerUltimoId(),helper.ConsultarTiposReceta());
            frmRecetas.Show();
        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {

        }
    }
}
