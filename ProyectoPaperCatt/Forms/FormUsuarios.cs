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
using Microsoft.Identity.Client.NativeInterop;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.IdentityModel.Tokens;


namespace ProyectoPaperCatt.Forms
{
    public partial class FormUsuarios : Form
    {

        Usuarios mUsuarios = new Usuarios();

        public FormUsuarios()
        {
            InitializeComponent();
        }



        //private void ClientsService_DataUpdated(object sender, Dictionary<string, object> e)
        //{

        //    Dictionary<string, object> rowData = e;

        //    txtFechaUltAcceso.Text = rowData.ContainsKey("fechaUltimoAcceso") ? rowData["fechaUltimoAcceso"].ToString() : "";
        //    txtId.Text = rowData.ContainsKey("idUsuario") ? rowData["idUsuario"].ToString() : "";
        //    txtUsuario.Text = rowData.ContainsKey("userName") ? rowData["userName"].ToString() : "";
        //    txtPassword.Text = rowData.ContainsKey("password") ? rowData["password"].ToString() : "";
        //    txtIdPerfil.Text = rowData.ContainsKey("idPerfil") ? rowData["idPerfil"].ToString() : "";
        //    string status = rowData.ContainsKey("second_last_name") ? rowData["second_last_name"].ToString() : "";
        //    if (status == "1")
        //    {
        //        cbStatus.Text = "Activo";
        //    }
        //    else
        //    {
        //        cbStatus.Text = "Inactivo";
        //    }
        //    txtNombre.Text = rowData.ContainsKey("nombre") ? rowData["nombre"].ToString() : "";
        //    txtApellidoP.Text = rowData.ContainsKey("apellidoP") ? rowData["apellidoP"].ToString() : "";
        //    txtApellidoM.Text = rowData.ContainsKey("apellidoM") ? rowData["apellidoM"].ToString() : "";
        //    txtCorreo.Text = rowData.ContainsKey("correo") ? rowData["correo"].ToString() : "";
        //    txtTel.Text = rowData.ContainsKey("telefono") ? rowData["telefono"].ToString() : "";
        //}



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Recolectar datos
            int idPerfil, estatus, Clave;
            System.String nombre, apellidoP, apellidoM, correo, telefono, userName, password;
            DateTime fechaRegistro, fechaUltAcces;

            nombre = txtNombre.Text;
            apellidoP = txtApellidoP.Text;
            apellidoM = txtApellidoM.Text;
            correo = txtCorreo.Text;
            telefono = txtTel.Text;
            userName = txtUsuario.Text;
            password = txtPassword.Text;
            fechaRegistro = DateTime.Today;
            fechaUltAcces = DateTime.Today;
            estatus = cbStatus.Checked ? 1 : 0;
            idPerfil = Convert.ToInt32(txtIdPerfil.Text);




