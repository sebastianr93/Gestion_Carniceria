namespace Gestion_Carniceria
{
    partial class FrmClientesDeuda
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvClientesDeuda = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deudaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label13 = new Label();
            btnBuscar = new Button();
            label9 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtDNIBuscar = new TextBox();
            txtCorreoBuscar = new TextBox();
            txtTelefonoBuscar = new TextBox();
            txtApellidoBuscar = new TextBox();
            txtNombreBuscar = new TextBox();
            btnVolverAlMenu = new Button();
            comboBoxDeuda = new ComboBox();
            textBoxPagoParcial = new TextBox();
            buttonPagarDeuda = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnExportar = new Button();
            label2 = new Label();
            dataGridViewHistorialDeuda = new DataGridView();
            iDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formatoPagoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pagoParcialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deudaCompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ventaBindingSource = new BindingSource(components);
            ventaDAOBindingSource = new BindingSource(components);
            label5 = new Label();
            clienteBindingSource = new BindingSource(components);
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvClientesDeuda).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorialDeuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvClientesDeuda
            // 
            dgvClientesDeuda.AllowUserToAddRows = false;
            dgvClientesDeuda.AllowUserToDeleteRows = false;
            dgvClientesDeuda.AllowUserToOrderColumns = true;
            dgvClientesDeuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesDeuda.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, deudaDataGridViewTextBoxColumn });
            dgvClientesDeuda.Location = new Point(13, 16);
            dgvClientesDeuda.Name = "dgvClientesDeuda";
            dgvClientesDeuda.ReadOnly = true;
            dgvClientesDeuda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientesDeuda.Size = new Size(743, 385);
            dgvClientesDeuda.TabIndex = 0;
            dgvClientesDeuda.CellClick += dgvClientesDeuda_CellClick;

            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deudaDataGridViewTextBoxColumn
            // 
            deudaDataGridViewTextBoxColumn.DataPropertyName = "Deuda";
            deudaDataGridViewTextBoxColumn.HeaderText = "Deuda";
            deudaDataGridViewTextBoxColumn.Name = "deudaDataGridViewTextBoxColumn";
            deudaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtDNIBuscar);
            groupBox2.Controls.Add(txtCorreoBuscar);
            groupBox2.Controls.Add(txtTelefonoBuscar);
            groupBox2.Controls.Add(txtApellidoBuscar);
            groupBox2.Controls.Add(txtNombreBuscar);
            groupBox2.Location = new Point(12, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 154);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(5, -5);
            label13.Name = "label13";
            label13.Size = new Size(113, 21);
            label13.TabIndex = 22;
            label13.Text = "Buscar Cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(167, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 57);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 12;
            label9.Text = "Correo Electrónico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 16);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "Teléfono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 101);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 14;
            label10.Text = "DNI:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 57);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 15;
            label11.Text = "Apellido(s):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 16);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 16;
            label12.Text = "Nombre(s):";
            // 
            // txtDNIBuscar
            // 
            txtDNIBuscar.Location = new Point(6, 119);
            txtDNIBuscar.Name = "txtDNIBuscar";
            txtDNIBuscar.Size = new Size(114, 23);
            txtDNIBuscar.TabIndex = 17;
            // 
            // txtCorreoBuscar
            // 
            txtCorreoBuscar.Location = new Point(126, 75);
            txtCorreoBuscar.Name = "txtCorreoBuscar";
            txtCorreoBuscar.Size = new Size(116, 23);
            txtCorreoBuscar.TabIndex = 18;
            // 
            // txtTelefonoBuscar
            // 
            txtTelefonoBuscar.Location = new Point(126, 31);
            txtTelefonoBuscar.Name = "txtTelefonoBuscar";
            txtTelefonoBuscar.Size = new Size(116, 23);
            txtTelefonoBuscar.TabIndex = 19;
            // 
            // txtApellidoBuscar
            // 
            txtApellidoBuscar.Location = new Point(6, 75);
            txtApellidoBuscar.Name = "txtApellidoBuscar";
            txtApellidoBuscar.Size = new Size(114, 23);
            txtApellidoBuscar.TabIndex = 20;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(6, 31);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(114, 23);
            txtNombreBuscar.TabIndex = 21;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(179, 427);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(75, 23);
            btnVolverAlMenu.TabIndex = 1;
            btnVolverAlMenu.Text = "Volver";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // comboBoxDeuda
            // 
            comboBoxDeuda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeuda.FormattingEnabled = true;
            comboBoxDeuda.Items.AddRange(new object[] { "Total", "Parcial" });
            comboBoxDeuda.Location = new Point(93, 12);
            comboBoxDeuda.Name = "comboBoxDeuda";
            comboBoxDeuda.Size = new Size(140, 23);
            comboBoxDeuda.TabIndex = 21;
            comboBoxDeuda.SelectedIndexChanged += comboBoxDeuda_SelectedIndexChanged;
            // 
            // textBoxPagoParcial
            // 
            textBoxPagoParcial.Location = new Point(93, 41);
            textBoxPagoParcial.Name = "textBoxPagoParcial";
            textBoxPagoParcial.Size = new Size(140, 23);
            textBoxPagoParcial.TabIndex = 22;
            textBoxPagoParcial.TextChanged += textBoxPagoParcial_TextChanged;
            // 
            // buttonPagarDeuda
            // 
            buttonPagarDeuda.Location = new Point(158, 70);
            buttonPagarDeuda.Name = "buttonPagarDeuda";
            buttonPagarDeuda.Size = new Size(75, 23);
            buttonPagarDeuda.TabIndex = 23;
            buttonPagarDeuda.Text = "Pagar";
            buttonPagarDeuda.UseVisualStyleBackColor = true;
            buttonPagarDeuda.Click += buttonPagarDeuda_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 15);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 25;
            label3.Text = "Total o Parcial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 44);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 26;
            label4.Text = "Monto Parcial:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonPagarDeuda);
            groupBox1.Controls.Add(textBoxPagoParcial);
            groupBox1.Controls.Add(comboBoxDeuda);
            groupBox1.Location = new Point(8, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 104);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 27;
            label1.Text = "Cancelar Deuda";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExportar);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dgvClientesDeuda);
            groupBox3.Location = new Point(265, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(769, 436);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(681, 407);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 29;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(-5, -6);
            label2.Name = "label2";
            label2.Size = new Size(208, 21);
            label2.TabIndex = 25;
            label2.Text = "Lista de Clientes con Deuda";
            // 
            // dataGridViewHistorialDeuda
            // 
            dataGridViewHistorialDeuda.AutoGenerateColumns = false;
            dataGridViewHistorialDeuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorialDeuda.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn1, fechaDataGridViewTextBoxColumn, formatoPagoDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn, pagoParcialDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn, deudaCompraDataGridViewTextBoxColumn });
            dataGridViewHistorialDeuda.DataSource = ventaBindingSource;
            dataGridViewHistorialDeuda.Location = new Point(1051, 26);
            dataGridViewHistorialDeuda.Name = "dataGridViewHistorialDeuda";
            dataGridViewHistorialDeuda.Size = new Size(503, 402);
            dataGridViewHistorialDeuda.TabIndex = 29;
            dataGridViewHistorialDeuda.CellContentClick += dataGridViewHistorialDeuda_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
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
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // deudaCompraDataGridViewTextBoxColumn
            // 
            deudaCompraDataGridViewTextBoxColumn.DataPropertyName = "DeudaCompra";
            deudaCompraDataGridViewTextBoxColumn.HeaderText = "DeudaCompra";
            deudaCompraDataGridViewTextBoxColumn.Name = "deudaCompraDataGridViewTextBoxColumn";
            // 
            // ventaBindingSource
            // 
            ventaBindingSource.DataSource = typeof(Venta);
            // 
            // ventaDAOBindingSource
            // 
            ventaDAOBindingSource.DataSource = typeof(Data.VentaDAO);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1061, 8);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 30;
            label5.Text = "Historial Deuda";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // FrmClientesDeuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 533);
            Controls.Add(label5);
            Controls.Add(dataGridViewHistorialDeuda);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(groupBox2);
            Name = "FrmClientesDeuda";
            Text = "Clientes con Deuda";
            Load += FrmClientesDeuda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientesDeuda).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorialDeuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientesDeuda;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label7;
        private TextBox txtDNIBuscar;
        private TextBox txtCorreoBuscar;
        private TextBox txtTelefonoBuscar;
        private TextBox txtApellidoBuscar;
        private TextBox txtNombreBuscar;
        private Button btnVolverAlMenu;
        private ComboBox comboBoxDeuda;
        private TextBox textBoxPagoParcial;
        private Button buttonPagarDeuda;
        private Label label13;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox3;
        private Label label2;
        private Button btnExportar;
        private DataGridView dataGridViewHistorialDeuda;
        private Label label5;
        private BindingSource ventaDAOBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deudaDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formatoPagoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pagoParcialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deudaCompraDataGridViewTextBoxColumn;
        private BindingSource ventaBindingSource;
    }
}
