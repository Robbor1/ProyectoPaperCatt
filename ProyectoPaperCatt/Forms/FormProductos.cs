using BussinesRules;
using capaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPaperCatt.Forms
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            // label4.ForeColor = ThemeColor.SecondaryColor;
            // label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            rbKg.Text = "Kg";
            rbLt.Text = "Lt";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtCosto.Enabled = true;
            txtVenta.Enabled = true;
            rbKg.Enabled = true;
            rbLt.Enabled = true;
            cbProveedor.Enabled = true;
            txtStock.Enabled = true;

            txtId.Text = " ";
            txtNombre.Text = " ";
            txtCosto.Text = " ";
            txtVenta.Text = " ";
            cbProveedor.Text = " ";
            txtStock.Text = " ";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtCosto.Enabled = false;
            txtVenta.Enabled = false;
            rbKg.Enabled = false;
            rbLt.Enabled = false;
            cbProveedor.Enabled = false;
            txtStock.Enabled = false;

            txtId.Text = " ";
            txtNombre.Text = " ";
            txtCosto.Text = " ";
            txtVenta.Text = " ";
            cbProveedor.Text = " ";
            txtStock.Text = " ";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar search = new FormBuscar();
            search.setVar("Productos");
            AddOwnedForm(search);

            search.ShowDialog();

            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtCosto.Enabled = false;
            txtVenta.Enabled = false;
            rbKg.Enabled = false;
            rbLt.Enabled = false;
            cbProveedor.Enabled = false;
            txtStock.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos mProductos = new Productos();

            // Recolectar datos
            int idProducto, Stock, Costo, Venta;
            string Nombre, Proveedor, Imagen, UnidadMedida;
            DateTime fechaReg;




            if ((txtId.Enabled = false) || string.IsNullOrEmpty(txtId.Text))
            {





                // Validación
                if (!Utilerias.fnValidaVacio(txtNombre.Text) || (txtNombre.Enabled = false))
                    MessageBox.Show("Es obligatorio ingresar el nombre del producto");
                else if (!Utilerias.fnValidaVacio(txtCosto.Text))
                    MessageBox.Show("Es obligatorio ingresar el costo del producto");
                else if (!Utilerias.fnValidaVacio(txtVenta.Text))
                    MessageBox.Show("Es obligatorio ingresar el costo de venta del producto");
                else if (!rbKg.Checked && !rbLt.Checked)
                    MessageBox.Show("Es obligatorio escoger la unidad de medida del producto");
                else if (!Utilerias.fnValidaVacio(cbProveedor.Text))
                    MessageBox.Show("Es obligatorio ingresar el proveedor del producto");
                else if (!Utilerias.fnValidaVacio(txtStock.Text))
                    MessageBox.Show("Es obligatorio ingresar el stock del producto");
                else
                {
                    bool u = true;
                    string unidad;
                    string prov;

                    if (rbKg.Checked)
                    {
                        unidad = "Kg";
                        rbLt.Text = " ";
                    }
                    else
                    {
                        unidad = "Lt";
                        rbKg.Text = " ";
                        u = false;
                    }

                    prov = Convert.ToString(cbProveedor.SelectedValue);


                    Nombre = txtNombre.Text;
                    Costo = Convert.ToInt32(txtCosto.Text);
                    Venta = Convert.ToInt32(txtVenta.Text);
                    UnidadMedida = unidad;
                    Proveedor = prov;
                    fechaReg = DateTime.Now;
                    Stock = Convert.ToInt32(txtStock.Text);

                    // Datos a guardar

                    mProductos.setNombre(Nombre);
                    mProductos.setCosto(Costo);
                    mProductos.setVenta(Venta);
                    mProductos.setUnidadMedida(UnidadMedida);
                    mProductos.setProveedor(Proveedor);
                    mProductos.setFechaReg(fechaReg);
                    mProductos.setStock (Stock);
                    
                    


                    if (mProductos.fnGuardar())
                    {
                        MessageBox.Show("Producto grabado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("No es posible guardar datos, \n consulte a su administrador");
                    }
                }


            }
            else
            {


                // Validación
                //if (!Utilerias.fnValidaVacio(txtNombreCompleto.Text) || (txtNombreCompleto.Enabled = false))
                //    MessageBox.Show("Es obligatorio ingresar el nombre completo del cliente");
                //else if (!Utilerias.fnValidaVacio(txtRFC.Text))
                //    MessageBox.Show("Es obligatorio ingresar el RFC del cliente");
                //else if (!Utilerias.fnValidaVacio(txtCURP.Text))
                //    MessageBox.Show("Es obligatorio ingresar el CURP del cliente");
                //else if (!Utilerias.fnValidaVacio(txtCorreo.Text))
                //    MessageBox.Show("Es obligatorio ingresar el correo del cliente");
                //else if (!Utilerias.fnValidaVacio(txtCelular.Text))
                //    MessageBox.Show("Es obligatorio ingresar el celular del cliente");
                //else if (!Utilerias.fnValidaVacio(txtDomicilio.Text))
                //    MessageBox.Show("Es obligatorio ingresar el domicilio del cliente");
                //else if (!Utilerias.fnValidaVacio(txtCodigoPostal.Text))
                //    MessageBox.Show("Es obligatorio ingresar el codigo postal del cliente");
                //else if (!Utilerias.fnValidaVacio(txtPais.Text))
                //    MessageBox.Show("Es obligatorio ingresar el pais del cliente");
                //else if (!Utilerias.fnValidaVacio(txtEstado.Text))
                //    MessageBox.Show("Es obligatorio ingresar el estado del cliente");
                //else if (!Utilerias.fnValidaVacio(txtCiudad.Text))
                //    MessageBox.Show("Es obligatorio ingresar la ciudad del cliente");
                //else
                //{
                //    idCliente = Convert.ToInt32(txtidCliente.Text);
                //    nombreCompleto = txtNombreCompleto.Text;
                //    RFC = txtRFC.Text;
                //    CURP = txtCURP.Text;
                //    correo = txtCorreo.Text;
                //    celular = txtCelular.Text;
                //    domicilio = txtDomicilio.Text;
                //    no = Convert.ToInt32(txtNo.Text);
                //    codigoPostal = txtCodigoPostal.Text;
                //    pais = txtPais.Text;
                //    estado = txtEstado.Text;
                //    ciudad = txtCiudad.Text;
                //    fechaNacimiento = dtpFechaNacimiento.Value;

                //    // Datos a guardar
                //    mClientes.setIdCliente(idCliente);
                //    mClientes.setNombreCompleto(nombreCompleto);
                //    mClientes.setFechaNacimiento(fechaNacimiento);
                //    mClientes.setRFC(RFC);
                //    mClientes.setCURP(CURP);
                //    mClientes.setCorreo(correo);
                //    mClientes.setCelular(celular);
                //    mClientes.setDomicilio(domicilio);
                //    mClientes.setNo(no);
                //    mClientes.setCodigoPostal(codigoPostal);
                //    mClientes.setPais(pais);
                //    mClientes.setEstado(estado);
                //    mClientes.setCiudad(ciudad);

                //    if (mClientes.fnActualizar())
                //        MessageBox.Show("Cliente actualizado con éxito!");
                //    else
                //        MessageBox.Show("No es posible actualizar datos, \n consulte a su administrador");
                //}
            }
        }
    }
}
