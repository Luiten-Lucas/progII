using Programas_Carreras.Datos;
using Programas_Carreras.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programas_Carreras.Formularios
{
    public partial class frmCarreras : Form
    {
        Helper oDatos;
        public DataTable MateriasCargadas = new DataTable();
        public int ultimoIdCarrera;
        public frmCarreras()

        {
            InitializeComponent();
            oDatos = new Helper();

        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {

            cargarMaterias();
            int[] anios = new int[5] { 1, 2, 3, 4, 5 };
            int[] cuatrimestres = new int[2] { 1, 2 };
            cboAnio.DataSource = anios;
            cboCuatrimestre.DataSource = cuatrimestres;
        }

        private void cargarMaterias()
        {
            DataTable tabla = new DataTable();
            tabla = oDatos.EjecutarSPConsulta("SP_OBTENER_ASIGNATURAS");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = "idAsignatura";
            cboMateria.DisplayMember = "materia";
            MateriasCargadas = tabla;
        }
        //private void enviarPlanes(int anio, int cuatri, string materia, string carrera, string titulo)
        private void enviarPlanes(List<Plan> detalles, string carrera, string titulo)
        {
            List<string> Procedimientos = new List<string>();
            List<SqlCommand> Parametros = new List<SqlCommand>();
            this.ultimoIdCarrera = oDatos.ObtenerUltimoId();
            Procedimientos.Add("SP_CARGAR_CARRERAS");
            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("carrera", carrera);
            comando.Parameters.AddWithValue("titulo", titulo);
            Parametros.Add(comando);
            foreach (var detalle in detalles)
            {
                Procedimientos.Add("SP_CARGAR_PLANES");
                SqlCommand comando2 = new SqlCommand();
                comando2.Parameters.AddWithValue("anio", detalle.Anio);
                comando2.Parameters.AddWithValue("cuatrimestre", detalle.Cuatrimestre);
                comando2.Parameters.AddWithValue("materia", detalle.Materia);
                comando2.Parameters.AddWithValue("carrera", this.ultimoIdCarrera);
                Parametros.Add(comando2);
            }

            string resultado = oDatos.EjecutarTransaccion(Procedimientos, Parametros);
            Limpiar();
            MessageBox.Show(resultado, "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text.Equals(String.Empty) || txtCarrera.Text.Length < 10 || txtCarrera.Text.Length > 20)
            {
                MessageBox.Show("Debe indicar un nombre válido de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtTitulo.Text.Equals(string.Empty) || txtTitulo.Text.Length < 10 || txtTitulo.Text.Length > 25)
            {
                MessageBox.Show("Debe indicar un título válido para la carrera " + txtCarrera.Text, "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow row in dgvPlan.Rows)
            {
                if (row.Cells[2].Value.Equals(cboMateria.Text))
                {
                    MessageBox.Show("Esta materia ya está cargada", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            Carrera carrera = new Carrera(txtCarrera.Text, txtTitulo.Text);

            int year = Convert.ToInt32(cboAnio.Text);
            int cuatri = Convert.ToInt32(cboCuatrimestre.Text);
            string asignatura = cboMateria.Text;
            Plan detalle = new Plan(year, cuatri, asignatura);

            dgvPlan.Rows.Add(new object[] { year, cuatri, asignatura });
            string result = dgvPlan.ToString();
            //dgvPlan.Rows[0].Cells[0]= año
            //dgvPlan.Rows[0].Cells[1] = cuatri
            //dgvPlan.Rows[0].Cells[2] = materia
        }
        //private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvPlan.CurrentCell.ColumnIndex == 5)
        //    {
        //        //dgvPlan.Rows[dgvPlan.CurrentCell.RowIndex]
        //        dgvPlan.Rows.RemoveAt(dgvPlan.CurrentCell.RowIndex);
        //    }
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPlan.Rows)
            {

                //this.enviarPlanes((int)row.Cells[0].Value, (int)row.Cells[1].Value, (string)row.Cells[2].Value, txtCarrera.Text, txtTitulo.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Está seguro de cancelar la carga de datos actual?", "Cancelar carga", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                Limpiar();
            }
            else { return; }
        }

        private void Limpiar()
        {
            dgvPlan.Rows.Clear();
            txtCarrera.Text = "";
            txtTitulo.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtCarrera.Text.Equals(String.Empty) || txtCarrera.Text.Length < 5 || txtCarrera.Text.Length > 50)
            {
                MessageBox.Show("Debe indicar un nombre válido de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtTitulo.Text.Equals(string.Empty) || txtTitulo.Text.Length < 5 || txtTitulo.Text.Length > 50)
            {
                MessageBox.Show("Debe indicar un título válido para la carrera " + txtCarrera.Text, "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(dgvPlan.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPlan.Rows)
                {
                    if (row.Cells[2].Value.Equals(cboMateria.Text))
                    {
                        MessageBox.Show("Esta materia ya está cargada", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }


            Carrera carrera = new Carrera(txtCarrera.Text, txtTitulo.Text);

            int year = Convert.ToInt32(cboAnio.Text);
            int cuatri = Convert.ToInt32(cboCuatrimestre.Text);
            string asignatura = cboMateria.Text;
            Plan detalle = new Plan(year, cuatri, asignatura);

            dgvPlan.Rows.Add(new object[] { year, cuatri, asignatura });
            string result = dgvPlan.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            List<Plan> detalles = new List<Plan>();
            foreach (DataGridViewRow row in dgvPlan.Rows)
            {
                Plan detalle = new Plan((int)row.Cells[0].Value, (int)row.Cells[1].Value, (string)row.Cells[2].Value);
                // 0 es anio, 1 es cuatri, 2 es materia
                detalles.Add(detalle);
            }
                this.enviarPlanes(detalles, txtCarrera.Text, txtTitulo.Text);
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlan.CurrentCell.ColumnIndex == 4)
            {
        //        //dgvPlan.Rows[dgvPlan.CurrentCell.RowIndex]
                dgvPlan.Rows.RemoveAt(dgvPlan.CurrentCell.RowIndex);
           }
        }
    }
}
