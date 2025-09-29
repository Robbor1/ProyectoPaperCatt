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
    public class DataConfig
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int renglonesAfectados = 0;
        public String NombreDeUsuario = "";
        public String username = "";

        public void Insertar(string nombreEmp, string rfcEmp, string direccionEmp,
        string nombreSucursal, string direccionSucursal, string correo, int TasaIVA, string Moneda)
        {
            try
            {
                //abrir conexion
                comandoSQL.Connection = connSQL.AbrirConexion();
                //Enviar nombre de recursos SQL
                comandoSQL.CommandText = "proc_InsertarConfiguracion";
                //Tipo de comando
                comandoSQL.CommandType = CommandType.StoredProcedure;
                //agregar parametros
                comandoSQL.Parameters.AddWithValue("@nombreEmp", nombreEmp);
                comandoSQL.Parameters.AddWithValue("@rfcEmp", rfcEmp);
                comandoSQL.Parameters.AddWithValue("@direccionEmp", direccionEmp);
                comandoSQL.Parameters.AddWithValue("@nombreSucursal", nombreSucursal);
                comandoSQL.Parameters.AddWithValue("@direccionSucursal", direccionSucursal);
                comandoSQL.Parameters.AddWithValue("@correo", correo);
                comandoSQL.Parameters.AddWithValue("@TasaIVA", TasaIVA);
                comandoSQL.Parameters.AddWithValue("@Moneda", Moneda);
                //Ejecutar query
                renglonesAfectados = comandoSQL.ExecuteNonQuery();
                //comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();
                //Cerrar conexion
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataConfig:Insertar" + ex.Message);
            }
        }




    }
}