            //Validación
            if (Utilerias.fnValidaVacio(nombre) == false)
                MessageBox.Show("Es obligatorio ingresar el nombre de usuario");
            else if (!Utilerias.fnValidaVacio(apellidoP))
                MessageBox.Show("Es obligatorio ingresar el apellido Paterno del usuario");
            else if (!Utilerias.fnValidaVacio(apellidoM))
                MessageBox.Show("Es obligatorio ingresar el apellido Materno del usuario");
            else if (!Utilerias.fnValidaVacio(correo))
                MessageBox.Show("Es obligatorio ingresar el correo del usuario");
            else if (!Utilerias.fnValidaVacio(telefono))
                MessageBox.Show("Es obligatorio ingresar el telefono del usuario");
            else if (!Utilerias.fnValidaVacio(userName))
                MessageBox.Show("Es obligatorio ingresar el nombre de usuario");
            else if (!Utilerias.fnValidaVacio(password))
                MessageBox.Show("Es obligatorio ingresar la contraseña");
            else
            {
                //Datos a guardar
                mUsuarios.setNombre(nombre);
                mUsuarios.setApellidoP(apellidoP);
                mUsuarios.setApellidoM(apellidoM);
                mUsuarios.setCorreo(correo);
                mUsuarios.setTelefono(telefono);
                mUsuarios.setUserN(userName);
                mUsuarios.setPass(password);
                mUsuarios.setFechaReg(fechaRegistro);
                mUsuarios.setFechaUltAcceso(fechaUltAcces);
                mUsuarios.setEstatus(estatus);
                mUsuarios.setperfil(idPerfil);



                if (mUsuarios.fnGuardar())
                    MessageBox.Show("Usuario grabado con exito!");
                else
                    MessageBox.Show("No es posible guardar datos \n consulte a su administrador");

                //Limpiar la pantalla para todos los controles, segun la propiedad
                
            }

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatus.Checked)
            {
                cbStatus.Text = "Activo";
            }
            else
            {
                cbStatus.Text = "Inactivo";
            }

        }

        SqlConnection conexion = new SqlConnection("server=KOCCO\\ROBERTO_H_R; database=PaperCatt; integrated security=true");

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FormBuscar search = new FormBuscar();
            search.setVar("Usuarios");
            AddOwnedForm(search);

            search.ShowDialog();


            //conexion.Open();

            //string consulta = "select * from Usuarios where idUsuario = " + txtId.Text + "";

            //SqlCommand comando = new SqlCommand(consulta, conexion);
            //SqlDataReader reader;
            //reader = comando.ExecuteReader();

            //if (reader.Read())
            //{
            //    txtUsuario.Text = reader["userName"].ToString();
            //    txtPassword.Text = reader["password"].ToString();
            //    txtIdPerfil.Text = reader["idPerfil"].ToString();
            //    txtFechaUltAcceso.Text = reader["fechaUltimoAcceso"].ToString();
            //    txtNombre.Text = reader["nombre"].ToString();
            //    txtApellidoP.Text = reader["apellidoP"].ToString();
            //    txtApellidoM.Text = reader["apellidoM"].ToString();
            //    txtCorreo.Text = reader["correo"].ToString();
            //    txtTel.Text = reader["telefono"].ToString();

            //    System.String es = reader["isActivo"].ToString();
            //    if (es == "1")
            //    {
            //        lblEstatus.Text = "Activo";
            //    }
            //    else
            //    {
            //        lblEstatus.Text = "Inactivo";
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("No se encontro a ese Usuario");
            //}


            //conexion.Close();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            txtIdPerfil.Enabled = true;
            cbStatus.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidoP.Enabled = true;
            txtApellidoM.Enabled = true;
            txtCorreo.Enabled = true;
            txtTel.Enabled = true;
            lblEstatus.Enabled = true;

            txtId.Text = " ";
            txtUsuario.Text = " ";
            txtPassword.Text = " ";
            txtIdPerfil.Text = " ";
            txtFechaUltAcceso.Text = " ";
            txtNombre.Text = " ";
            txtApellidoP.Text = " ";
            txtApellidoM.Text = " ";
            txtCorreo.Text = " ";
            txtTel.Text = " ";
            lblEstatus.Text = "-";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            if (!(txtId.Text.IsNullOrEmpty() || txtUsuario.Text.IsNullOrEmpty() || txtUsuario.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty()
                || txtNombre.Text.IsNullOrEmpty() || txtApellidoP.Text.IsNullOrEmpty() || txtApellidoM.Text.IsNullOrEmpty() || txtCorreo.Text.IsNullOrEmpty()
                || txtTel.Text.IsNullOrEmpty() || txtIdPerfil.Text.IsNullOrEmpty()))
            {


                conexion.Open();

                int estatus = cbStatus.Checked ? 1 : 0;
                DateTime fechaRegistro = dtpFechaRegistro.Value;

                string consulta = "UPDATE Usuarios SET userName='" + txtUsuario.Text + "', password='" + txtPassword.Text + "', nombre='" + txtNombre.Text + "', apellidoP='" + txtApellidoP.Text
                    + "', apellidoM='" + txtApellidoM.Text + "', correo='" + txtCorreo.Text + "', telefono='" + txtTel.Text + "', idPerfil=" + txtIdPerfil.Text + ", isActivo=" + estatus
                    + ", fechaRegistro='" + fechaRegistro + "' where idUsuario=" + txtId.Text + " ";



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

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            txtIdPerfil.Enabled = false;
            cbStatus.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidoP.Enabled = false;
            txtApellidoM.Enabled = false;
            txtCorreo.Enabled = false;
            txtTel.Enabled = false;
            lblEstatus.Enabled = false;

            txtId.Text = " ";
            txtUsuario.Text = " ";
            txtPassword.Text = " ";
            txtIdPerfil.Text = " ";
            txtFechaUltAcceso.Text = " ";
            txtNombre.Text = " ";
            txtApellidoP.Text = " ";
            txtApellidoM.Text = " ";
            txtCorreo.Text = " ";
            txtTel.Text = " ";
            lblEstatus.Text = "-";
        }
    }
}
