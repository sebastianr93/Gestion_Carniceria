namespace Gestion_Carniceria
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDatosClientes = new Button();
            btnPedidosClientes = new Button();
            btnDatosProveedores = new Button();
            btnPedidosProveedores = new Button();
            btnInventario = new Button();
            btnCierreDelDia = new Button();
            btnDeudores = new Button();
            btnTotales = new Button();
            btnSalir = new Button();
            btnAbout = new Button();
            btnMediosDePago = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            btnRegistroVentas = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(-4, -8);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 0;
            label2.Text = "Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(-4, -9);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 1;
            label3.Text = "Controles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, -3);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 2;
            label4.Text = "Informes";
            // 
            // btnDatosClientes
            // 
            btnDatosClientes.Location = new Point(6, 30);
            btnDatosClientes.Name = "btnDatosClientes";
            btnDatosClientes.Size = new Size(124, 52);
            btnDatosClientes.TabIndex = 3;
            btnDatosClientes.Text = "Crear y Editar";
            btnDatosClientes.UseVisualStyleBackColor = true;
            btnDatosClientes.Click += btnDatosClientes_Click;
            // 
            // btnPedidosClientes
            // 
            btnPedidosClientes.Location = new Point(136, 30);
            btnPedidosClientes.Name = "btnPedidosClientes";
            btnPedidosClientes.Size = new Size(124, 52);
            btnPedidosClientes.TabIndex = 4;
            btnPedidosClientes.Text = "Nueva Venta";
            btnPedidosClientes.UseVisualStyleBackColor = true;
            btnPedidosClientes.Click += btnPedidosClientes_Click;
            // 
            // btnDatosProveedores
            // 
            btnDatosProveedores.Location = new Point(6, 22);
            btnDatosProveedores.Name = "btnDatosProveedores";
            btnDatosProveedores.RightToLeft = RightToLeft.No;
            btnDatosProveedores.Size = new Size(124, 52);
            btnDatosProveedores.TabIndex = 5;
            btnDatosProveedores.Text = "Crear y Editar";
            btnDatosProveedores.UseVisualStyleBackColor = true;
            btnDatosProveedores.Click += btnDatosProveedores_Click;
            // 
            // btnPedidosProveedores
            // 
            btnPedidosProveedores.Location = new Point(136, 22);
            btnPedidosProveedores.Name = "btnPedidosProveedores";
            btnPedidosProveedores.Size = new Size(124, 52);
            btnPedidosProveedores.TabIndex = 6;
            btnPedidosProveedores.Text = "Nuevo Pedido";
            btnPedidosProveedores.UseVisualStyleBackColor = true;
            btnPedidosProveedores.Click += btnPedidosProveedores_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(6, 22);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(124, 52);
            btnInventario.TabIndex = 7;
            btnInventario.Text = "Stock de Productos";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnCierreDelDia
            // 
            btnCierreDelDia.Location = new Point(138, 116);
            btnCierreDelDia.Name = "btnCierreDelDia";
            btnCierreDelDia.Size = new Size(124, 52);
            btnCierreDelDia.TabIndex = 8;
            btnCierreDelDia.Text = "Cierre del Día";
            btnCierreDelDia.UseVisualStyleBackColor = true;
            // 
            // btnDeudores
            // 
            btnDeudores.Location = new Point(6, 116);
            btnDeudores.Name = "btnDeudores";
            btnDeudores.Size = new Size(124, 52);
            btnDeudores.TabIndex = 9;
            btnDeudores.Text = "Registro de Deudas";
            btnDeudores.UseVisualStyleBackColor = true;
            btnDeudores.Click += btnDeudores_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(138, 30);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(124, 52);
            btnTotales.TabIndex = 10;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(473, 569);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 52);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAbout.Location = new Point(341, 569);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(124, 52);
            btnAbout.TabIndex = 13;
            btnAbout.Text = "Contacto";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnMediosDePago
            // 
            btnMediosDePago.Location = new Point(136, 22);
            btnMediosDePago.Name = "btnMediosDePago";
            btnMediosDePago.Size = new Size(124, 52);
            btnMediosDePago.TabIndex = 14;
            btnMediosDePago.Text = "Medios de Pago";
            btnMediosDePago.UseVisualStyleBackColor = true;
            btnMediosDePago.Click += btnMediosDePago_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDatosClientes);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnPedidosClientes);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 354);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 88);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 16;
            label1.Text = "Clientes";
            // 
            // button1
            // 
            button1.Location = new Point(495, 538);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 16;
            button1.Text = "ProbarConexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ProbarConexion_Click;
            // 
            // btnRegistroVentas
            // 
            btnRegistroVentas.Location = new Point(6, 30);
            btnRegistroVentas.Name = "btnRegistroVentas";
            btnRegistroVentas.Size = new Size(124, 52);
            btnRegistroVentas.TabIndex = 17;
            btnRegistroVentas.Text = "Historial de Ventas";
            btnRegistroVentas.UseVisualStyleBackColor = true;
            btnRegistroVentas.Click += btnRegistroVentas_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnDatosProveedores);
            groupBox2.Controls.Add(btnPedidosProveedores);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 448);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 84);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegistroVentas);
            groupBox3.Controls.Add(btnTotales);
            groupBox3.Controls.Add(btnDeudores);
            groupBox3.Controls.Add(btnCierreDelDia);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(335, 354);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 178);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInventario);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btnMediosDePago);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(16, 547);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(266, 84);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(593, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 639);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnAbout);
            Controls.Add(btnSalir);
            Name = "MenuPrincipal";
            Text = "Menú";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDatosClientes;
        private Button btnPedidosClientes;
        private Button btnDatosProveedores;
        private Button btnPedidosProveedores;
        private Button btnInventario;
        private Button btnCierreDelDia;
        private Button btnDeudores;
        private Button btnTotales;
        private Button btnSalir;
        private Button btnAbout;
        private Button btnMediosDePago;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private Button btnRegistroVentas;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
    }
}
