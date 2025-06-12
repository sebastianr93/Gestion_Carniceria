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
            label1 = new Label();
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
            cbModoOscuro = new CheckBox();
            btnAbout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 0;
            label2.Text = "Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 26);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 1;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 26);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 2;
            label4.Text = "Informes";
            // 
            // btnDatosClientes
            // 
            btnDatosClientes.Location = new Point(12, 50);
            btnDatosClientes.Name = "btnDatosClientes";
            btnDatosClientes.Size = new Size(75, 23);
            btnDatosClientes.TabIndex = 3;
            btnDatosClientes.Text = "Datos";
            btnDatosClientes.UseVisualStyleBackColor = true;
            btnDatosClientes.Click += btnDatosClientes_Click;
            // 
            // btnPedidosClientes
            // 
            btnPedidosClientes.Location = new Point(12, 79);
            btnPedidosClientes.Name = "btnPedidosClientes";
            btnPedidosClientes.Size = new Size(75, 23);
            btnPedidosClientes.TabIndex = 4;
            btnPedidosClientes.Text = "Pedidos";
            btnPedidosClientes.UseVisualStyleBackColor = true;
            btnPedidosClientes.Click += btnPedidosClientes_Click;
            // 
            // btnDatosProveedores
            // 
            btnDatosProveedores.Location = new Point(145, 50);
            btnDatosProveedores.Name = "btnDatosProveedores";
            btnDatosProveedores.Size = new Size(75, 23);
            btnDatosProveedores.TabIndex = 5;
            btnDatosProveedores.Text = "Datos";
            btnDatosProveedores.UseVisualStyleBackColor = true;
            // 
            // btnPedidosProveedores
            // 
            btnPedidosProveedores.Location = new Point(145, 79);
            btnPedidosProveedores.Name = "btnPedidosProveedores";
            btnPedidosProveedores.Size = new Size(75, 23);
            btnPedidosProveedores.TabIndex = 6;
            btnPedidosProveedores.Text = "Pedidos";
            btnPedidosProveedores.UseVisualStyleBackColor = true;
            btnPedidosProveedores.Click += btnPedidosProveedores_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(288, 50);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(75, 23);
            btnInventario.TabIndex = 7;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnCierreDelDia
            // 
            btnCierreDelDia.Location = new Point(425, 50);
            btnCierreDelDia.Name = "btnCierreDelDia";
            btnCierreDelDia.Size = new Size(97, 23);
            btnCierreDelDia.TabIndex = 8;
            btnCierreDelDia.Text = "Cierre del Día";
            btnCierreDelDia.UseVisualStyleBackColor = true;
            // 
            // btnDeudores
            // 
            btnDeudores.Location = new Point(425, 79);
            btnDeudores.Name = "btnDeudores";
            btnDeudores.Size = new Size(133, 23);
            btnDeudores.TabIndex = 9;
            btnDeudores.Text = "Clientes con Deuda";
            btnDeudores.UseVisualStyleBackColor = true;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(425, 108);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(75, 23);
            btnTotales.TabIndex = 10;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 203);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbModoOscuro
            // 
            cbModoOscuro.AutoSize = true;
            cbModoOscuro.Location = new Point(482, 207);
            cbModoOscuro.Name = "cbModoOscuro";
            cbModoOscuro.Size = new Size(99, 19);
            cbModoOscuro.TabIndex = 12;
            cbModoOscuro.Text = "Modo Oscuro";
            cbModoOscuro.UseVisualStyleBackColor = true;
            cbModoOscuro.CheckedChanged += cbModoOscuro_CheckedChanged;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(112, 203);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 13;
            btnAbout.Text = "Acerca De";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 238);
            Controls.Add(btnAbout);
            Controls.Add(cbModoOscuro);
            Controls.Add(btnSalir);
            Controls.Add(btnTotales);
            Controls.Add(btnDeudores);
            Controls.Add(btnCierreDelDia);
            Controls.Add(btnInventario);
            Controls.Add(btnPedidosProveedores);
            Controls.Add(btnDatosProveedores);
            Controls.Add(btnPedidosClientes);
            Controls.Add(btnDatosClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "Menú";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private CheckBox cbModoOscuro;
        private Button btnAbout;
    }
}
