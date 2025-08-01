﻿namespace Gestion_Carniceria
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
            cbClientes = new ComboBox();
            clienteDAOBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            cbMediosDePago = new ComboBox();
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
            btnConfirmarVenta = new Button();
            btnVolver = new Button();
            label5 = new Label();
            lblMontoTotal = new Label();
            groupBox1 = new GroupBox();
            checkPagoParcial = new CheckBox();
            txtPagoParcial = new TextBox();
            txtAgregarProducto = new TextBox();
            label6 = new Label();
            lblTipoMDP = new Label();
            btnQuitarItem = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cbClientes
            // 
            cbClientes.DataSource = clienteDAOBindingSource;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(10, 38);
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
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 20);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Medio de Pago:";
            // 
            // cbMediosDePago
            // 
            cbMediosDePago.FormattingEnabled = true;
            cbMediosDePago.Location = new Point(147, 38);
            cbMediosDePago.Name = "cbMediosDePago";
            cbMediosDePago.Size = new Size(131, 23);
            cbMediosDePago.TabIndex = 4;
            cbMediosDePago.SelectedIndexChanged += cbMediosDePago_SelectedIndexChanged;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(6, 37);
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
            // dgvItemsVenta
            // 
            dgvItemsVenta.AllowUserToAddRows = false;
            dgvItemsVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsVenta.Location = new Point(10, 66);
            dgvItemsVenta.Name = "dgvItemsVenta";
            dgvItemsVenta.ReadOnly = true;
            dgvItemsVenta.Size = new Size(484, 353);
            dgvItemsVenta.TabIndex = 10;
            dgvItemsVenta.CellContentClick += dgvItemsVenta_CellContentClick;
            // 
            // itemVentaBindingSource
            // 
            itemVentaBindingSource.DataSource = typeof(Entities.ItemVenta);
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(169, 453);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(109, 23);
            btnConfirmarVenta.TabIndex = 11;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(403, 474);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(62, 23);
            btnVolver.TabIndex = 12;
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
            // txtPagoParcial
            // 
            txtPagoParcial.Location = new Point(10, 454);
            txtPagoParcial.Name = "txtPagoParcial";
            txtPagoParcial.Size = new Size(100, 23);
            txtPagoParcial.TabIndex = 17;
            // 
            // txtAgregarProducto
            // 
            txtAgregarProducto.Location = new Point(263, 38);
            txtAgregarProducto.Name = "txtAgregarProducto";
            txtAgregarProducto.Size = new Size(117, 23);
            txtAgregarProducto.TabIndex = 18;
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
            // lblTipoMDP
            // 
            lblTipoMDP.AutoSize = true;
            lblTipoMDP.Location = new Point(284, 41);
            lblTipoMDP.Name = "lblTipoMDP";
            lblTipoMDP.Size = new Size(61, 15);
            lblTipoMDP.TabIndex = 20;
            lblTipoMDP.Text = "Ajuste (%)";
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
            groupBox2.Location = new Point(6, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 456);
            groupBox2.TabIndex = 22;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnQuitarItem);
            groupBox3.Controls.Add(lblTipoMDP);
            groupBox3.Controls.Add(txtPagoParcial);
            groupBox3.Controls.Add(checkPagoParcial);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(btnConfirmarVenta);
            groupBox3.Controls.Add(dgvItemsVenta);
            groupBox3.Controls.Add(cbMediosDePago);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cbClientes);
            groupBox3.Location = new Point(471, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 487);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, -6);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 24;
            label7.Text = "Nueva Venta";
            // 
            // FrmPedidoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 507);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Name = "FrmPedidoClientes";
            Text = "Nueva Venta";
            FormClosing += FrmPedidoClientes_FormClosing;
            Load += FrmPedidoClientes_Load;
            ((System.ComponentModel.ISupportInitialize)clienteDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbClientes;
        private Label label2;
        private Label label3;
        private ComboBox cbMediosDePago;
        private TextBox txtBuscarProducto;
        private DataGridView dgvProductos;
        private Button btnBuscarProducto;
        private Button btnAgregarProducto;
        private DataGridView dgvItemsVenta;
        private Button btnConfirmarVenta;
        private Button btnVolver;
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
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox3;
        private Label label7;
    }
}