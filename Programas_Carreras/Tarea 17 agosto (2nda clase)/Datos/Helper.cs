using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_17_agosto__2nda_clase_.Datos
{
    internal class Helper
    {
        private SqlConnection Conexion;

        public Helper()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = Properties.Resources.ConnectionString;
        }
        public DataTable EjecutarSPConsulta(string nombreSP)
        {
            DataTable table = new DataTable();
            Conexion.Open();
            SqlCommand Comando = new SqlCommand(nombreSP);
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.StoredProcedure;
            table.Load(Comando.ExecuteReader());
            Conexion.Close();
            return table;
        }
    }
}
