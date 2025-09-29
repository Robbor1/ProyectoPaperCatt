using BussinesRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DataLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataaLayer;
using Microsoft.Identity.Client;

namespace ProyectoPaperCatt.Forms
{
    public partial class FormConfiguracion : Form
    {

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=KOCCO\\ROBERTO_H_R; Database=PaperCatt; integrated security= true");

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {

            cboxMoneda.DropDownStyle = ComboBoxStyle.DropDownList;

            conexion.Open();

            string consulta = "select * from Configuracion";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader reader;
            reader = comando.ExecuteReader();

            if (reader.Read())
            {
                txtNomEmp.Text = reader["nombreEmp"].ToString();
                txtRfcEmp.Text = reader["rfcEmp"].ToString();
                txtDirEmp.Text = reader["direccionEmp"].ToString();
                txtNomSuc.Text = reader["nombreSucursal"].ToString();
                txtDirSuc.Text = reader["direccionSucursal"].ToString();
                txtCorreo.Text = reader["correo"].ToString();
                txtIVA.Text = reader["TasaIVA"].ToString();
                cboxMoneda.Text = reader["Moneda"].ToString();


            }

            conexion.Close();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
