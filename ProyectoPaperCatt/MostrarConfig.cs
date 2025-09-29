using DataaLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
