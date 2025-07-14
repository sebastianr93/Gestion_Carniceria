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
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, -3);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 0;
            label2.Text = "Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, -3);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 1;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 2;
            label4.Text = "Informes";
            // 
            // btnDatosClientes
            // 
            btnDatosClientes.Location = new Point(6, 22);
            btnDatosClientes.Name = "btnDatosClientes";
            btnDatosClientes.Size = new Size(117, 23);
            btnDatosClientes.TabIndex = 3;
            btnDatosClientes.Text = "Crear y Editar";
            btnDatosClientes.UseVisualStyleBackColor = true;
            btnDatosClientes.Click += btnDatosClientes_Click;
            // 
            // btnPedidosClientes
            // 
            btnPedidosClientes.Location = new Point(6, 51);
            btnPedidosClientes.Name = "btnPedidosClientes";
            btnPedidosClientes.Size = new Size(117, 23);
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
            btnDatosProveedores.Size = new Size(117, 23);
            btnDatosProveedores.TabIndex = 5;
            btnDatosProveedores.Text = "Crear y Editar";
            btnDatosProveedores.UseVisualStyleBackColor = true;
            btnDatosProveedores.Click += btnDatosProveedores_Click;
            // 
            // btnPedidosProveedores
            // 
            btnPedidosProveedores.Location = new Point(6, 51);
            btnPedidosProveedores.Name = "btnPedidosProveedores";
            btnPedidosProveedores.Size = new Size(117, 23);
            btnPedidosProveedores.TabIndex = 6;
            btnPedidosProveedores.Text = "Nuevo Pedido";
            btnPedidosProveedores.UseVisualStyleBackColor = true;
            btnPedidosProveedores.Click += btnPedidosProveedores_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(6, 22);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(117, 23);
            btnInventario.TabIndex = 7;
            btnInventario.Text = "Stock de Productos";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnCierreDelDia
            // 
            btnCierreDelDia.Location = new Point(6, 109);
            btnCierreDelDia.Name = "btnCierreDelDia";
            btnCierreDelDia.Size = new Size(117, 23);
            btnCierreDelDia.TabIndex = 8;
            btnCierreDelDia.Text = "Cierre del Día";
            btnCierreDelDia.UseVisualStyleBackColor = true;
            // 
            // btnDeudores
            // 
            btnDeudores.Location = new Point(6, 80);
            btnDeudores.Name = "btnDeudores";
            btnDeudores.Size = new Size(117, 23);
            btnDeudores.TabIndex = 9;
            btnDeudores.Text = "Clientes con Deuda";
            btnDeudores.UseVisualStyleBackColor = true;
            btnDeudores.Click += btnDeudores_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(6, 51);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(117, 23);
            btnTotales.TabIndex = 10;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 222);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(201, 222);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 13;
            btnAbout.Text = "Contacto";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnMediosDePago
            // 
            btnMediosDePago.Location = new Point(6, 80);
            btnMediosDePago.Name = "btnMediosDePago";
            btnMediosDePago.Size = new Size(117, 23);
            btnMediosDePago.TabIndex = 14;
            btnMediosDePago.Text = "Medios de Pago";
            btnMediosDePago.UseVisualStyleBackColor = true;
            btnMediosDePago.Click += btnMediosDePago_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDatosClientes);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnMediosDePago);
            groupBox1.Controls.Add(btnPedidosClientes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 114);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, -2);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 16;
            label1.Text = "Clientes";
            // 
            // button1
            // 
            button1.Location = new Point(93, 222);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 16;
            button1.Text = "ProbarConexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ProbarConexion_Click;
            // 
            // btnRegistroVentas
            // 
            btnRegistroVentas.Location = new Point(6, 22);
            btnRegistroVentas.Name = "btnRegistroVentas";
            btnRegistroVentas.Size = new Size(117, 23);
            btnRegistroVentas.TabIndex = 17;
            btnRegistroVentas.Text = "Registro de Ventas";
            btnRegistroVentas.UseVisualStyleBackColor = true;
            btnRegistroVentas.Click += btnRegistroVentas_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnDatosProveedores);
            groupBox2.Controls.Add(btnPedidosProveedores);
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(129, 84);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegistroVentas);
            groupBox3.Controls.Add(btnTotales);
            groupBox3.Controls.Add(btnDeudores);
            groupBox3.Controls.Add(btnCierreDelDia);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(147, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(129, 142);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInventario);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(147, 160);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(129, 56);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(282, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 257);
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
