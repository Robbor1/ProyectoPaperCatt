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
                // 1. Verificar si la conexión pudo ser creada
                if (conn == null)
                {
                    Console.WriteLine("ConexionSQL: La conexión (conn) no pudo ser inicializada en el constructor.");
                    return null; // Retorna null si la conexión es inválida
                }

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
                // 2. Verificar si la conexión pudo ser creada
                if (conn == null)
                {
                    return null; // No hay nada que cerrar si es null
                }

                // ... (resto del try/catch)
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
