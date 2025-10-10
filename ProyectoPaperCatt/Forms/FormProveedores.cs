using DataLayer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPaperCatt.Forms
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LAPTOP-IH7H7TUQ\\DAYANA_G_F; database=PaperCatt; integrated security=true");

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(txtNomRep.Text.IsNullOrEmpty() || txtNomEmp.Text.IsNullOrEmpty() || txtRfc.Text.IsNullOrEmpty() || txtCurp.Text.IsNullOrEmpty() ||
                txtCel.Text.IsNullOrEmpty() || txtCorreo.Text.IsNullOrEmpty() || txtDom.Text.IsNullOrEmpty() || txtNo.Text.IsNullOrEmpty() ||
                txtCodigoP.Text.IsNullOrEmpty() || txtPais.Text.IsNullOrEmpty() || txtEstado.Text.IsNullOrEmpty() || txtCiudad.Text.IsNullOrEmpty()))
            {


                conexion.Open();

                String consulta = "insert into Proveedores values ('" + txtNomRep.Text + "', '" + txtNomEmp.Text + "', '" + txtRfc.Text + "', '" + txtCurp.Text
                    + "', '" + txtCel.Text + "', '" + txtCorreo.Text + "', '" + txtDom.Text + "', " + txtNo.Text + ", '" + txtCodigoP.Text + "', '" + txtPais.Text
                    + "', '" + txtEstado.Text + "', '" + txtCiudad.Text + "')";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant > 0)
                {
                    MessageBox.Show("Se ha Agregado con éxito!");
                }
                else
                {
                    MessageBox.Show("Error. No fue posible Agregar los datos.");
                }


                conexion.Close();

            }
            else
            {
                MessageBox.Show("Llena los campos vacíos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomRep.Text = " ";
            txtNomEmp.Text = " ";
            txtRfc.Text = " ";
            txtCurp.Text = " ";
            txtCel.Text = " ";
            txtCorreo.Text = " ";
            txtDom.Text = " ";
            txtNo.Text = " ";
            txtCodigoP.Text = " ";
            txtPais.Text = " ";
            txtEstado.Text = " ";
            txtCiudad.Text = " ";
            txtId.Text = " ";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!(txtNomRep.Text.IsNullOrEmpty() || txtNomEmp.Text.IsNullOrEmpty() || txtRfc.Text.IsNullOrEmpty() || txtCurp.Text.IsNullOrEmpty() ||
                txtCel.Text.IsNullOrEmpty() || txtCorreo.Text.IsNullOrEmpty() || txtDom.Text.IsNullOrEmpty() || txtNo.Text.IsNullOrEmpty() ||
                txtCodigoP.Text.IsNullOrEmpty() || txtPais.Text.IsNullOrEmpty() || txtEstado.Text.IsNullOrEmpty() || txtCiudad.Text.IsNullOrEmpty()))
            {


                conexion.Open();

                string consulta = "UPDATE Proveedores SET NombreRepresentante='" + txtNomRep.Text + "', NombreEmpresa='" + txtNomEmp.Text + "', RFC='" + txtRfc.Text + "', CURP='" + txtCurp.Text
                    + "', celular='" + txtCel.Text + "', correo='" + txtCorreo.Text + "', domicilio='" + txtDom.Text + "', no=" + txtNo.Text + ", codigoPostal='" + txtCodigoP.Text + "', pais='" + txtPais.Text
                    + "', estado='" + txtEstado.Text + "', ciudad='" + txtCiudad.Text + "' where idProveedor=" + txtId.Text + " ";



                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                if (cant > 0)
                {
                    MessageBox.Show("Actualizado con éxito!");
                }
                else
                {
                    MessageBox.Show("No fue posible actualizar.");
                }
                conexion.Close();

            }
            else
            {
                MessageBox.Show("LLena los campos vacíos.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FormBuscar search = new FormBuscar();
            search.setVar("Proveedores");
            AddOwnedForm(search);

            search.ShowDialog();


            //if (!txtId.Text.IsNullOrEmpty())
            //{


            //conexion.Open();

            //string consulta = "select * from Proveedores where idProveedor = " + txtId.Text + "";

            //SqlCommand comando = new SqlCommand(consulta, conexion);
            //SqlDataReader reader;
            //reader = comando.ExecuteReader();

            //if (reader.Read())
            //{
            //    txtNomRep.Text = reader["NombreRepresentante"].ToString();
            //    txtNomEmp.Text = reader["NombreEmpresa"].ToString();
            //    txtRfc.Text = reader["RFC"].ToString();
            //    txtCurp.Text = reader["CURP"].ToString();
            //    txtCel.Text = reader["celular"].ToString();
            //    txtCorreo.Text = reader["correo"].ToString();
            //    txtDom.Text = reader["domicilio"].ToString();
            //    txtNo.Text = reader["no"].ToString();
            //    txtCodigoP.Text = reader["codigoPostal"].ToString();
            //    txtPais.Text = reader["pais"].ToString();
            //    txtEstado.Text = reader["estado"].ToString();
            //    txtCiudad.Text = reader["ciudad"].ToString();

            //}
            //else
            //{
            //    MessageBox.Show("No se encontro a ese Usuario");
            //}


            //conexion.Close();


            //} else
            //{
            //    MessageBox.Show("Ingresa el Id del proveedor.");
            //}
        }
    }
}
