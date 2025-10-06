using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataCliente
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;

        public void Insertar(string nombreCompleto, DateTime fechaNacimiento, string RFC, string CURP, string correo,
            string celular, string domicilio, int no, string codigoPostal, string pais, string estado, string ciudad)
        {
            try
            {
                // Abrir conexión
                comandoSQL.Connection = connSQL.AbrirConexion();
                // Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_InsertarClientes";
                // Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros

                comandoSQL.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                comandoSQL.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comandoSQL.Parameters.AddWithValue("@RFC", RFC);
                comandoSQL.Parameters.AddWithValue("@CURP", CURP);
                comandoSQL.Parameters.AddWithValue("@correo", correo);
                comandoSQL.Parameters.AddWithValue("@celular", celular);
                comandoSQL.Parameters.AddWithValue("@domicilio", domicilio);
                comandoSQL.Parameters.AddWithValue("@no", no);
                comandoSQL.Parameters.AddWithValue("@codigoPostal", codigoPostal);
                comandoSQL.Parameters.AddWithValue("@pais", pais);
                comandoSQL.Parameters.AddWithValue("@estado", estado);
                comandoSQL.Parameters.AddWithValue("@ciudad", ciudad);

                // Ejecutar query
                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                // Limpiar parámetros y cerrar conexión
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataCliente:Insertar" + ex.Message);
            }
        }

        public void Actualizar(int idCliente, string nombreCompleto, DateTime fechaNacimiento, string RFC, string CURP, string correo,
            string celular, string domicilio, int no, string codigoPostal, string pais, string estado, string ciudad)
        {
            try
            {
                // Abrir conexión
                comandoSQL.Connection = connSQL.AbrirConexion();
                // Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_ActualizarClientes";
                // Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros

                comandoSQL.Parameters.AddWithValue("idCliente", idCliente);
                comandoSQL.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                comandoSQL.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comandoSQL.Parameters.AddWithValue("@RFC", RFC);
                comandoSQL.Parameters.AddWithValue("@CURP", CURP);
                comandoSQL.Parameters.AddWithValue("@Correo", correo);
                comandoSQL.Parameters.AddWithValue("@Celular", celular);
                comandoSQL.Parameters.AddWithValue("@Domicilio", domicilio);
                comandoSQL.Parameters.AddWithValue("@No", no);
                comandoSQL.Parameters.AddWithValue("@CodigoPostal", codigoPostal);
                comandoSQL.Parameters.AddWithValue("@Pais", pais);
                comandoSQL.Parameters.AddWithValue("@Estado", estado);
                comandoSQL.Parameters.AddWithValue("@Ciudad", ciudad);

                // Ejecutar query
                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                // Limpiar parámetros y cerrar conexión
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataCliente:Actualizar" + ex.Message);
            }
        }

        //public void Buscar(int idCliente)
        //{
        //    try
        //    {
        //        // Abrir conexión
        //        comandoSQL.Connection = connSQL.AbrirConexion();
        //        // Enviar nombre de recursos SQL
        //        comandoSQL.CommandText = "SELECT * FROM Clientes WHERE idCliente = @idCliente";
        //        // Tipo de comando
        //        comandoSQL.CommandType = CommandType.Text;
        //        // Agregar parámetros
        //        comandoSQL.Parameters.AddWithValue("@idCliente", idCliente);
        //        // Ejecutar query
        //        SqlDataReader result = comandoSQL.ExecuteReader();

        //        if (result.Read())
        //        {
        //            // Aquí puedes asignar los valores a las propiedades de la clase o hacer algo con los datos
        //        }
        //        else
        //        {
        //            renglonesAfectados = 0;
        //        }
        //        // Limpiar parámetros y cerrar conexión
        //        comandoSQL.Parameters.Clear();
        //        connSQL.CerrarConexion();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("DataCliente:Buscar" + ex.Message);
        //    }
        //}
    }
}

