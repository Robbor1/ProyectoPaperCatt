using BussinesRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPaperCatt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Rutina para validar datos vs BD vs fileEncrypt
                Usuarios mUsuario = new Usuarios();
                FormMainMenu mainMenu = new FormMainMenu();
                mUsuario.setUserN(txt_user.Text);
                mUsuario.setPass(txt_pass.Text);
                if (mUsuario.fnValidaLogin())
                {
                    //Ingresar al sistema

                    //los permisos del usuario que hizo login
                    this.Close();


                }
                else
                {

                    MessageBox.Show("El usuario y/o Contraseña son invalidos.",
                        "Aviso PaperCatt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_user.Text = "";
                    txt_pass.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[btn_Ingresar_Click]" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_pass_MouseLeave(object sender, EventArgs e)
        {
            txt_pass.Text = "CONTRASEÑA";
            txt_pass.ForeColor = Color.DimGray;
            txt_pass.UseSystemPasswordChar = false;
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            
                
                txt_pass.ForeColor = Color.DimGray;
                txt_pass.UseSystemPasswordChar = true;
            
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            
                
                txt_pass.ForeColor = Color.DimGray;
                txt_pass.UseSystemPasswordChar = true;
            

        }
    }
}
