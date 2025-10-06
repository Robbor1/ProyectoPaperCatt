using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public class ConexionSQL
    {
        private SqlConnection conn;
        private string connectionString;

        public ConexionSQL()
        {
            try
            {
                // Obtener la cadena de conexión desde App.config
                connectionString = ConfigurationManager.ConnectionStrings["PaperCattDB"].ConnectionString;
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ConexionSQL: Error al crear la conexión. Detalle: {ex.Message}");
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
                Console.WriteLine($"ConexionSQL: Error al abrir la conexión. Detalle: {ex.Message}");
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
                Console.WriteLine($"ConexionSQL: Error al cerrar la conexión. Detalle: {ex.Message}");
                return null;
            }
        }
    }
}
