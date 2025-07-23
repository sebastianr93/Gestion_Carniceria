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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedoresDeuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProveedoresDeuda
            // 
            dataGridViewProveedoresDeuda.AutoGenerateColumns = false;
            dataGridViewProveedoresDeuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedoresDeuda.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cuentaCorrienteDataGridViewTextBoxColumn });
            dataGridViewProveedoresDeuda.DataSource = proveedorBindingSource;
            dataGridViewProveedoresDeuda.Location = new Point(6, 24);
            dataGridViewProveedoresDeuda.Name = "dataGridViewProveedoresDeuda";
            dataGridViewProveedoresDeuda.Size = new Size(644, 366);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtCorreoBuscar);
            groupBox2.Controls.Add(txtTelefonoBuscar);
            groupBox2.Controls.Add(txtApellidoBuscar);
            groupBox2.Controls.Add(txtNombreBuscar);
            groupBox2.Location = new Point(12, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 154);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(167, 127);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 109);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 12;
            label9.Text = "Correo Electrónico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 21);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "Teléfono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 65);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 15;
            label11.Text = "Descripción:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 21);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 16;
            label12.Text = "Nombre(s):";
            // 
            // txtCorreoBuscar
            // 
            txtCorreoBuscar.Location = new Point(8, 127);
            txtCorreoBuscar.Name = "txtCorreoBuscar";
            txtCorreoBuscar.Size = new Size(153, 23);
            txtCorreoBuscar.TabIndex = 18;
            // 
            // txtTelefonoBuscar
            // 
            txtTelefonoBuscar.Location = new Point(127, 39);
            txtTelefonoBuscar.Name = "txtTelefonoBuscar";
            txtTelefonoBuscar.Size = new Size(111, 23);
            txtTelefonoBuscar.TabIndex = 19;
            // 
            // txtApellidoBuscar
            // 
            txtApellidoBuscar.Location = new Point(7, 83);
            txtApellidoBuscar.Name = "txtApellidoBuscar";
            txtApellidoBuscar.Size = new Size(235, 23);
            txtApellidoBuscar.TabIndex = 20;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(8, 39);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(113, 23);
            txtNombreBuscar.TabIndex = 21;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(185, 394);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(75, 23);
            btnVolverAlMenu.TabIndex = 19;
            btnVolverAlMenu.Text = "Volver";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // buttonPagarDeuda
            // 
            buttonPagarDeuda.Location = new Point(163, 85);
            buttonPagarDeuda.Name = "buttonPagarDeuda";
            buttonPagarDeuda.Size = new Size(75, 23);
            buttonPagarDeuda.TabIndex = 27;
            buttonPagarDeuda.Text = "Pagar";
            buttonPagarDeuda.UseVisualStyleBackColor = true;
            buttonPagarDeuda.Click += buttonPagarDeuda_Click;
            // 
            // textBoxPagoParcial
            // 
            textBoxPagoParcial.Location = new Point(97, 56);
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
            comboBoxDeuda.Location = new Point(97, 27);
            comboBoxDeuda.Name = "comboBoxDeuda";
            comboBoxDeuda.Size = new Size(140, 23);
            comboBoxDeuda.TabIndex = 25;
            comboBoxDeuda.SelectedIndexChanged += comboBoxDeuda_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridViewProveedoresDeuda);
            groupBox1.Location = new Point(266, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 405);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 0);
            label2.Name = "label2";
            label2.Size = new Size(302, 21);
            label2.TabIndex = 29;
            label2.Text = "Lista de Proveedores con Pagos a Recibir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 30);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 29;
            label3.Text = "Total o Parcial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 59);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 30;
            label4.Text = "Monto Parcial:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(buttonPagarDeuda);
            groupBox3.Controls.Add(textBoxPagoParcial);
            groupBox3.Controls.Add(comboBoxDeuda);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 114);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 31;
            label1.Text = "Cancelar Deuda";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(135, 21);
            label13.TabIndex = 32;
            label13.Text = "Buscar Proveedor";
            // 
            // FrmProveedoresDeuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 427);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(groupBox2);
            Name = "FrmProveedoresDeuda";
            Text = "Cuenta Corriente de Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedoresDeuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private Label label13;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Label label1;
    }
}