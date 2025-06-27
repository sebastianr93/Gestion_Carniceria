namespace Gestion_Carniceria
{
    partial class FrmPedidoClientes
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
            label1 = new Label();
            cbClientes = new ComboBox();
            clienteDAOBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            cbMediosDePago = new ComboBox();
            label4 = new Label();
            txtBuscarProducto = new TextBox();
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
            btnBuscarProducto = new Button();
            btnAgregarProducto = new Button();
            dgvItemsVenta = new DataGridView();
            itemVentaBindingSource = new BindingSource(components);
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            lblMontoTotal = new Label();
            groupBox1 = new GroupBox();
            checkPagoParcial = new CheckBox();
            txtPagoParcial = new TextBox();
            txtAgregarProducto = new TextBox();
            label6 = new Label();
            lblTipoMDP = new Label();
            btnQuitarItem = new Button();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Nueva Venta";
            // 
            // cbClientes
            // 
            cbClientes.DataSource = clienteDAOBindingSource;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(12, 48);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(131, 23);
            cbClientes.TabIndex = 1;
            // 
            // clienteDAOBindingSource
            // 
            clienteDAOBindingSource.DataSource = typeof(ClienteDAO);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 30);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Medio de Pago:";
            // 
            // cbMediosDePago
            // 
            cbMediosDePago.FormattingEnabled = true;
            cbMediosDePago.Location = new Point(149, 48);
            cbMediosDePago.Name = "cbMediosDePago";
            cbMediosDePago.Size = new Size(131, 23);
            cbMediosDePago.TabIndex = 4;
            cbMediosDePago.SelectedIndexChanged += cbMediosDePago_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(502, 9);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 5;
            label4.Text = "Lista de Productos";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(502, 48);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(117, 23);
            txtBuscarProducto.TabIndex = 6;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, pesoDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, categoriaNombreDataGridViewTextBoxColumn });
            dgvProductos.DataSource = productoBindingSource;
            dgvProductos.Location = new Point(502, 80);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(443, 359);
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
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(625, 48);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(62, 23);
            btnBuscarProducto.TabIndex = 8;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(739, 49);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(62, 23);
            btnAgregarProducto.TabIndex = 9;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dgvItemsVenta
            // 
            dgvItemsVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsVenta.Location = new Point(12, 80);
            dgvItemsVenta.Name = "dgvItemsVenta";
            dgvItemsVenta.Size = new Size(484, 359);
            dgvItemsVenta.TabIndex = 10;
            // 
            // itemVentaBindingSource
            // 
            itemVentaBindingSource.DataSource = typeof(Entities.ItemVenta);
            // 
            // button3
            // 
            button3.Location = new Point(171, 466);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 11;
            button3.Text = "Confirmar Venta";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(831, 468);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 12;
            button4.Text = "Volver al Menú";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 32);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMontoTotal);
            groupBox1.Location = new Point(286, 445);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 45);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monto Total:";
            // 
            // checkPagoParcial
            // 
            checkPagoParcial.AutoSize = true;
            checkPagoParcial.Location = new Point(12, 446);
            checkPagoParcial.Name = "checkPagoParcial";
            checkPagoParcial.Size = new Size(91, 19);
            checkPagoParcial.TabIndex = 16;
            checkPagoParcial.Text = "Pago Parcial";
            checkPagoParcial.UseVisualStyleBackColor = true;
            checkPagoParcial.CheckedChanged += checkPagoParcial_CheckedChanged;
            // 
            // txtPagoParcial
            // 
            txtPagoParcial.Location = new Point(12, 466);
            txtPagoParcial.Name = "txtPagoParcial";
            txtPagoParcial.Size = new Size(100, 23);
            txtPagoParcial.TabIndex = 17;
            // 
            // txtAgregarProducto
            // 
            txtAgregarProducto.Location = new Point(807, 48);
            txtAgregarProducto.Name = "txtAgregarProducto";
            txtAgregarProducto.Size = new Size(117, 23);
            txtAgregarProducto.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(807, 30);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 19;
            label6.Text = "Unidad/Kg:";
            // 
            // lblTipoMDP
            // 
            lblTipoMDP.AutoSize = true;
            lblTipoMDP.Location = new Point(286, 51);
            lblTipoMDP.Name = "lblTipoMDP";
            lblTipoMDP.Size = new Size(61, 15);
            lblTipoMDP.TabIndex = 20;
            lblTipoMDP.Text = "Ajuste (%)";
            // 
            // btnQuitarItem
            // 
            btnQuitarItem.Location = new Point(434, 48);
            btnQuitarItem.Name = "btnQuitarItem";
            btnQuitarItem.Size = new Size(62, 23);
            btnQuitarItem.TabIndex = 21;
            btnQuitarItem.Text = "Quitar";
            btnQuitarItem.UseVisualStyleBackColor = true;
            btnQuitarItem.Click += btnQuitarItem_Click;
            // 
            // FrmPedidoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 502);
            Controls.Add(btnQuitarItem);
            Controls.Add(lblTipoMDP);
            Controls.Add(label6);
            Controls.Add(txtAgregarProducto);
            Controls.Add(txtPagoParcial);
            Controls.Add(checkPagoParcial);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dgvItemsVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscarProducto);
            Controls.Add(label4);
            Controls.Add(cbMediosDePago);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbClientes);
            Controls.Add(label1);
            Name = "FrmPedidoClientes";
            Text = "Nueva Venta";
            Load += FrmPedidoClientes_Load;
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbClientes;
        private Label label2;
        private Label label3;
        private ComboBox cbMediosDePago;
        private Label label4;
        private TextBox txtBuscarProducto;
        private DataGridView dgvProductos;
        private Button btnBuscarProducto;
        private Button btnAgregarProducto;
        private DataGridView dgvItemsVenta;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label lblMontoTotal;
        private GroupBox groupBox1;
        private BindingSource clienteDAOBindingSource;
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaNombreDataGridViewTextBoxColumn;
        private CheckBox checkPagoParcial;
        private TextBox txtPagoParcial;
        private TextBox txtAgregarProducto;
        private Label label6;
        private Label lblTipoMDP;
        private BindingSource itemVentaBindingSource;
        private Button btnQuitarItem;
    }
}