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
            nombreClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemVentaBindingSource = new BindingSource(components);
            ventaProductoDAOBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox1 = new TextBox();
            textBoxFecha = new TextBox();
            textBoxFP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formatoPagoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pagoParcialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVentaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaProductoDAOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, formatoPagoDataGridViewTextBoxColumn, nombreClienteDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn, pagoParcialDataGridViewTextBoxColumn });
            dgvVentas.DataSource = ventaBindingSource;
            dgvVentas.Location = new Point(20, 131);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(687, 354);
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
            btnBuscar.Location = new Point(176, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 41);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(20, 491);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(75, 27);
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
            dgvDetalleVentaProducto.Location = new Point(727, 131);
            dgvDetalleVentaProducto.Name = "dgvDetalleVentaProducto";
            dgvDetalleVentaProducto.Size = new Size(442, 158);
            dgvDetalleVentaProducto.TabIndex = 4;
            dgvDetalleVentaProducto.CellContentClick += dgvDetalleVentaProducto_CellContentClick;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 

            //columna cliente
            nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            nombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(886, 91);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 5;
            label1.Text = "Detalle Venta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 6;
            // 
            // textBoxFecha
            // 
            textBoxFecha.Location = new Point(20, 91);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(117, 23);
            textBoxFecha.TabIndex = 7;
            // 
            // textBoxFP
            // 
            textBoxFP.Location = new Point(164, 35);
            textBoxFP.Name = "textBoxFP";
            textBoxFP.Size = new Size(117, 23);
            textBoxFP.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 17);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 9;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 73);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 17);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 11;
            label4.Text = "Formato Pago";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "ID";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // formatoPagoDataGridViewTextBoxColumn
            // 
            formatoPagoDataGridViewTextBoxColumn.DataPropertyName = "FormatoPago";
            formatoPagoDataGridViewTextBoxColumn.HeaderText = "FormatoPago";
            formatoPagoDataGridViewTextBoxColumn.Name = "formatoPagoDataGridViewTextBoxColumn";
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
            // FrmRegistroVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 521);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxFP);
            Controls.Add(textBoxFecha);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgvDetalleVentaProducto);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(btnBuscar);
            Controls.Add(dgvVentas);
            Name = "FrmRegistroVentas";
            Text = "Registro de Ventas";
            Load += FrmRegistroVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVentaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVentaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaProductoDAOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private BindingSource ventaDAOBindingSource;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private BindingSource ventaBindingSource;
        private DataGridView dgvDetalleVentaProducto;
        private BindingSource ventaProductoDAOBindingSource;
        private BindingSource itemVentaBindingSource;
        private Label label1;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private TextBox textBoxFecha;
        private TextBox textBoxFP;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formatoPagoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pagoParcialDataGridViewTextBoxColumn;

    }
}
