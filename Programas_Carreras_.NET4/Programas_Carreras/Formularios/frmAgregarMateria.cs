using Programas_Carreras.Datos;
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
    public partial class frmAgregarMateria : Form
    {
        Helper oDatos;
        public DataTable MateriasCargadas = new DataTable();
        public List<string> materiasExistentes = new List<string>();

        private void frmAgregarMateria_Load(object sender, EventArgs e)
        {
            oDatos = Helper.InstanciarHelper();
        }
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


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMateriaNueva.Text.Equals(String.Empty) || txtMateriaNueva.Text.Length < 6 || txtMateriaNueva.Text.Length > 20)
            {
                MessageBox.Show("Debe indicar un nombre válido de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (materiasExistentes.Contains(txtMateriaNueva.Text))
            {
                MessageBox.Show("La materia '" + txtMateriaNueva.Text + "' ya está cargada en el sistema", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string resultado="";
                try
                {
                    List<string> Procedimientos = new List<string>();
                    List<SqlCommand> Parametros = new List<SqlCommand>();
                    Procedimientos.Add("SP_CARGAR_ASIGNATURA");
                    SqlCommand comando = new SqlCommand();
                    comando.Parameters.AddWithValue("Nombre", txtMateriaNueva.Text);
                    Parametros.Add(comando);
                    resultado = oDatos.EjecutarTransaccion(Procedimientos, Parametros);
                }
                catch (Exception)
                {

                    MessageBox.Show(resultado, "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearMateria_Click(object sender, EventArgs e)
        {
            if (txtMateriaNueva.Text.Equals(String.Empty) || txtMateriaNueva.Text.Length < 6 || txtMateriaNueva.Text.Length > 20)
            {
                MessageBox.Show("Debe indicar un nombre válido de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (materiasExistentes.Contains(txtMateriaNueva.Text))
            {
                MessageBox.Show("La materia '" + txtMateriaNueva.Text + "' ya está cargada en el sistema", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string resultado = "";
                try
                {
                    List<string> Procedimientos = new List<string>();
                    List<SqlCommand> Parametros = new List<SqlCommand>();
                    Procedimientos.Add("SP_CARGAR_ASIGNATURA");
                    SqlCommand comando = new SqlCommand();
                    comando.Parameters.AddWithValue("Nombre", txtMateriaNueva.Text);
                    Parametros.Add(comando);
                    resultado = oDatos.EjecutarTransaccion(Procedimientos, Parametros);
                    MessageBox.Show(resultado, "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resultado = "";
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show(resultado, "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resultado = "";
                }


            }
        }
    }
}
