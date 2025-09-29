namespace ProyectoPaperCatt.Forms
{
    partial class FormInventario
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
            btnBscar = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtProveedor = new TextBox();
            txtCantidad = new TextBox();
            dataGridView1 = new DataGridView();
            btnNuevo = new Button();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBscar
            // 
            btnBscar.Location = new Point(234, 60);
            btnBscar.Name = "btnBscar";
            btnBscar.Size = new Size(75, 23);
            btnBscar.TabIndex = 0;
            btnBscar.Text = "Buscar";
            btnBscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(119, 57);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(109, 23);
            txtCodigo.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 220);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 112);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 115);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "Proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 76);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(406, 112);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(133, 23);
            txtProveedor.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(406, 68);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(133, 23);
            txtCantidad.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(686, 214);
            dataGridView1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(470, 415);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(587, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCantidad);
            Controls.Add(txtProveedor);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(btnBscar);
            Name = "FormInventario";
            Text = "FormInventario";
            Load += FormInventario_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBscar;
        private Label label1;
        private TextBox txtCodigo;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtProveedor;
        private TextBox txtCantidad;
        private DataGridView dataGridView1;
        private Button btnNuevo;
        private Button btnCerrar;
    }
}