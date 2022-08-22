using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Carpinteria1W3.Datos
{
    class AyudanteDB
    {
       private SqlConnection Conexion;

        public AyudanteDB()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = Properties.Resources.CadenaConexionCasa;
        }
        public DataTable EjecutarSPConsulta(string nombreSP) {
            DataTable table = new DataTable();
            Conexion.Open();
            SqlCommand Comando = new SqlCommand(nombreSP);
            Comando.CommandType = CommandType.StoredProcedure;
            table.Load(Comando.ExecuteReader());
            Conexion.Close();
            return table;
        } 
    }
}
