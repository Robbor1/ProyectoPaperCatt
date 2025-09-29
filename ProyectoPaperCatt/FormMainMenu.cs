using BussinesRules;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ProyectoPaperCatt
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(72, 61, 139);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(147, 112, 219);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Segoe UI", 10F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }



        private void btnProducto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUsuarios(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClientes(), sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProveedores(), sender);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "INICIO";
            panelTitleBar.BackColor = Color.FromArgb(49, 37, 73);
            panelLogo.BackColor = Color.FromArgb(75, 0, 130);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            //declaraciones, variables


            try
            {
                //Text = "Sistema de Punto de Ventas (POS)";

                Login login = new Login();
                login.ShowDialog();

                // this.Text = this.Text + " ---> UserName: " + Utilerias.G_NombreUsuario
                //    + "Nombre: " + Utilerias.G_Usuario;

                /*barraUserName.Text = "["+ Utilerias.G_Usuario + "]";
                barraNombreDeUsuario.Text = "[" + Utilerias.G_NombreUsuario + "]";*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FormMainMenu_Load]" + ex.Message);
            }



            //IsMdiContainer = true;
            //WindowState = FormWindowState.Maximized;


            lblUserName.Text = Utilerias.G_NombreUsuario;
            lblTipoUsuario.Text = "Admin";


        }



        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            this.Close();

            Login frmLogin = new Login();

            frmLogin.ShowDialog();



        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVentas(), sender);

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInventario(), sender);

        }
    }
}
