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
            dgvClientes = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deudaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
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
            label13 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, deudaDataGridViewTextBoxColumn });
            dgvClientes.DataSource = clienteBindingSource;
            dgvClientes.Location = new Point(266, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(743, 423);
            dgvClientes.TabIndex = 0;
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
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(12, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 154);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(126, 118);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 24);
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
            label7.Location = new Point(126, 12);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "Teléfono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 101);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 14;
            label10.Text = "DNI:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 57);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 15;
            label11.Text = "Apellido(s):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 13);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 16;
            label12.Text = "Nombre(s):";
            // 
            // txtDNIBuscar
            // 
            txtDNIBuscar.Location = new Point(20, 119);
            txtDNIBuscar.Name = "txtDNIBuscar";
            txtDNIBuscar.Size = new Size(100, 23);
            txtDNIBuscar.TabIndex = 17;
            // 
            // txtCorreoBuscar
            // 
            txtCorreoBuscar.Location = new Point(126, 75);
            txtCorreoBuscar.Name = "txtCorreoBuscar";
            txtCorreoBuscar.Size = new Size(100, 23);
            txtCorreoBuscar.TabIndex = 18;
            // 
            // txtTelefonoBuscar
            // 
            txtTelefonoBuscar.Location = new Point(126, 31);
            txtTelefonoBuscar.Name = "txtTelefonoBuscar";
            txtTelefonoBuscar.Size = new Size(100, 23);
            txtTelefonoBuscar.TabIndex = 19;
            // 
            // txtApellidoBuscar
            // 
            txtApellidoBuscar.Location = new Point(20, 75);
            txtApellidoBuscar.Name = "txtApellidoBuscar";
            txtApellidoBuscar.Size = new Size(100, 23);
            txtApellidoBuscar.TabIndex = 20;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(20, 31);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(100, 23);
            txtNombreBuscar.TabIndex = 21;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(12, 220);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(149, 23);
            btnVolverAlMenu.TabIndex = 1;
            btnVolverAlMenu.Text = "Volver al Menú";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(19, 30);
            label13.Name = "label13";
            label13.Size = new Size(113, 21);
            label13.TabIndex = 0;
            label13.Text = "Buscar Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(19, 264);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 18;
            label1.Text = "Pago Deuda";
            // 
            // button1
            // 
            button1.Location = new Point(12, 306);
            button1.Name = "button1";
            button1.Size = new Size(87, 30);
            button1.TabIndex = 19;
            button1.Text = "Parcial";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(138, 306);
            button2.Name = "button2";
            button2.Size = new Size(91, 30);
            button2.TabIndex = 20;
            button2.Text = "Total";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmClientesDeuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 447);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(groupBox2);
            Controls.Add(dgvClientes);
            Name = "FrmClientesDeuda";
            Text = "Clientes con Deuda";
            Load += FrmClientesDeuda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deudaDataGridViewTextBoxColumn;
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
        private Label label13;
        private BindingSource clienteBindingSource;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
