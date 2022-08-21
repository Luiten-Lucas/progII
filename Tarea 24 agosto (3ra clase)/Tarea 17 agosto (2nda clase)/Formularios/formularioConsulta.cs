using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tarea_17_agosto__2nda_clase_.Formularios
{
    //Alumno Luiten Lucas, 1W3 Legajo 112862
    public partial class formularioConsulta : Form
    {
        public formularioConsulta()
        {
            InitializeComponent();
        }

        DataSet resultados = new DataSet();
        DataView miFiltro;

        public void leer_datos(string sp, ref DataSet dstPrincipal, string tabla)
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = @"Data Source=DESKTOP-AR2T61C;Initial Catalog=planesCarrera;Integrated Security=True";
                SqlCommand comando = new SqlCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
                DataTable table = new DataTable();
                table.Load(comando.ExecuteReader());
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dstPrincipal, tabla);
                adapter.Dispose();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void formularioConsulta_Load(object sender, EventArgs e)
        {
            this.leer_datos("sp_consultar_carreras", ref resultados, "Carreras");
            this.miFiltro = ((DataTable)resultados.Tables["Carreras"]).DefaultView;

            this.dgvConsultas.DataSource = miFiltro;
        }


        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_filtro = this.txtBusqueda.Text.Split(' ');

            foreach (string palabra in palabras_filtro)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Carrera LIKE '%" + palabra + "%' OR Título LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += " AND (Carrera LIKE '%" + palabra + "%' OR Título LIKE '%" + palabra + "%')";
                }
            }
            this.miFiltro.RowFilter = salida_datos;
        }
    }
}