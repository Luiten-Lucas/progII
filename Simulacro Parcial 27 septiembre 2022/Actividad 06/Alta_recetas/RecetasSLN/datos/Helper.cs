using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.datos
{
    internal class Helper
    {
        private SqlConnection Conexion;
        private string resultado = "Se ejecutó con éxito la carga de datos";
        public Helper()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = @"Data Source=DESKTOP-AR2T61C;Initial Catalog=recetas_db;Integrated Security=True";
        }

        public int ObtenerUltimoId()
        {
            try
            {
                Conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_PROXIMO_ID";
                SqlParameter param = new SqlParameter("@Next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();
                int proxId = param.Value.GetType() == typeof(int) ? (int)param.Value : 1;
                Conexion.Close();
                return proxId;

            }
            catch (SqlException ex)
            {
                this.resultado = "Ocurrió un error a nivel datos: " + ex.Message + " No se pudo obtener el último id de receta.";
                Conexion.Close();
                return 0;
            }

        }

        public DataTable ConsultarIngredientes()
        {
            DataTable table = new DataTable();
            try
            {
                Conexion.Open();
                SqlCommand Comando = new SqlCommand("SP_CONSULTAR_INGREDIENTES");
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                table.Load(Comando.ExecuteReader());
                Conexion.Close();
                return table;
            }
            catch (SqlException ex)
            {
                this.resultado = "Ocurrió un error a nivel datos: " + ex.Message + " No se pudieron obtener los ingredientes disponibles.";
                return table;
            }
        }

        public DataTable ConsultarTiposReceta()
        {
            DataTable table = new DataTable();
            try
            {
                Conexion.Open();
                SqlCommand Comando = new SqlCommand("SP_CONSULTAR_TIPOS_RECETA");
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                table.Load(Comando.ExecuteReader());
                Conexion.Close();
                return table;
            }
            catch (SqlException ex)
            {
                this.resultado = "Ocurrió un error a nivel datos: " + ex.Message + " No se pudieron obtener los tipos de receta disponibles.";
                return table;
            }
        }

        //public void GuardarReceta(int idReceta, string nombre, string cheff, int tipoReceta, int idIngrediente, int cantidad)
        public void GuardarReceta (List<DetalleReceta> Params,string receta,string cheff, int tipoReceta)
        {
            if (Conexion.State == (System.Data.ConnectionState)1)
            {
                Conexion.Close();
            }
            Conexion.Open();
            SqlTransaction t = null;
            t = Conexion.BeginTransaction();
            try {
                SqlCommand comando = new SqlCommand("SP_INSERTAR_RECETA",Conexion,t);
                comando.CommandType = CommandType.StoredProcedure;
                //SqlParameter tipoReceta = new SqlParameter("@tipo_receta", SqlDbType.Int);
                //SqlParameter nombreReceta = new SqlParameter("@nombre", SqlDbType.VarChar);
                //SqlParameter cheff = new SqlParameter("@cheff", SqlDbType.VarChar);
                comando.Parameters.AddWithValue("@tipo_receta", tipoReceta);
                comando.Parameters.AddWithValue("@nombre", receta);
                comando.Parameters.AddWithValue("@cheff", cheff);
                comando.ExecuteNonQuery();
                try
                {
                    SqlCommand comando2 = new SqlCommand("SP_INSERTAR_DETALLES", Conexion, t);
                    comando2.CommandType = CommandType.StoredProcedure;
                    foreach (DetalleReceta detalle in Params)
                    {
                        comando2.Parameters.Clear();
                        comando2.Parameters.AddWithValue("@id_receta", detalle.idReceta);
                        comando2.Parameters.AddWithValue("@id_ingrediente", detalle.idIngrediente + 1);
                        comando2.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                        comando2.ExecuteNonQuery();
                    }

                } catch (SqlException exDetalles)
                {
                    MessageBox.Show("Ocurrió un error con la carga de los detalles de la receta. " + exDetalles.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Conexion.Close();
                    return;
                }
                
            }
            catch (SqlException exReceta){
                MessageBox.Show("Ocurrió un error con la carga de la receta. "+ exReceta.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conexion.Close();
                return;
            }
            t.Commit();
            Conexion.Close();
            MessageBox.Show("Se cargó con éxito la receta!.", "Grabación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
