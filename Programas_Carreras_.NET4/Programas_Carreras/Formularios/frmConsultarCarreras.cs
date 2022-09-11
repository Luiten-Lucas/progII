using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programas_Carreras.Formularios
{
    public partial class frmConsultarCarreras : Form
    {
        public frmConsultarCarreras()
        {
            InitializeComponent();
        }

        private void frmConsultarCarreras_Load(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            // TODO: This line of code loads data into the 'dsMaterias.dtCarreras' table. You can move, or remove it, as needed.
            this.dtCarrerasTableAdapter.Fill(this.dsMaterias.dtCarreras);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
