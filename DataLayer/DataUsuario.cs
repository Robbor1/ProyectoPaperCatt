using DataaLayer;
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
                //abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_ValidaUsuario";
                //Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //agregar parametros
                comandoSQL.Parameters.AddWithValue("@usuario", UserName);
                comandoSQL.Parameters.AddWithValue("@pwd", password);
                //Ejecutar query
                //renglonesAfectados = comandoSQL.ExecuteNonQuery();
                //comandoSQL.ExecuteNonQuery();
                SqlDataReader result = comandoSQL.ExecuteReader();
                if (result.Read())
                {
                    renglonesAfectados = 1;

                    username = result["userName"].ToString();
                    NombreDeUsuario = result["nombre"].ToString();
                }
                else
                {
                    renglonesAfectados = 0;
                }
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //Cerrar conexion
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuario:Autenticar" + ex.Message);
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

        public DataTable filter(string name)
        {
            DataTable productsTable = new DataTable();

            try
            {
                comandoSQL.Connection = connSQL.AbrirConexion();

                comandoSQL.CommandText = "proc_BuscarUsuario";

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

        public void processRow(Dictionary<string, object> rowData)
        {
            throw new NotImplementedException();
        }
    }
}
