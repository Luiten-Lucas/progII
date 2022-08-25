using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_17_agosto__2nda_clase_.Entidades;

namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    public partial class frmAgregarMateria : Form
    {
        public List<string> materiasExistentes = new List<string>();
        public frmAgregarMateria(List<string> list)
        {
            InitializeComponent();
            materiasExistentes = list;
        }
        
        private void frmAgregarMateria_Load(object sender, EventArgs e, DataTable MateriasCargadas)
        {
            var materiasExistentes = new DataTable();
            materiasExistentes = MateriasCargadas;
        }

        private void frmAgregarMateria_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMateriaNueva.Text.Equals(String.Empty) || txtMateriaNueva.Text.Length < 6 || txtMateriaNueva.Text.Length > 20)
            {
                MessageBox.Show("Debe indicar un nombre válido de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (materiasExistentes.Contains(txtMateriaNueva.Text))
            {
                MessageBox.Show("La materia '"+txtMateriaNueva.Text+"' ya está cargada en el sistema", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } else
            {
                SqlConnection conexion = new();
                conexion.ConnectionString = @"Data Source=DESKTOP-AR2T61C;Initial Catalog=planesCarrera;Integrated Security=True";
                conexion.Open();
                SqlCommand comando = new();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_CARGAR_ASIGNATURA";
                comando.Parameters.AddWithValue("Nombre", txtMateriaNueva.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                var nomMateria = txtMateriaNueva.Text;
                txtMateriaNueva.Text = "";
                this.Close();
                MessageBox.Show("La materia '" + nomMateria + "' fue cargada con éxito", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
