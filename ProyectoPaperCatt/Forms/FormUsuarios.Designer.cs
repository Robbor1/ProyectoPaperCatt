namespace ProyectoPaperCatt.Forms
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label11 = new Label();
            dtpFechaRegistro = new DateTimePicker();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            lblEstatus = new Label();
            btnActualizar = new Button();
            btnGuardar = new Button();
            txtId = new TextBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            txtNombre = new TextBox();
            txtApellidoM = new TextBox();
            txtApellidoP = new TextBox();
            cbStatus = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCorreo = new TextBox();
            txtTel = new TextBox();
            txtIdPerfil = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnBuscar = new Button();
            label12 = new Label();
            txtFechaUltAcceso = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(444, 73);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 24;
            label11.Text = "Fecha Registro";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Anchor = AnchorStyles.None;
            dtpFechaRegistro.Enabled = false;
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(543, 69);
            dtpFechaRegistro.Margin = new Padding(3, 2, 3, 2);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(108, 23);
            dtpFechaRegistro.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblEstatus);
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnGuardar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 76);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(472, 21);
            button2.Name = "button2";
            button2.Size = new Size(105, 31);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(233, 21);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 31);
            button1.TabIndex = 4;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLimpiar_Click;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(23, 29);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(12, 15);
            lblEstatus.TabIndex = 3;
            lblEstatus.Text = "-";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(624, 22);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 31);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(351, 22);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 31);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Enabled = false;
            txtId.Location = new Point(116, 146);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(116, 188);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(162, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(116, 223);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(162, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(403, 142);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Anchor = AnchorStyles.None;
            txtApellidoM.Enabled = false;
            txtApellidoM.Location = new Point(403, 215);
            txtApellidoM.Margin = new Padding(3, 2, 3, 2);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(248, 23);
            txtApellidoM.TabIndex = 7;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Anchor = AnchorStyles.None;
            txtApellidoP.Enabled = false;
            txtApellidoP.Location = new Point(403, 180);
            txtApellidoP.Margin = new Padding(3, 2, 3, 2);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(248, 23);
            txtApellidoP.TabIndex = 8;
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.None;
            cbStatus.AutoSize = true;
            cbStatus.Enabled = false;
            cbStatus.Location = new Point(158, 314);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(68, 19);
            cbStatus.TabIndex = 10;
            cbStatus.Text = "Inactivo";
            cbStatus.UseVisualStyleBackColor = true;
            cbStatus.CheckedChanged += cbStatus_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(91, 148);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 12;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(60, 188);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 13;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(38, 223);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 14;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(342, 147);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 15;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(330, 182);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 16;
            label6.Text = "Apellido P";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(326, 218);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 17;
            label7.Text = "Apellido M";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(403, 251);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 23);
            txtCorreo.TabIndex = 18;
            // 
            // txtTel
            // 
            txtTel.Anchor = AnchorStyles.None;
            txtTel.Enabled = false;
            txtTel.Location = new Point(403, 286);
            txtTel.Margin = new Padding(3, 2, 3, 2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(207, 23);
            txtTel.TabIndex = 19;
            // 
            // txtIdPerfil
            // 
            txtIdPerfil.Anchor = AnchorStyles.None;
            txtIdPerfil.Enabled = false;
            txtIdPerfil.Location = new Point(116, 266);
            txtIdPerfil.Margin = new Padding(3, 2, 3, 2);
            txtIdPerfil.Name = "txtIdPerfil";
            txtIdPerfil.Size = new Size(162, 23);
            txtIdPerfil.TabIndex = 20;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(351, 254);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 21;
            label8.Text = "Correo";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(340, 289);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 22;
            label9.Text = "Telefono";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(63, 268);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 23;
            label10.Text = "IdPerfil";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Location = new Point(218, 144);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 22);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(48, 73);
            label12.Name = "label12";
            label12.Size = new Size(115, 15);
            label12.TabIndex = 25;
            label12.Text = "Fecha último acceso";
            // 
            // txtFechaUltAcceso
            // 
            txtFechaUltAcceso.Anchor = AnchorStyles.None;
            txtFechaUltAcceso.Enabled = false;
            txtFechaUltAcceso.Location = new Point(179, 70);
            txtFechaUltAcceso.Margin = new Padding(3, 2, 3, 2);
            txtFechaUltAcceso.Name = "txtFechaUltAcceso";
            txtFechaUltAcceso.Size = new Size(159, 23);
            txtFechaUltAcceso.TabIndex = 26;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 428);
            Controls.Add(txtFechaUltAcceso);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnBuscar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtIdPerfil);
            Controls.Add(txtTel);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbStatus);
            Controls.Add(txtApellidoP);
            Controls.Add(txtApellidoM);
            Controls.Add(txtNombre);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(txtId);
            Controls.Add(panel2);
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button btnActualizar;
        private Button btnGuardar;
        private DateTimePicker dtpFechaRegistro;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnBuscar;
        private Label label12;
        private Button button1;
        public TextBox txtId;
        public TextBox txtUsuario;
        public TextBox txtPassword;
        public TextBox txtNombre;
        public TextBox txtApellidoM;
        public TextBox txtApellidoP;
        public CheckBox cbStatus;
        public TextBox txtCorreo;
        public TextBox txtTel;
        public TextBox txtIdPerfil;
        public TextBox txtFechaUltAcceso;
        public Label lblEstatus;
        private Button button2;
    }
}