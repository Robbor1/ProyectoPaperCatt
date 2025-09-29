using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataaLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataProducto
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;

        public void Insertar(string nombre, decimal costo, decimal venta, string unidadMedida,
            string proveedor, DateTime fechaReg, int stock, string img)
        {
            try
            {
                // Abrir conexión
                comandoSQL.Connection = connSQL.AbrirConexion();
                // Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_InsertarProducto";
                // Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros

                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@costo", costo);
                comandoSQL.Parameters.AddWithValue("@venta", venta);
                comandoSQL.Parameters.AddWithValue("@unidadMedida", unidadMedida);
                comandoSQL.Parameters.AddWithValue("@proveedor", proveedor);
                comandoSQL.Parameters.AddWithValue("@fechaRegistro", fechaReg);
                comandoSQL.Parameters.AddWithValue("@stock", stock);
                comandoSQL.Parameters.AddWithValue("@imagen", img);
               

                // Ejecutar query
                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                // Limpiar parámetros y cerrar conexión
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataProducto:Insertar" + ex.Message);
            }
        }


        public void Actualizar(int idProducto, string nombre, decimal costo, decimal venta, string unidadMedida,
            string proveedor, DateTime fechaReg, int stock, string img)
        {
            try
            {
                // Abrir conexión
                comandoSQL.Connection = connSQL.AbrirConexion();
                // Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_ActualizarProducto";
                // Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros

                comandoSQL.Parameters.AddWithValue("@idProducto", idProducto);
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@costo", costo);
                comandoSQL.Parameters.AddWithValue("@venta", venta);
                comandoSQL.Parameters.AddWithValue("@unidadMedida", unidadMedida);
                comandoSQL.Parameters.AddWithValue("@proveedor", proveedor);
                comandoSQL.Parameters.AddWithValue("@fechaRegistro", fechaReg);
                comandoSQL.Parameters.AddWithValue("@stock", stock);
                comandoSQL.Parameters.AddWithValue("@imagen", img);


                // Ejecutar query
                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                // Limpiar parámetros y cerrar conexión
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataProducto:Insertar" + ex.Message);
            }
        }





    }
}
