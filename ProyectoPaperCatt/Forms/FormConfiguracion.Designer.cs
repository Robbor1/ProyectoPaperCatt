
namespace ProyectoPaperCatt.Forms
{
    partial class FormConfiguracion
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
            panel2 = new Panel();
            panel3 = new Panel();
            cboxMoneda = new ComboBox();
            label9 = new Label();
            txtIVA = new TextBox();
            txtCorreo = new TextBox();
            txtDirSuc = new TextBox();
            txtNomSuc = new TextBox();
            txtDirEmp = new TextBox();
            txtRfcEmp = new TextBox();
            txtNomEmp = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 56);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(cboxMoneda);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtIVA);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(txtDirSuc);
            panel3.Controls.Add(txtNomSuc);
            panel3.Controls.Add(txtDirEmp);
            panel3.Controls.Add(txtRfcEmp);
            panel3.Controls.Add(txtNomEmp);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 398);
            panel3.TabIndex = 3;
            // 
            // cboxMoneda
            // 
            cboxMoneda.Enabled = false;
            cboxMoneda.FormattingEnabled = true;
            cboxMoneda.Items.AddRange(new object[] { "MXN | Pesos mexicanos", "DLS | Dolares", "EUR | Euros" });
            cboxMoneda.Location = new Point(313, 349);
            cboxMoneda.Name = "cboxMoneda";
            cboxMoneda.Size = new Size(211, 28);
            cboxMoneda.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 304);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 16;
            label9.Text = "%";
            // 
            // txtIVA
            // 
            txtIVA.Enabled = false;
            txtIVA.Location = new Point(313, 301);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(89, 27);
            txtIVA.TabIndex = 14;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(313, 256);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(291, 27);
            txtCorreo.TabIndex = 13;
            // 
            // txtDirSuc
            // 
            txtDirSuc.Enabled = false;
            txtDirSuc.Location = new Point(313, 211);
            txtDirSuc.Name = "txtDirSuc";
            txtDirSuc.Size = new Size(291, 27);
            txtDirSuc.TabIndex = 12;
            // 
            // txtNomSuc
            // 
            txtNomSuc.Enabled = false;
            txtNomSuc.Location = new Point(313, 166);
            txtNomSuc.Name = "txtNomSuc";
            txtNomSuc.Size = new Size(291, 27);
            txtNomSuc.TabIndex = 11;
            // 
            // txtDirEmp
            // 
            txtDirEmp.Enabled = false;
            txtDirEmp.Location = new Point(313, 121);
            txtDirEmp.Name = "txtDirEmp";
            txtDirEmp.Size = new Size(291, 27);
            txtDirEmp.TabIndex = 10;
            // 
            // txtRfcEmp
            // 
            txtRfcEmp.Enabled = false;
            txtRfcEmp.Location = new Point(313, 76);
            txtRfcEmp.Name = "txtRfcEmp";
            txtRfcEmp.Size = new Size(291, 27);
            txtRfcEmp.TabIndex = 9;
            // 
            // txtNomEmp
            // 
            txtNomEmp.Enabled = false;
            txtNomEmp.Location = new Point(313, 31);
            txtNomEmp.Name = "txtNomEmp";
            txtNomEmp.Size = new Size(291, 27);
            txtNomEmp.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 349);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 7;
            label8.Text = "Moneda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 304);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Tasa de IVA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 259);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 214);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 4;
            label5.Text = "Dirección de sucursal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 169);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre de sucursal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 124);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 2;
            label3.Text = "Dirección de la empresa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 79);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "RFC de la empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 34);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre de la empresa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 46);
            panel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.Location = new Point(690, 58);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(690, 122);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(690, 186);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(690, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 500);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormConfiguracion";
            Text = "Configuracion";
            Load += FormConfiguracion_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private void listBoxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label9;
        private TextBox txtIVA;
        private TextBox txtCorreo;
        private TextBox txtDirSuc;
        private TextBox txtNomSuc;
        private TextBox txtDirEmp;
        private TextBox txtRfcEmp;
        private TextBox txtNomEmp;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboxMoneda;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Button btnEditar;
        private Button btnAgregar;
    }
}