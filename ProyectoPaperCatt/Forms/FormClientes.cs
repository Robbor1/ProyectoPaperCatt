using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesRules;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.IdentityModel.Tokens;

namespace ProyectoPaperCatt.Forms
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clientes mClientes = new Clientes();

            // Recolectar datos
            int no, idCliente;
            string nombreCompleto, RFC, CURP, correo, celular, domicilio, codigoPostal, pais, estado, ciudad;
            DateTime fechaNacimiento;



            //if ((txtidCliente.Enabled = false) || string.IsNullOrEmpty(txtidCliente.Text))
            //{



                // Validación
                if (!Utilerias.fnValidaVacio(txtNombreCompleto.Text) || (txtNombreCompleto.Enabled = false))
                    MessageBox.Show("Es obligatorio ingresar el nombre completo del cliente");
                else if (!Utilerias.fnValidaVacio(txtRFC.Text))
                    MessageBox.Show("Es obligatorio ingresar el RFC del cliente");
                else if (!Utilerias.fnValidaVacio(txtCURP.Text))
                    MessageBox.Show("Es obligatorio ingresar el CURP del cliente");
                else if (!Utilerias.fnValidaVacio(txtCorreo.Text))
                    MessageBox.Show("Es obligatorio ingresar el correo del cliente");
                else if (!Utilerias.fnValidaVacio(txtCelular.Text))
                    MessageBox.Show("Es obligatorio ingresar el celular del cliente");
                else if (!Utilerias.fnValidaVacio(txtDomicilio.Text))
                    MessageBox.Show("Es obligatorio ingresar el domicilio del cliente");
                else if (!Utilerias.fnValidaVacio(txtCodigoPostal.Text))
                    MessageBox.Show("Es obligatorio ingresar el codigo postal del cliente");
                else if (!Utilerias.fnValidaVacio(txtPais.Text))
                    MessageBox.Show("Es obligatorio ingresar el pais del cliente");
                else if (!Utilerias.fnValidaVacio(txtEstado.Text))
                    MessageBox.Show("Es obligatorio ingresar el estado del cliente");
                else if (!Utilerias.fnValidaVacio(txtCiudad.Text))
                    MessageBox.Show("Es obligatorio ingresar la ciudad del cliente");
                else
                {
                    nombreCompleto = txtNombreCompleto.Text;
                    RFC = txtRFC.Text;
                    CURP = txtCURP.Text;
                    correo = txtCorreo.Text;
                    celular = txtCelular.Text;
                    domicilio = txtDomicilio.Text;
                    no = Convert.ToInt32(txtNo.Text);
                    codigoPostal = txtCodigoPostal.Text;
                    pais = txtPais.Text;
                    estado = txtEstado.Text;
                    ciudad = txtCiudad.Text;
                    fechaNacimiento = dtpFechaNacimiento.Value;
                    // Datos a guardar

                    mClientes.setNombreCompleto(nombreCompleto);
                    mClientes.setFechaNacimiento(fechaNacimiento);
                    mClientes.setRFC(RFC);
                    mClientes.setCURP(CURP);
                    mClientes.setCorreo(correo);
                    mClientes.setCelular(celular);
                    mClientes.setDomicilio(domicilio);
                    mClientes.setNo(no);
                    mClientes.setCodigoPostal(codigoPostal);
                    mClientes.setPais(pais);
                    mClientes.setEstado(estado);
                    mClientes.setCiudad(ciudad);


                    if (mClientes.fnGuardar())
                    {
                        MessageBox.Show("Cliente grabado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("No es posible guardar datos, \n consulte a su administrador");
                    }
                }


            //}
            //else
            //{


            //    // Validación
            //    if (!Utilerias.fnValidaVacio(txtNombreCompleto.Text) || (txtNombreCompleto.Enabled = false))
            //        MessageBox.Show("Es obligatorio ingresar el nombre completo del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtRFC.Text))
            //        MessageBox.Show("Es obligatorio ingresar el RFC del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtCURP.Text))
            //        MessageBox.Show("Es obligatorio ingresar el CURP del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtCorreo.Text))
            //        MessageBox.Show("Es obligatorio ingresar el correo del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtCelular.Text))
            //        MessageBox.Show("Es obligatorio ingresar el celular del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtDomicilio.Text))
            //        MessageBox.Show("Es obligatorio ingresar el domicilio del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtCodigoPostal.Text))
            //        MessageBox.Show("Es obligatorio ingresar el codigo postal del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtPais.Text))
            //        MessageBox.Show("Es obligatorio ingresar el pais del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtEstado.Text))
            //        MessageBox.Show("Es obligatorio ingresar el estado del cliente");
            //    else if (!Utilerias.fnValidaVacio(txtCiudad.Text))
            //        MessageBox.Show("Es obligatorio ingresar la ciudad del cliente");
            //    else
            //    {
            //        idCliente = Convert.ToInt32(txtidCliente.Text);
            //        nombreCompleto = txtNombreCompleto.Text;
            //        RFC = txtRFC.Text;
            //        CURP = txtCURP.Text;
            //        correo = txtCorreo.Text;
            //        celular = txtCelular.Text;
            //        domicilio = txtDomicilio.Text;
            //        no = Convert.ToInt32(txtNo.Text);
            //        codigoPostal = txtCodigoPostal.Text;
            //        pais = txtPais.Text;
            //        estado = txtEstado.Text;
            //        ciudad = txtCiudad.Text;
            //        fechaNacimiento = dtpFechaNacimiento.Value;

            //        // Datos a guardar
            //        mClientes.setIdCliente(idCliente);
            //        mClientes.setNombreCompleto(nombreCompleto);
            //        mClientes.setFechaNacimiento(fechaNacimiento);
            //        mClientes.setRFC(RFC);
            //        mClientes.setCURP(CURP);
            //        mClientes.setCorreo(correo);
            //        mClientes.setCelular(celular);
            //        mClientes.setDomicilio(domicilio);
            //        mClientes.setNo(no);
            //        mClientes.setCodigoPostal(codigoPostal);
            //        mClientes.setPais(pais);
            //        mClientes.setEstado(estado);
            //        mClientes.setCiudad(ciudad);

            //        if (mClientes.fnActualizar())
            //            MessageBox.Show("Cliente actualizado con éxito!");
            //        else
            //            MessageBox.Show("No es posible actualizar datos, \n consulte a su administrador");
            //    }
            //}
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {

            txtNombreCompleto.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtRFC.Enabled = true;
            txtCURP.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;
            txtDomicilio.Enabled = true;
            txtNo.Enabled = true;
            txtCodigoPostal.Enabled = true;
            txtPais.Enabled = true;
            txtEstado.Enabled = true;
            txtCiudad.Enabled = true;


            txtidCliente.Text = " ";
            txtNombreCompleto.Text = " ";
            txtRFC.Text = " ";
            txtCURP.Text = " ";
            txtCorreo.Text = " ";
            txtCelular.Text = " ";
            txtDomicilio.Text = " ";
            txtNo.Text = " ";
            txtCodigoPostal.Text = " ";
            txtPais.Text = " ";
            txtEstado.Text = " ";
            txtCiudad.Text = " ";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtidCliente.Text = " ";
            txtNombreCompleto.Text = " ";
            txtRFC.Text = " ";
            txtCURP.Text = " ";
            txtCorreo.Text = " ";
            txtCelular.Text = " ";
            txtDomicilio.Text = " ";
            txtNo.Text = " ";
            txtCodigoPostal.Text = " ";
            txtPais.Text = " ";
            txtEstado.Text = " ";
            txtCiudad.Text = " ";

            txtNombreCompleto.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtRFC.Enabled = false;
            txtCURP.Enabled = false;
            txtCorreo.Enabled = false;
            txtCelular.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNo.Enabled = false;
            txtCodigoPostal.Enabled = false;
            txtPais.Enabled = false;
            txtEstado.Enabled = false;
            txtCiudad.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar search = new FormBuscar();
            search.setVar("Clientes");
            AddOwnedForm(search);

            search.ShowDialog();

            txtNombreCompleto.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtRFC.Enabled = true;
            txtCURP.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;
            txtDomicilio.Enabled = true;
            txtNo.Enabled = true;
            txtCodigoPostal.Enabled = true;
            txtPais.Enabled = true;
            txtEstado.Enabled = true;
            txtCiudad.Enabled = true;

        }
    }
}
