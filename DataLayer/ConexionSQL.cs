using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataaLayer
{
    public class ConexionSQL
    {
        SqlConnection conn;
        string nombreServidor = "LAPTOP-IH7H7TUQ\\DAYANA_G_F";
        string nombreBD = "PaperCatt";
        string usuarioBD = "wadmin";
        string passwordBD = "sis123";
        private string connectionString;

        public ConexionSQL()
        {
            try
            {
                //agregar connectionString
                connectionString = $"Server={nombreServidor};Database={nombreBD};User id ={usuarioBD};Password={passwordBD};";
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ConexionSQL: " + ex.Message);
            }
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
