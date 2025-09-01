using System.Windows.Forms;

namespace Gestion_Carniceria
{
    partial class FrmRegistroVentas : Form  // <-- Acá agregué la herencia de Form
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvVentas;
        private TextBox txtBuscarCliente;
        private Button btnBuscar;
        private Button btnVolverAlMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvVentas = new DataGridView();
            ventaBindingSource = new BindingSource(components);
            btnBuscar = new Button();
            btnVolverAlMenu = new Button();
            ventaDAOBindingSource = new BindingSource(components);
            dgvDetalleVentaProducto = new DataGridView();
            productoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemVentaBindingSource = new BindingSource(components);
            ventaProductoDAOBindingSource = new BindingSource(components);
            txtNombreCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaBuscar = new DateTimePicker();
            cmbMDP = new ComboBox();
            groupBox1 = new GroupBox();
            btnExportar = new Button();
            label5 = new Label();
            groupBox2 = new GroupBox();
            lblValorTotal = new Label();
            lblMontoAbonado = new Label();
            lblFechaVenta = new Label();
            lblNombreCliente = new Label();
            label6 = new Label();
            label1 = new Label();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pagoParcialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DeudaCompra = new DataGridViewTextBoxColumn();
            FormatoPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVentaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaProductoDAOBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, NombreCliente, fechaDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn, pagoParcialDataGridViewTextBoxColumn, DeudaCompra, FormatoPago });
            dgvVentas.DataSource = ventaBindingSource;
            dgvVentas.Location = new Point(6, 67);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.Size = new Size(640, 354);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            // 
            // ventaBindingSource
            // 
            ventaBindingSource.DataSource = typeof(Venta);
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
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(950, 451);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(75, 23);
            btnVolverAlMenu.TabIndex = 3;
            btnVolverAlMenu.Text = "Volver";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // ventaDAOBindingSource
            // 
            ventaDAOBindingSource.DataSource = typeof(Data.VentaDAO);
            // 
            // dgvDetalleVentaProducto
            // 
            dgvDetalleVentaProducto.AutoGenerateColumns = false;
            dgvDetalleVentaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVentaProducto.Columns.AddRange(new DataGridViewColumn[] { productoDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioUnitarioDataGridViewTextBoxColumn, subtotalDataGridViewTextBoxColumn });
            dgvDetalleVentaProducto.DataSource = itemVentaBindingSource;
            dgvDetalleVentaProducto.Location = new Point(6, 219);
            dgvDetalleVentaProducto.Name = "dgvDetalleVentaProducto";
            dgvDetalleVentaProducto.ReadOnly = true;
            dgvDetalleVentaProducto.Size = new Size(443, 202);
            dgvDetalleVentaProducto.TabIndex = 4;
            dgvDetalleVentaProducto.CellContentClick += dgvDetalleVentaProducto_CellContentClick;
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
            // itemVentaBindingSource
            // 
            itemVentaBindingSource.DataSource = typeof(Entities.ItemVenta);
            // 
            // ventaProductoDAOBindingSource
            // 
            ventaProductoDAOBindingSource.DataSource = typeof(Data.VentaProductoDAO);
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(6, 38);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(117, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Cliente:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 19);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 11;
            label4.Text = "Medio de Pago:";
            // 
            // dtpFechaBuscar
            // 
            dtpFechaBuscar.Checked = false;
            dtpFechaBuscar.Location = new Point(129, 38);
            dtpFechaBuscar.Name = "dtpFechaBuscar";
            dtpFechaBuscar.Size = new Size(211, 23);
            dtpFechaBuscar.TabIndex = 12;
            // 
            // cmbMDP
            // 
            cmbMDP.FormattingEnabled = true;
            cmbMDP.Location = new Point(346, 38);
            cmbMDP.Name = "cmbMDP";
            cmbMDP.Size = new Size(121, 23);
            cmbMDP.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportar);
            groupBox1.Controls.Add(cmbMDP);
            groupBox1.Controls.Add(dtpFechaBuscar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(dgvVentas);
            groupBox1.Location = new Point(9, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 456);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(476, 427);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 17;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(9, 9);
            label5.Name = "label5";
            label5.Size = new Size(263, 25);
            label5.TabIndex = 15;
            label5.Text = "Todas las Ventas Registradas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblValorTotal);
            groupBox2.Controls.Add(lblMontoAbonado);
            groupBox2.Controls.Add(lblFechaVenta);
            groupBox2.Controls.Add(lblNombreCliente);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvDetalleVentaProducto);
            groupBox2.Location = new Point(738, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 427);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(6, 95);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(64, 25);
            lblValorTotal.TabIndex = 11;
            lblValorTotal.Text = "label7";
            // 
            // lblMontoAbonado
            // 
            lblMontoAbonado.AutoSize = true;
            lblMontoAbonado.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMontoAbonado.ForeColor = Color.Green;
            lblMontoAbonado.Location = new Point(9, 144);
            lblMontoAbonado.Name = "lblMontoAbonado";
            lblMontoAbonado.Size = new Size(71, 30);
            lblMontoAbonado.TabIndex = 10;
            lblMontoAbonado.Text = "label7";
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFechaVenta.Location = new Point(239, 11);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(64, 25);
            lblFechaVenta.TabIndex = 9;
            lblFechaVenta.Text = "label7";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(6, 38);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(74, 30);
            lblNombreCliente.TabIndex = 8;
            lblNombreCliente.Text = "label7";
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
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, -6);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 6;
            label1.Text = "Detalles de la Venta";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NombreCliente
            // 
            NombreCliente.DataPropertyName = "NombreCliente";
            NombreCliente.HeaderText = "Cliente";
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoParcialDataGridViewTextBoxColumn
            // 
            pagoParcialDataGridViewTextBoxColumn.DataPropertyName = "PagoParcial";
            pagoParcialDataGridViewTextBoxColumn.HeaderText = "PagoParcial";
            pagoParcialDataGridViewTextBoxColumn.Name = "pagoParcialDataGridViewTextBoxColumn";
            pagoParcialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeudaCompra
            // 
            DeudaCompra.DataPropertyName = "DeudaCompra";
            DeudaCompra.HeaderText = "DeudaCompra";
            DeudaCompra.Name = "DeudaCompra";
            DeudaCompra.ReadOnly = true;
            // 
            // FormatoPago
            // 
            FormatoPago.DataPropertyName = "FormatoPago";
            FormatoPago.HeaderText = "FormatoPago";
            FormatoPago.Name = "FormatoPago";
            FormatoPago.ReadOnly = true;
            // 
            // FrmRegistroVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 480);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(btnVolverAlMenu);
            Name = "FrmRegistroVentas";
            Text = "Registro de Ventas";
            Load += FrmRegistroVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVentaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaProductoDAOBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private BindingSource ventaDAOBindingSource;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private BindingSource ventaBindingSource;
        private DataGridView dgvDetalleVentaProducto;
        private BindingSource ventaProductoDAOBindingSource;
        private BindingSource itemVentaBindingSource;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private TextBox txtNombreCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaBuscar;
        private ComboBox cmbMDP;
        private GroupBox groupBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private Label label1;
        private Button btnExportar;
        private Label lblValorTotal;
        private Label lblMontoAbonado;
        private Label lblFechaVenta;
        private Label lblNombreCliente;
        private DataGridViewTextBoxColumn formatoPagoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pagoParcialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DeudaCompra;
        private DataGridViewTextBoxColumn FormatoPago;
    }
}
