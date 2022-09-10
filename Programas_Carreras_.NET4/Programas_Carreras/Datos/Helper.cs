using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Programas_Carreras.Datos
{
    class Helper
    {
        private SqlConnection Conexion;
        private string resultado = "Se ejecutó con éxito la carga de datos";
        public Helper()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = Properties.Resources.ConnectionString;
        }
        public DataTable EjecutarSPConsulta(string nombreSP)
        {
            DataTable table = new DataTable();
            try
            {
                Conexion.Open();
                SqlCommand Comando = new SqlCommand(nombreSP);
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                table.Load(Comando.ExecuteReader());
                Conexion.Close();
                return table;
            }
            catch (SqlException ex)
            {
                this.resultado = "Ocurrió un error a nivel datos: " + ex.Message + " Los cambios no serán almacenados.";
                return table;
            }
        }

        public int ObtenerUltimoId()
        {
            try
            {
                Conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_CONSULTAR_ULTIMA_CARRERA";
                SqlParameter param = new SqlParameter("@NewId", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.ExecuteNonQuery();
                int ultimoId = param.Value.GetType()==typeof(int) ? (int)param.Value :  1 ;
                return ultimoId;

            }
            catch (SqlException ex)
            {
                this.resultado = "Ocurrió un error a nivel datos: " + ex.Message + " Los cambios no serán almacenados.";
                return 0;
            }
        }

        public string EjecutarTransaccion(List<string> storedProcedures, List<SqlCommand> Params)
        {

            //Este método pérmite pasar 2 o más Procedimientos almacenados y 2 o más listas con sus respectivos parámetros. Es importante que se pasen en el orden correcto.
            if (Conexion.State == (System.Data.ConnectionState)1)
            {
                Conexion.Close();
            }
            Conexion.Open();

            SqlTransaction t = null;
            t = Conexion.BeginTransaction();
            for (int sp = 0; sp < storedProcedures.Count(); sp++)
            {
                try
                {
                    SqlCommand Comando = new SqlCommand(storedProcedures[sp], Conexion, t);
                    Comando = Params[sp];
                    Comando.CommandText = storedProcedures[sp];
                    Comando.Connection = Conexion;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Transaction = t;
                    Comando.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    resultado = "Ocurrió un error a nivel datos: " + ex.Message + " Los cambios no serán almacenados.";
                }

                //a esto meterlo entre transacciones

            }
            t.Commit();
            Conexion.Close();

            return resultado;
        }
    }
}
