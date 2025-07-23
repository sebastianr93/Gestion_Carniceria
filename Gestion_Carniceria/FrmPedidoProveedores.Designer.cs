namespace Gestion_Carniceria
{
    partial class FrmPedidoProveedores
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
            components = new System.ComponentModel.Container();
            btnBuscarProducto = new Button();
            itemVentaBindingSource = new BindingSource(components);
            btnVolver = new Button();
            label5 = new Label();
            lblMontoTotal = new Label();
            btnAgregarProducto = new Button();
            label7 = new Label();
            label6 = new Label();
            txtAgregarProducto = new TextBox();
            btnQuitarItem = new Button();
            btnConfirmarPedido = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            dgvProductos = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pesoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            txtBuscarProducto = new TextBox();
            groupBox1 = new GroupBox();
            dgvItemsPedido = new DataGridView();
            cbProveedores = new ComboBox();
            clienteDAOBindingSource = new BindingSource(components);
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtPagoParcial = new TextBox();
            checkPagoParcial = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemsPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(129, 37);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(62, 23);
            btnBuscarProducto.TabIndex = 8;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // itemVentaBindingSource
            // 
            itemVentaBindingSource.DataSource = typeof(Entities.ItemVenta);
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(409, 475);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(62, 23);
            btnVolver.TabIndex = 24;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 20);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Nombre:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMontoTotal.Location = new Point(6, 19);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(50, 21);
            lblMontoTotal.TabIndex = 14;
            lblMontoTotal.Text = "$0.00";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(386, 37);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(62, 23);
            btnAgregarProducto.TabIndex = 9;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, -6);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 24;
            label7.Text = "Nuevo Pedido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 20);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 19;
            label6.Text = "Unidad/Kg:";
            // 
            // txtAgregarProducto
            // 
            txtAgregarProducto.Location = new Point(263, 38);
            txtAgregarProducto.Name = "txtAgregarProducto";
            txtAgregarProducto.Size = new Size(117, 23);
            txtAgregarProducto.TabIndex = 18;
            // 
            // btnQuitarItem
            // 
            btnQuitarItem.Location = new Point(432, 38);
            btnQuitarItem.Name = "btnQuitarItem";
            btnQuitarItem.Size = new Size(62, 23);
            btnQuitarItem.TabIndex = 21;
            btnQuitarItem.Text = "Quitar";
            btnQuitarItem.UseVisualStyleBackColor = true;
            btnQuitarItem.Click += btnQuitarItem_Click;
            // 
            // btnConfirmarPedido
            // 
            btnConfirmarPedido.Location = new Point(169, 453);
            btnConfirmarPedido.Name = "btnConfirmarPedido";
            btnConfirmarPedido.Size = new Size(109, 23);
            btnConfirmarPedido.TabIndex = 11;
            btnConfirmarPedido.Text = "Confirmar Pedido";
            btnConfirmarPedido.UseVisualStyleBackColor = true;
            btnConfirmarPedido.Click += btnConfirmarPedido_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAgregarProducto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAgregarProducto);
            groupBox2.Controls.Add(btnBuscarProducto);
            groupBox2.Controls.Add(dgvProductos);
            groupBox2.Controls.Add(txtBuscarProducto);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 456);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, -3);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 20;
            label4.Text = "Lista de Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, pesoDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, categoriaNombreDataGridViewTextBoxColumn });
            dgvProductos.DataSource = productoBindingSource;
            dgvProductos.Location = new Point(5, 66);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(443, 381);
            dgvProductos.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoriaNombreDataGridViewTextBoxColumn
            // 
            categoriaNombreDataGridViewTextBoxColumn.DataPropertyName = "CategoriaNombre";
            categoriaNombreDataGridViewTextBoxColumn.HeaderText = "CategoriaNombre";
            categoriaNombreDataGridViewTextBoxColumn.Name = "categoriaNombreDataGridViewTextBoxColumn";
            categoriaNombreDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaNombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(6, 37);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(117, 23);
            txtBuscarProducto.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMontoTotal);
            groupBox1.Location = new Point(284, 434);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 45);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monto Total:";
            // 
            // dgvItemsPedido
            // 
            dgvItemsPedido.AllowUserToAddRows = false;
            dgvItemsPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsPedido.Location = new Point(10, 66);
            dgvItemsPedido.Name = "dgvItemsPedido";
            dgvItemsPedido.ReadOnly = true;
            dgvItemsPedido.Size = new Size(484, 353);
            dgvItemsPedido.TabIndex = 10;
            // 
            // cbProveedores
            // 
            cbProveedores.DataSource = clienteDAOBindingSource;
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Location = new Point(10, 38);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(131, 23);
            cbProveedores.TabIndex = 1;
            // 
            // clienteDAOBindingSource
            // 
            clienteDAOBindingSource.DataSource = typeof(ClienteDAO);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Proveedor:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnQuitarItem);
            groupBox3.Controls.Add(txtPagoParcial);
            groupBox3.Controls.Add(checkPagoParcial);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(btnConfirmarPedido);
            groupBox3.Controls.Add(dgvItemsPedido);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cbProveedores);
            groupBox3.Location = new Point(477, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 487);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // txtPagoParcial
            // 
            txtPagoParcial.Location = new Point(10, 454);
            txtPagoParcial.Name = "txtPagoParcial";
            txtPagoParcial.Size = new Size(100, 23);
            txtPagoParcial.TabIndex = 17;
            txtPagoParcial.Leave += txtPagoParcial_Leave;
            // 
            // checkPagoParcial
            // 
            checkPagoParcial.AutoSize = true;
            checkPagoParcial.Location = new Point(10, 428);
            checkPagoParcial.Name = "checkPagoParcial";
            checkPagoParcial.Size = new Size(91, 19);
            checkPagoParcial.TabIndex = 16;
            checkPagoParcial.Text = "Pago Parcial";
            checkPagoParcial.UseVisualStyleBackColor = true;
            checkPagoParcial.CheckedChanged += checkPagoParcial_CheckedChanged;
            // 
            // FrmPedidoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 510);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FrmPedidoProveedores";
            Text = "Nuevo Pedido";
            FormClosing += FrmPedidoProveedores_FormClosing;
            Load += FrmPedidoProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemsPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarProducto;
        private BindingSource itemVentaBindingSource;
        private Button btnVolver;
        private Label label5;
        private Label lblMontoTotal;
        private Button btnAgregarProducto;
        private Label label7;
        private Label label6;
        private TextBox txtAgregarProducto;
        private Button btnQuitarItem;
        private Button btnConfirmarPedido;
        private GroupBox groupBox2;
        private Label label4;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaNombreDataGridViewTextBoxColumn;
        private BindingSource productoBindingSource;
        private TextBox txtBuscarProducto;
        private GroupBox groupBox1;
        private DataGridView dgvItemsPedido;
        private ComboBox cbProveedores;
        private BindingSource clienteDAOBindingSource;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox txtPagoParcial;
        private CheckBox checkPagoParcial;
    }
}