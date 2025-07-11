namespace Gestion_Carniceria
{
    partial class FrmProveedores
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
            btnVolverAlMenuP = new Button();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnBuscarProveedor = new Button();
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
            btnEditarProveedor = new Button();
            btnEliminarProveedor = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            txtCuentaCorriente = new TextBox();
            label13 = new Label();
            txtDescripcion = new TextBox();
            btnCrearProveedor = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            dgvProveedor = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuentaCorrienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            proveedorDAOBindingSource = new BindingSource(components);
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorDAOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolverAlMenuP
            // 
            btnVolverAlMenuP.Location = new Point(278, 142);
            btnVolverAlMenuP.Name = "btnVolverAlMenuP";
            btnVolverAlMenuP.Size = new Size(149, 23);
            btnVolverAlMenuP.TabIndex = 27;
            btnVolverAlMenuP.Text = "Volver al Menú";
            btnVolverAlMenuP.UseVisualStyleBackColor = true;
            btnVolverAlMenuP.Click += btnVolverAlMenuP_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(456, 16);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 26;
            label8.Text = "Buscar Proveedor";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarProveedor);
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
            groupBox2.Location = new Point(448, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 154);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Location = new Point(126, 118);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(100, 24);
            btnBuscarProveedor.TabIndex = 11;
            btnBuscarProveedor.Text = "Buscar";
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 12);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 9;
            label7.Text = "Teléfono:";
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
            // btnEditarProveedor
            // 
            btnEditarProveedor.Location = new Point(278, 98);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(149, 23);
            btnEditarProveedor.TabIndex = 24;
            btnEditarProveedor.Text = "Editar Seleccionado";
            btnEditarProveedor.UseVisualStyleBackColor = true;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(278, 54);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(149, 23);
            btnEliminarProveedor.TabIndex = 23;
            btnEliminarProveedor.Text = "Eliminar Seleccionado";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(176, 21);
            label6.TabIndex = 22;
            label6.Text = "Crear/Editar Proveedor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtCuentaCorriente);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnCrearProveedor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 154);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 101);
            label14.Name = "label14";
            label14.Size = new Size(97, 15);
            label14.TabIndex = 15;
            label14.Text = "Cuenta Corriente";
            // 
            // txtCuentaCorriente
            // 
            txtCuentaCorriente.Location = new Point(20, 118);
            txtCuentaCorriente.Name = "txtCuentaCorriente";
            txtCuentaCorriente.Size = new Size(100, 23);
            txtCuentaCorriente.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(145, 57);
            label13.Name = "label13";
            label13.Size = new Size(69, 15);
            label13.TabIndex = 13;
            label13.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(126, 75);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 12;
            // 
            // btnCrearProveedor
            // 
            btnCrearProveedor.Location = new Point(126, 117);
            btnCrearProveedor.Name = "btnCrearProveedor";
            btnCrearProveedor.Size = new Size(100, 23);
            btnCrearProveedor.TabIndex = 11;
            btnCrearProveedor.Text = "Crear";
            btnCrearProveedor.UseVisualStyleBackColor = true;
            btnCrearProveedor.Click += btnCrearProveedor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 56);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 10;
            label5.Text = "Correo Electrónico:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre(s):";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(20, 74);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(126, 31);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AllowUserToOrderColumns = true;
            dgvProveedor.AutoGenerateColumns = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cuentaCorrienteDataGridViewTextBoxColumn });
            dgvProveedor.DataSource = proveedorBindingSource;
            dgvProveedor.Location = new Point(12, 184);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.Size = new Size(684, 237);
            dgvProveedor.TabIndex = 20;
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
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuentaCorrienteDataGridViewTextBoxColumn
            // 
            cuentaCorrienteDataGridViewTextBoxColumn.DataPropertyName = "CuentaCorriente";
            cuentaCorrienteDataGridViewTextBoxColumn.HeaderText = "CuentaCorriente";
            cuentaCorrienteDataGridViewTextBoxColumn.Name = "cuentaCorrienteDataGridViewTextBoxColumn";
            cuentaCorrienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(Proveedor);
            // 
            // proveedorDAOBindingSource
            // 
            proveedorDAOBindingSource.DataSource = typeof(ProveedorDAO);
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 453);
            Controls.Add(btnVolverAlMenuP);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvProveedor);
            Name = "FrmProveedores";
            Text = "Grilla de Proveedores";
            Load += FrmProveedores_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorDAOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverAlMenuP;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnBuscarProveedor;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtDNIBuscar;
        private TextBox txtCorreoBuscar;
        private TextBox txtTelefonoBuscar;
        private TextBox txtApellidoBuscar;
        private TextBox txtNombreBuscar;
        private Button btnEditarProveedor;
        private Button btnEliminarProveedor;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnCrearProveedor;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private DataGridView dgvProveedor;
        private BindingSource proveedorDAOBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cuentaCorrienteDataGridViewTextBoxColumn;
        private BindingSource proveedorBindingSource;
        private Label label13;
        private TextBox txtDescripcion;
        private TextBox txtCuentaCorriente;
        private Label label14;
    }
}