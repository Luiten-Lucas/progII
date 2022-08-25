﻿using System;
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

        public string EjecutarTransaccion(List<string> storedProcedures, List<SqlCommand> Params)
        {
            //Este método pérmite pasar 2 o más Procedimientos almacenados y 2 o más listas con sus respectivos parámetros. Es importante que se pasen en el orden correcto.
            Conexion.Open();
            SqlTransaction t = null;
            t = Conexion.BeginTransaction();
            for (int sp = 0; sp < storedProcedures.Count(); sp++)
            {
                SqlCommand Comando = new SqlCommand(storedProcedures[sp], Conexion, t);
                Comando = Params[sp];
                Comando.CommandText = storedProcedures[sp];
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Transaction = t;
                Comando.ExecuteNonQuery();
                t.Commit();
            }


            return "Mensaje post transacción";
        }
    }
}
