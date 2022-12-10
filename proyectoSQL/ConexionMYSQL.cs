﻿using MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSQL
{
    internal class ConexionMYSQL
    {
        public static MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "Biblioteca";
        static string ususario = "root";
        static string password = "Yayo1234";
        static string puerto = "3306";

        static String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id =" + ususario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        private static void conectar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conecto correctamente la base de datos");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos de PostgreSQL, error:" + e.ToString());
            }




        }
        public static DataTable ejecutaConsultaSelect(string consulta)
        {
            conectar();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public static void ejecutaConsulta(string consulta)
        {
            conectar();
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
