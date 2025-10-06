using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataUsuario : IConnection
    {
        

        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;
        public String NombreDeUsuario = "";
        public String username = "";
        public void Insertar(string username, string password, string nombre,
        string apellidoP, string apellidoM, string correo, string telefono, int isActivo, int idPerfil,
        DateTime fechaRegistro, DateTime fechaUltimoAcceso)
        {
            try
            {
                //abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_InsertarUsuario";
                //Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //agregar parametros
                comandoSQL.Parameters.AddWithValue("@userName", username);
                comandoSQL.Parameters.AddWithValue("@password", password);
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@apellidoP", apellidoP);
                comandoSQL.Parameters.AddWithValue("@apellidoM", apellidoM);
                comandoSQL.Parameters.AddWithValue("@correo", correo);
                comandoSQL.Parameters.AddWithValue("@telefono", telefono);
                comandoSQL.Parameters.AddWithValue("@isActivo", isActivo);
                comandoSQL.Parameters.AddWithValue("@idPerfil", idPerfil);
                comandoSQL.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                comandoSQL.Parameters.AddWithValue("@fechaUltimoAcceso", fechaUltimoAcceso);
                //Ejecutar query
                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                //comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //Cerrar conexion
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuario:Insertar" + ex.Message);
            }
        }
        public void ValidaLogin(string UserName, string password)
        {
            try
            {
                Console.WriteLine($"Intentando login con UserName: '{UserName}', Password: '{password}'");
                comandoSQL.Connection = connSQL.AbrirConexion();
                if (comandoSQL.Connection == null)
                {
                    Console.WriteLine("No se pudo abrir la conexión a la base de datos.");
                    renglonesAfectados = 0;
                    return;
                }
                comandoSQL.CommandText = "proc_ValidaUsuario";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.AddWithValue("@usuario", UserName);
                comandoSQL.Parameters.AddWithValue("@pwd", password);
                SqlDataReader result = comandoSQL.ExecuteReader();
                if (result.Read())
                {
                    renglonesAfectados = 1;
                    username = result["UserName"].ToString();
                    NombreDeUsuario = result["Nombre"].ToString();
                    Console.WriteLine($"Login exitoso. UserName: '{username}', Nombre: '{NombreDeUsuario}'");
                }
                else
                {
                    renglonesAfectados = 0;
                    Console.WriteLine("Login fallido: No se encontró usuario con esos datos.");
                }
                result.Close();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuario:Autenticar " + ex.ToString());
            }
        }



        public DataTable getAll()
        {
            DataTable productsTable = new DataTable();

            try
            {
                comandoSQL.Connection = connSQL.AbrirConexion();

                comandoSQL.CommandText = "proc_getAll_Usuarios";

                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = comandoSQL.ExecuteReader())
                {
                    productsTable.Load(reader);
                }




                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();

            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return productsTable;
        }

        public DataTable filter(string value)
        {
            DataTable usersTable = new DataTable();
            try
            {
                comandoSQL.Connection = connSQL.AbrirConexion();
                comandoSQL.CommandText = "proc_BuscarUsuario";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.AddWithValue("@valor", value); // Buscar por nombre o UserName

                using (SqlDataReader reader = comandoSQL.ExecuteReader())
                {
                    usersTable.Load(reader);
                }

                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return usersTable;
        }

        public void processRow(Dictionary<string, object> rowData)
        {
            throw new NotImplementedException();
        }
    }
}
