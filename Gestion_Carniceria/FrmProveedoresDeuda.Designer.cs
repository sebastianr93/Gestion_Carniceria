namespace Gestion_Carniceria
{
    partial class FrmProveedoresDeuda
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
            dataGridViewProveedoresDeuda = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuentaCorrienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            label13 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            label9 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtCorreoBuscar = new TextBox();
            txtTelefonoBuscar = new TextBox();
            txtApellidoBuscar = new TextBox();
            txtNombreBuscar = new TextBox();
            btnVolverAlMenu = new Button();
            buttonPagarDeuda = new Button();
            textBoxPagoParcial = new TextBox();
            comboBoxDeuda = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedoresDeuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProveedoresDeuda
            // 
            dataGridViewProveedoresDeuda.AutoGenerateColumns = false;
            dataGridViewProveedoresDeuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedoresDeuda.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cuentaCorrienteDataGridViewTextBoxColumn });
            dataGridViewProveedoresDeuda.DataSource = proveedorBindingSource;
            dataGridViewProveedoresDeuda.Location = new Point(265, 16);
            dataGridViewProveedoresDeuda.Name = "dataGridViewProveedoresDeuda";
            dataGridViewProveedoresDeuda.Size = new Size(748, 511);
            dataGridViewProveedoresDeuda.TabIndex = 0;
            dataGridViewProveedoresDeuda.CellContentClick += dataGridViewProveedoresDeuda_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(12, 16);
            label13.Name = "label13";
            label13.Size = new Size(135, 21);
            label13.TabIndex = 1;
            label13.Text = "Buscar Proveedor";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtCorreoBuscar);
            groupBox2.Controls.Add(txtTelefonoBuscar);
            groupBox2.Controls.Add(txtApellidoBuscar);
            groupBox2.Controls.Add(txtNombreBuscar);
            groupBox2.Location = new Point(11, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 154);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(58, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 35);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 57);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 15;
            label11.Text = "Descripción:";
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
            btnVolverAlMenu.Location = new Point(11, 243);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(149, 23);
            btnVolverAlMenu.TabIndex = 19;
            btnVolverAlMenu.Text = "Volver al Menú";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // buttonPagarDeuda
            // 
            buttonPagarDeuda.Location = new Point(164, 361);
            buttonPagarDeuda.Name = "buttonPagarDeuda";
            buttonPagarDeuda.Size = new Size(75, 23);
            buttonPagarDeuda.TabIndex = 27;
            buttonPagarDeuda.Text = "Pagar";
            buttonPagarDeuda.UseVisualStyleBackColor = true;
            buttonPagarDeuda.Click += buttonPagarDeuda_Click;
            // 
            // textBoxPagoParcial
            // 
            textBoxPagoParcial.Location = new Point(12, 361);
            textBoxPagoParcial.Name = "textBoxPagoParcial";
            textBoxPagoParcial.Size = new Size(140, 23);
            textBoxPagoParcial.TabIndex = 26;
            textBoxPagoParcial.TextChanged += textBoxPagoParcial_TextChanged;
            // 
            // comboBoxDeuda
            // 
            comboBoxDeuda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeuda.FormattingEnabled = true;
            comboBoxDeuda.Items.AddRange(new object[] { "Total", "Parcial" });
            comboBoxDeuda.Location = new Point(12, 320);
            comboBoxDeuda.Name = "comboBoxDeuda";
            comboBoxDeuda.Size = new Size(140, 23);
            comboBoxDeuda.TabIndex = 25;
            comboBoxDeuda.SelectedIndexChanged += comboBoxDeuda_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 285);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 24;
            label1.Text = "Pago Cuenta Corriente";
            // 
            // FrmProveedoresDeuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 539);
            Controls.Add(buttonPagarDeuda);
            Controls.Add(textBoxPagoParcial);
            Controls.Add(comboBoxDeuda);
            Controls.Add(label1);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(groupBox2);
            Controls.Add(label13);
            Controls.Add(dataGridViewProveedoresDeuda);
            Name = "FrmProveedoresDeuda";
            Text = "FrmProveedoresDeuda";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedoresDeuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProveedoresDeuda;
        private BindingSource proveedorBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cuentaCorrienteDataGridViewTextBoxColumn;
        private Label label13;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Label label9;
        private Label label7;
        private Label label11;
        private Label label12;
        private TextBox txtCorreoBuscar;
        private TextBox txtTelefonoBuscar;
        private TextBox txtApellidoBuscar;
        private TextBox txtNombreBuscar;
        private Button btnVolverAlMenu;
        private Button buttonPagarDeuda;
        private TextBox textBoxPagoParcial;
        private ComboBox comboBoxDeuda;
        private Label label1;
    }
}