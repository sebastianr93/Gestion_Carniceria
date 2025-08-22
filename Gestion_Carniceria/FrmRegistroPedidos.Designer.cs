namespace Gestion_Carniceria
{
    partial class FrmRegistroPedidos
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
            label5 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewPedidosHistorial = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pagoParcialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pedidoBindingSource = new BindingSource(components);
            cmbMDP = new ComboBox();
            dtpFechaBuscar = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            btnBuscar = new Button();
            btnExportar = new Button();
            groupBox2 = new GroupBox();
            lblValorTotal = new Label();
            lblPagoParcial = new Label();
            lblFechaPedido = new Label();
            lblProveedor = new Label();
            label6 = new Label();
            label1 = new Label();
            dataGridViewDetallePedido = new DataGridView();
            itemPedidoBindingSource = new BindingSource(components);
            productoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidosHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallePedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 6);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 17;
            label5.Text = "Pedidos Registrados";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewPedidosHistorial);
            groupBox1.Controls.Add(cmbMDP);
            groupBox1.Controls.Add(dtpFechaBuscar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 485);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // dataGridViewPedidosHistorial
            // 
            dataGridViewPedidosHistorial.AutoGenerateColumns = false;
            dataGridViewPedidosHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidosHistorial.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn, pagoParcialDataGridViewTextBoxColumn, proveedorDataGridViewTextBoxColumn });
            dataGridViewPedidosHistorial.DataSource = pedidoBindingSource;
            dataGridViewPedidosHistorial.Location = new Point(6, 67);
            dataGridViewPedidosHistorial.Name = "dataGridViewPedidosHistorial";
            dataGridViewPedidosHistorial.Size = new Size(542, 373);
            dataGridViewPedidosHistorial.TabIndex = 14;
            dataGridViewPedidosHistorial.CellContentClick += dataGridViewPedidosHistorial_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // pagoParcialDataGridViewTextBoxColumn
            // 
            pagoParcialDataGridViewTextBoxColumn.DataPropertyName = "PagoParcial";
            pagoParcialDataGridViewTextBoxColumn.HeaderText = "PagoParcial";
            pagoParcialDataGridViewTextBoxColumn.Name = "pagoParcialDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            // 
            // pedidoBindingSource
            // 
            pedidoBindingSource.DataSource = typeof(Entities.Pedido);
            // 
            // cmbMDP
            // 
            cmbMDP.FormattingEnabled = true;
            cmbMDP.Location = new Point(346, 38);
            cmbMDP.Name = "cmbMDP";
            cmbMDP.Size = new Size(121, 23);
            cmbMDP.TabIndex = 13;
            // 
            // dtpFechaBuscar
            // 
            dtpFechaBuscar.Checked = false;
            dtpFechaBuscar.Location = new Point(129, 38);
            dtpFechaBuscar.Name = "dtpFechaBuscar";
            dtpFechaBuscar.Size = new Size(211, 23);
            dtpFechaBuscar.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 19);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 11;
            label4.Text = "Medio de Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 19);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "Proveedor:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(6, 38);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(117, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(473, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(485, 458);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 17;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblValorTotal);
            groupBox2.Controls.Add(lblPagoParcial);
            groupBox2.Controls.Add(lblFechaPedido);
            groupBox2.Controls.Add(lblProveedor);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGridViewDetallePedido);
            groupBox2.Location = new Point(685, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 427);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(9, 128);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(64, 25);
            lblValorTotal.TabIndex = 11;
            lblValorTotal.Text = "label7";
            // 
            // lblPagoParcial
            // 
            lblPagoParcial.AutoSize = true;
            lblPagoParcial.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPagoParcial.Location = new Point(9, 165);
            lblPagoParcial.Name = "lblPagoParcial";
            lblPagoParcial.Size = new Size(71, 30);
            lblPagoParcial.TabIndex = 10;
            lblPagoParcial.Text = "label7";
            // 
            // lblFechaPedido
            // 
            lblFechaPedido.AutoSize = true;
            lblFechaPedido.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFechaPedido.Location = new Point(9, 86);
            lblFechaPedido.Name = "lblFechaPedido";
            lblFechaPedido.Size = new Size(64, 25);
            lblFechaPedido.TabIndex = 9;
            lblFechaPedido.Text = "label7";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProveedor.Location = new Point(6, 38);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(74, 30);
            lblProveedor.TabIndex = 8;
            lblProveedor.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(146, 21);
            label6.TabIndex = 7;
            label6.Text = "Lista de Productos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, -6);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 6;
            label1.Text = "Detalles del Pedido";
            // 
            // dataGridViewDetallePedido
            // 
            dataGridViewDetallePedido.AutoGenerateColumns = false;
            dataGridViewDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetallePedido.Columns.AddRange(new DataGridViewColumn[] { productoDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioUnitarioDataGridViewTextBoxColumn, subtotalDataGridViewTextBoxColumn, nombreProductoDataGridViewTextBoxColumn });
            dataGridViewDetallePedido.DataSource = itemPedidoBindingSource;
            dataGridViewDetallePedido.Location = new Point(6, 219);
            dataGridViewDetallePedido.Name = "dataGridViewDetallePedido";
            dataGridViewDetallePedido.ReadOnly = true;
            dataGridViewDetallePedido.Size = new Size(443, 202);
            dataGridViewDetallePedido.TabIndex = 4;
            // 
            // itemPedidoBindingSource
            // 
            itemPedidoBindingSource.DataSource = typeof(Entities.ItemPedido);
            // 
            // productoDataGridViewTextBoxColumn
            // 
            productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmRegistroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 574);
            Controls.Add(groupBox2);
            Controls.Add(btnExportar);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Name = "FrmRegistroPedidos";
            Text = "FrmRegistroPedidos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidosHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedidoBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallePedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPedidoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox groupBox1;
        private Button btnExportar;
        private ComboBox cmbMDP;
        private DateTimePicker dtpFechaBuscar;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNombreCliente;
        private Button btnBuscar;
        private DataGridView dataGridViewPedidosHistorial;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pagoParcialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private BindingSource pedidoBindingSource;
        private GroupBox groupBox2;
        private Label lblValorTotal;
        private Label lblPagoParcial;
        private Label lblFechaPedido;
        private Label lblProveedor;
        private Label label6;
        private Label label1;
        private DataGridView dataGridViewDetallePedido;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private BindingSource itemPedidoBindingSource;
    }
}