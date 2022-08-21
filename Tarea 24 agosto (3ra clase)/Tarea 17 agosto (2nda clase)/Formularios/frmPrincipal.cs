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
using Tarea_17_agosto__2nda_clase_.Entidades;


namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public DataTable MateriasCargadas = new();
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cargarMaterias();
            int[] anios = new int[5] { 1, 2 ,3, 4, 5};
            int[] cuatrimestres = new int[2] { 1, 2 };
            cboAnio.DataSource = anios;
            cboCuatrimestre.DataSource = cuatrimestres;
        }

        private void cargarMaterias()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-AR2T61C;Initial Catalog=planesCarrera;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_OBTENER_ASIGNATURAS";
            DataTable tabla = new();
            tabla.Load(comando.ExecuteReader());
            MateriasCargadas.Load(comando.ExecuteReader());
            cboMateria.DataSource = tabla;
            cboMateria.DisplayMember = "materia";
            cboMateria.ValueMember = "idAsignatura";
            conexion.Close();
            MateriasCargadas = tabla;
        }
        private void enviarPlanes(int anio, int cuatri, string materia,string carrera, string titulo)
        {
            SqlConnection conexion = new();
            conexion.ConnectionString = @"Data Source=DESKTOP-AR2T61C;Initial Catalog=planesCarrera;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_ULTIMA_CARRERA";
            SqlParameter param = new("@NewId", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            int ultimoIdCarrera = Convert.ToInt32(param.Value??1);
            comando.Parameters.Clear();
            comando.CommandText = "SP_CARGAR_CARRERAS";
            comando.Parameters.AddWithValue("carrera", carrera);
            comando.Parameters.AddWithValue("titulo", titulo);
            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandText = "SP_CARGAR_PLANES";
            comando.Parameters.AddWithValue("anio", anio);
            comando.Parameters.AddWithValue("cuatrimestre", cuatri);
            comando.Parameters.AddWithValue("materia", materia);
            comando.Parameters.AddWithValue("carrera", ultimoIdCarrera);
            comando.ExecuteNonQuery();
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
            foreach(DataGridViewRow row in dgvPlan.Rows)
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
        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlan.CurrentCell.ColumnIndex == 4)
            {
                //dgvPlan.Rows[dgvPlan.CurrentCell.RowIndex]
                dgvPlan.Rows.RemoveAt(dgvPlan.CurrentCell.RowIndex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPlan.Rows)
            {

                this.enviarPlanes((int)row.Cells[0].Value, (int)row.Cells[1].Value, (string)row.Cells[2].Value, txtCarrera.Text, txtTitulo.Text);
            }   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Está seguro de cancelar la carga de datos actual?", "Cancelar carga", MessageBoxButtons.YesNo);
            if(confirmacion == DialogResult.Yes)
            {
                dgvPlan.Rows.Clear();
                txtCarrera.Text = "";
                txtTitulo.Text = "";
            }
            else { return; }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var consulta = new formularioConsulta();
            consulta.Show();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            
            string[] Materias = MateriasCargadas.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            var frmMaterias = new Formularios.frmAgregarMateria(Materias.ToList());
            frmMaterias.Show();
            var es = Materias.ToList();
            frmMaterias.materiasExistentes = Materias.ToList();
        }
    }
}
