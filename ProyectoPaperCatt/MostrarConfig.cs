using DataLayer;
using System.Data.SqlClient;

namespace ProyectoPaperCatt
{
    public class MostrarConfig
    {
        private ConexionSQL cn = new ConexionSQL();
        private SqlCommand cmd = new SqlCommand();

        public void MostrarClientes()
        {
            cmd.CommandText = "ST_MOSTRARTABLACONFIG";
        }
    }
}
