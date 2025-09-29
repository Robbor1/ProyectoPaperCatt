namespace ProyectoPaperCatt.Forms
{
    partial class FormProductos
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
            label1 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label6 = new Label();
            label7 = new Label();
            txtVenta = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtStock = new TextBox();
            pbImagen = new PictureBox();
            dtpFechaReg = new DateTimePicker();
            panel1 = new Panel();
            cbProveedor = new ComboBox();
            rbKg = new RadioButton();
            rbLt = new RadioButton();
            btnBuscar = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCosto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(87, 112);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(60, 155);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 8;
            label3.Text = "Precio Costo";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(419, 20);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 44);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(248, 20);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 44);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.Location = new Point(77, 20);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(144, 44);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(93, 75);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 14;
            label6.Text = "Código";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(61, 191);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 17;
            label7.Text = "Precio Venta";
            // 
            // txtVenta
            // 
            txtVenta.Enabled = false;
            txtVenta.Location = new Point(152, 187);
            txtVenta.Margin = new Padding(3, 2, 3, 2);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(100, 23);
            txtVenta.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(24, 230);
            label8.Name = "label8";
            label8.Size = new Size(122, 19);
            label8.TabIndex = 19;
            label8.Text = "Unidad de Medida";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(74, 267);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 21;
            label9.Text = "Proveedor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(48, 314);
            label10.Name = "label10";
            label10.Size = new Size(98, 19);
            label10.TabIndex = 23;
            label10.Text = "Fecha Registro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(104, 358);
            label11.Name = "label11";
            label11.Size = new Size(42, 19);
            label11.TabIndex = 25;
            label11.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(152, 354);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(129, 23);
            txtStock.TabIndex = 24;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(454, 143);
            pbImagen.Margin = new Padding(3, 2, 3, 2);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(218, 147);
            pbImagen.TabIndex = 26;
            pbImagen.TabStop = false;
            // 
            // dtpFechaReg
            // 
            dtpFechaReg.Enabled = false;
            dtpFechaReg.Format = DateTimePickerFormat.Short;
            dtpFechaReg.Location = new Point(152, 311);
            dtpFechaReg.Margin = new Padding(3, 2, 3, 2);
            dtpFechaReg.Name = "dtpFechaReg";
            dtpFechaReg.Size = new Size(129, 23);
            dtpFechaReg.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 84);
            panel1.TabIndex = 34;
            // 
            // cbProveedor
            // 
            cbProveedor.Enabled = false;
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(152, 267);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(221, 23);
            cbProveedor.TabIndex = 35;
            // 
            // rbKg
            // 
            rbKg.AutoSize = true;
            rbKg.Enabled = false;
            rbKg.Location = new Point(170, 231);
            rbKg.Name = "rbKg";
            rbKg.Size = new Size(39, 19);
            rbKg.TabIndex = 36;
            rbKg.TabStop = true;
            rbKg.Text = "Kg";
            rbKg.UseVisualStyleBackColor = true;
            // 
            // rbLt
            // 
            rbLt.AutoSize = true;
            rbLt.Enabled = false;
            rbLt.Location = new Point(228, 231);
            rbLt.Name = "rbLt";
            rbLt.Size = new Size(35, 19);
            rbLt.TabIndex = 37;
            rbLt.TabStop = true;
            rbLt.Text = "Lt";
            rbLt.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(354, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 35);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(152, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 39;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(152, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 40;
            // 
            // txtCosto
            // 
            txtCosto.Enabled = false;
            txtCosto.Location = new Point(152, 151);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 41;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 517);
            Controls.Add(txtCosto);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);
            Controls.Add(rbLt);
            Controls.Add(rbKg);
            Controls.Add(cbProveedor);
            Controls.Add(panel1);
            Controls.Add(dtpFechaReg);
            Controls.Add(pbImagen);
            Controls.Add(label11);
            Controls.Add(txtStock);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtVenta);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProductos";
            Text = "Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox7;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox10;
        private Label label13;
        private TextBox textBox11;
        private Label label14;
        private TextBox textBox12;
        private Panel panel1;
        private Button btnBuscar;
        public TextBox txtVenta;
        public TextBox txtStock;
        public PictureBox pbImagen;
        public DateTimePicker dtpFechaReg;
        public ComboBox cbProveedor;
        public RadioButton rbKg;
        public RadioButton rbLt;
        public TextBox txtId;
        public TextBox txtNombre;
        public TextBox txtCosto;
    }
}