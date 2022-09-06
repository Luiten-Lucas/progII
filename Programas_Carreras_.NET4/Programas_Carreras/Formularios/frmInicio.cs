using Programas_Carreras.Datos;
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
        public DataTable MateriasCargadas = new DataTable();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Helper oDatos = new Helper();
            DataTable tabla = new DataTable();
            tabla = oDatos.EjecutarSPConsulta("SP_OBTENER_ASIGNATURAS");
            MateriasCargadas = tabla;
        }

        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCarreras = new Formularios.frmCarreras();
            frmCarreras.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] Materias = MateriasCargadas.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            var frmMaterias = new Formularios.frmAgregarMateria(Materias.ToList());
            frmMaterias.Show();
            var es = Materias.ToList();
            frmMaterias.materiasExistentes = Materias.ToList();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumno: Luiten Lucas \nLegajo: 112862\nComisión: 1W3\nAño: 2022", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarProgramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los menues 'Consultar programas', 'Consultar carreras' y 'Consultar materias' estarán disponibles pronto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los menues 'Consultar programas', 'Consultar carreras' y 'Consultar materias' estarán disponibles pronto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los menues 'Consultar programas', 'Consultar carreras' y 'Consultar materias' estarán disponibles pronto.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
