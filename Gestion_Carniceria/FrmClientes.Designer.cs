namespace Gestion_Carniceria
{
    partial class FrmClientes
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
            dgvClientes = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deudaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDNI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCrearCliente = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btnEliminarCliente = new Button();
            btnEditarCliente = new Button();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtDNIBuscar = new TextBox();
            txtCorreoBuscar = new TextBox();
            txtTelefonoBuscar = new TextBox();
            txtApellidoBuscar = new TextBox();
            txtNombreBuscar = new TextBox();
            btnVolverAlMenu = new Button();
            clienteBindingSource1 = new BindingSource(components);
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
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
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(20, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(126, 31);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(126, 75);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 4;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(20, 119);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 101);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 8;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 12);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 57);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 10;
            label5.Text = "Correo Electrónico:";
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.Location = new Point(126, 118);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(100, 23);
            btnCrearCliente.TabIndex = 11;
            btnCrearCliente.Text = "Crear";
            btnCrearCliente.UseVisualStyleBackColor = true;
            btnCrearCliente.Click += btnCrearCliente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 154);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 14;
            label6.Text = "Crear/Editar Cliente";
            label6.Click += label6_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(12, 184);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(149, 23);
            btnEliminarCliente.TabIndex = 15;
            btnEliminarCliente.Text = "Eliminar Seleccionado";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(12, 213);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(149, 23);
            btnEditarCliente.TabIndex = 16;
            btnEditarCliente.Text = "Editar Seleccionado";
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 12);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 9;
            label7.Text = "Teléfono:";
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
            groupBox2.Location = new Point(12, 254);
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
            label9.TabIndex = 10;
            label9.Text = "Correo Electrónico:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 101);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 8;
            label10.Text = "DNI:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 57);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 7;
            label11.Text = "Apellido(s):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 13);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 6;
            label12.Text = "Nombre(s):";
            // 
            // txtDNIBuscar
            // 
            txtDNIBuscar.Location = new Point(20, 119);
            txtDNIBuscar.Name = "txtDNIBuscar";
            txtDNIBuscar.Size = new Size(100, 23);
            txtDNIBuscar.TabIndex = 5;
            // 
            // txtCorreoBuscar
            // 
            txtCorreoBuscar.Location = new Point(126, 75);
            txtCorreoBuscar.Name = "txtCorreoBuscar";
            txtCorreoBuscar.Size = new Size(100, 23);
            txtCorreoBuscar.TabIndex = 4;
            // 
            // txtTelefonoBuscar
            // 
            txtTelefonoBuscar.Location = new Point(126, 31);
            txtTelefonoBuscar.Name = "txtTelefonoBuscar";
            txtTelefonoBuscar.Size = new Size(100, 23);
            txtTelefonoBuscar.TabIndex = 3;
            // 
            // txtApellidoBuscar
            // 
            txtApellidoBuscar.Location = new Point(20, 75);
            txtApellidoBuscar.Name = "txtApellidoBuscar";
            txtApellidoBuscar.Size = new Size(100, 23);
            txtApellidoBuscar.TabIndex = 2;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(20, 31);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(100, 23);
            txtNombreBuscar.TabIndex = 1;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(12, 414);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(149, 23);
            btnVolverAlMenu.TabIndex = 19;
            btnVolverAlMenu.Text = "Volver al Menú";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Cliente);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 246);
            label13.Name = "label13";
            label13.Size = new Size(113, 21);
            label13.TabIndex = 20;
            label13.Text = "Buscar Cliente";
            label13.Click += label13_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 447);
            Controls.Add(label13);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(groupBox2);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Name = "FrmClientes";
            Text = "Grilla de Clientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDNI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCrearCliente;
        private GroupBox groupBox1;
        private Label label6;
        private Button btnEliminarCliente;
        private Button btnEditarCliente;
        private Label label7;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtDNIBuscar;
        private TextBox txtCorreoBuscar;
        private TextBox txtTelefonoBuscar;
        private TextBox txtApellidoBuscar;
        private TextBox txtNombreBuscar;
        private Button btnVolverAlMenu;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deudaDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private BindingSource clienteBindingSource1;
        private Label label13;
    }
}