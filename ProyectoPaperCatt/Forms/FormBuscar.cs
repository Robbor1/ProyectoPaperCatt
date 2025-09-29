using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DataLayer;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataaLayer;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoPaperCatt.Forms
{
    public partial class FormBuscar : Form
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        private String valor;

        SqlConnection conexion = new SqlConnection("server=LAPTOP-IH7H7TUQ\\DAYANA_G_F; database=PaperCatt; integrated security=true");

        public FormBuscar()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //generalService = service;
        }

        public void setVar(String v) { this.valor = v; }
        public String getVar() { return valor; }

        private void FormBuscarcs_Load(object sender, EventArgs e)
        {


            if (getVar() == "Usuarios")
            {
                string consulta = "select * from Usuarios";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                guna2DataGridView1.DataSource = dt;

                //DataTable generalTable = generalService.getAll();

                //guna2DataGridView1.DataSource = generalTable;
            }
            else if (getVar() == "Proveedores")
            {
                string consulta = "select * from Proveedores";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            else if (getVar() == "Clientes")
            {
                string consulta = "select * from Clientes";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];

            //    // Extrae los datos de la fila
            //    Dictionary<string, object> rowData = new Dictionary<string, object>();
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        string columnName = this.guna2DataGridView1.Columns[cell.ColumnIndex].HeaderText;
            //        object cellValue = cell.Value;
            //        rowData.Add(columnName, cellValue);
            //    }

            //    // Llama al método processRow en generalService con los valores extraídos
            //    generalService.processRow(rowData);
            //}
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (getVar() == "Usuarios")
            {
                FormUsuarios frmUsuarios = (FormUsuarios)Owner;

                frmUsuarios.txtId.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmUsuarios.txtUsuario.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmUsuarios.txtPassword.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmUsuarios.txtNombre.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmUsuarios.txtApellidoP.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmUsuarios.txtApellidoM.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmUsuarios.txtCorreo.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmUsuarios.txtTel.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
                string cbstatus = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmUsuarios.txtIdPerfil.Text = guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
                if (cbstatus == "1")
                {
                    frmUsuarios.cbStatus.Text = "Activo";
                    frmUsuarios.lblEstatus.Text = "Activo";
                }
                else
                {
                    frmUsuarios.cbStatus.Text = "Inactivo";
                    frmUsuarios.lblEstatus.Text = "Inactivo";
                }
                frmUsuarios.txtFechaUltAcceso.Text = guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();

                this.Close();
            }
            else if (getVar() == "Proveedores")
            {
                FormProveedores frmProveedores = (FormProveedores)Owner;

                frmProveedores.txtId.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmProveedores.txtNomRep.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmProveedores.txtNomEmp.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmProveedores.txtRfc.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmProveedores.txtCurp.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmProveedores.txtCel.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmProveedores.txtCorreo.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmProveedores.txtDom.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
                frmProveedores.txtNo.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmProveedores.txtCodigoP.Text = guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
                frmProveedores.txtPais.Text = guna2DataGridView1.CurrentRow.Cells[10].Value.ToString();
                frmProveedores.txtEstado.Text = guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();
                frmProveedores.txtCiudad.Text = guna2DataGridView1.CurrentRow.Cells[12].Value.ToString();
                this.Close();

            }
            else if (getVar() == "Clientes")
            {
                FormClientes frmClientes = (FormClientes)Owner;

                frmClientes.txtidCliente.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmClientes.txtNombreCompleto.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmClientes.dtpFechaNacimiento.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmClientes.txtRFC.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmClientes.txtCURP.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmClientes.txtCorreo.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmClientes.txtCelular.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmClientes.txtDomicilio.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
                frmClientes.txtNo.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmClientes.txtCodigoPostal.Text = guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
                frmClientes.txtPais.Text = guna2DataGridView1.CurrentRow.Cells[10].Value.ToString();
                frmClientes.txtEstado.Text = guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();
                frmClientes.txtCiudad.Text = guna2DataGridView1.CurrentRow.Cells[12].Value.ToString();
                this.Close();

            }

        }

    }

}
