namespace Gestion_Carniceria
{
    partial class FrmStock
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
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            txtPesoProducto = new TextBox();
            cbCategoriaProducto = new ComboBox();
            categoriaBindingSource = new BindingSource(components);
            txtCantidadProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            btnCrearProducto = new Button();
            dgvProductos = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pesoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnVolver = new Button();
            txtNombreCategoria = new TextBox();
            cbListaCategorias = new ComboBox();
            categoriaDAOBindingSource = new BindingSource(components);
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnModificarCategoría = new Button();
            btnEliminarCategoria = new Button();
            groupBox1 = new GroupBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            btnCrearCategoria = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            proveedorDAOBindingSource = new BindingSource(components);
            categoriaBindingSource1 = new BindingSource(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaDAOBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)proveedorDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(10, 36);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(147, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(10, 80);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(147, 23);
            txtDescripcionProducto.TabIndex = 4;
            // 
            // txtPesoProducto
            // 
            txtPesoProducto.Location = new Point(10, 168);
            txtPesoProducto.Name = "txtPesoProducto";
            txtPesoProducto.Size = new Size(147, 23);
            txtPesoProducto.TabIndex = 5;
            // 
            // cbCategoriaProducto
            // 
            cbCategoriaProducto.DataSource = categoriaBindingSource;
            cbCategoriaProducto.DisplayMember = "Nombre";
            cbCategoriaProducto.FormattingEnabled = true;
            cbCategoriaProducto.Location = new Point(10, 124);
            cbCategoriaProducto.Name = "cbCategoriaProducto";
            cbCategoriaProducto.Size = new Size(147, 23);
            cbCategoriaProducto.TabIndex = 6;
            cbCategoriaProducto.ValueMember = "ID";
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Entities.Categoria);
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(10, 212);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(147, 23);
            txtCantidadProducto.TabIndex = 7;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(10, 256);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(147, 23);
            txtPrecioProducto.TabIndex = 8;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(10, 285);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(75, 23);
            btnCrearProducto.TabIndex = 9;
            btnCrearProducto.Text = "Crear";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, pesoDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            dgvProductos.DataSource = productoBindingSource;
            dgvProductos.Location = new Point(12, 22);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(743, 448);
            dgvProductos.TabIndex = 10;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
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
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(12, 476);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(75, 23);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(93, 476);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(75, 23);
            btnModificarProducto.TabIndex = 12;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(680, 476);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(10, 35);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(142, 23);
            txtNombreCategoria.TabIndex = 14;
            // 
            // cbListaCategorias
            // 
            cbListaCategorias.DataSource = categoriaBindingSource;
            cbListaCategorias.DisplayMember = "Nombre";
            cbListaCategorias.FormattingEnabled = true;
            cbListaCategorias.Location = new Point(10, 122);
            cbListaCategorias.Name = "cbListaCategorias";
            cbListaCategorias.Size = new Size(142, 23);
            cbListaCategorias.TabIndex = 15;
            // 
            // categoriaDAOBindingSource
            // 
            categoriaDAOBindingSource.DataSource = typeof(Data.CategoriaDAO);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 18);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 16;
            label4.Text = "📦 Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 62);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 17;
            label5.Text = "📝 Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 150);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 18;
            label6.Text = "⚖️ Peso por Kilogramo:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 106);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 19;
            label7.Text = "📁 Categoría:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 194);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 20;
            label8.Text = "🔢 Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 238);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 21;
            label9.Text = "💲 Precio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 17);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 22;
            label10.Text = "📁 Nombre:";
            // 
            // btnModificarCategoría
            // 
            btnModificarCategoría.Location = new Point(10, 151);
            btnModificarCategoría.Name = "btnModificarCategoría";
            btnModificarCategoría.Size = new Size(69, 23);
            btnModificarCategoría.TabIndex = 23;
            btnModificarCategoría.Text = "Modificar";
            btnModificarCategoría.UseVisualStyleBackColor = true;
            btnModificarCategoría.Click += btnModificarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(85, 151);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(67, 23);
            btnEliminarCategoria.TabIndex = 24;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPesoProducto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCrearProducto);
            groupBox1.Controls.Add(txtPrecioProducto);
            groupBox1.Controls.Add(txtCantidadProducto);
            groupBox1.Controls.Add(cbCategoriaProducto);
            groupBox1.Controls.Add(txtDescripcionProducto);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 319);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(-1, -3);
            label11.Name = "label11";
            label11.Size = new Size(175, 21);
            label11.TabIndex = 26;
            label11.Text = "Crear/Editar Productos";
            label11.Click += label11_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(btnCrearCategoria);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnEliminarCategoria);
            groupBox2.Controls.Add(btnModificarCategoría);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cbListaCategorias);
            groupBox2.Controls.Add(txtNombreCategoria);
            groupBox2.Location = new Point(12, 337);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 184);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.Location = new Point(10, 93);
            btnCrearCategoria.Name = "btnCrearCategoria";
            btnCrearCategoria.Size = new Size(69, 23);
            btnCrearCategoria.TabIndex = 27;
            btnCrearCategoria.Text = "Crear";
            btnCrearCategoria.UseVisualStyleBackColor = true;
            btnCrearCategoria.Click += btnCrearCategoria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -4);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 27;
            label1.Text = "Crear/Editar Categorías";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnVolver);
            groupBox3.Controls.Add(btnModificarProducto);
            groupBox3.Controls.Add(btnEliminarProducto);
            groupBox3.Controls.Add(dgvProductos);
            groupBox3.Location = new Point(186, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(766, 509);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, -3);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 14;
            label3.Text = "Lista";
            // 
            // proveedorDAOBindingSource
            // 
            proveedorDAOBindingSource.DataSource = typeof(ProveedorDAO);
            // 
            // categoriaBindingSource1
            // 
            categoriaBindingSource1.DataSource = typeof(Entities.Categoria);
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 68);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 19);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "Peso";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(79, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 19);
            radioButton2.TabIndex = 30;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cantidad";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 533);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmStock";
            Text = "Stock de Productos";
            Load += FrmStock_Load;
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaDAOBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)proveedorDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private TextBox txtPesoProducto;
        private ComboBox cbCategoriaProducto;
        private TextBox txtCantidadProducto;
        private TextBox txtPrecioProducto;
        private Button btnCrearProducto;
        private DataGridView dgvProductos;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnVolver;
        private TextBox txtNombreCategoria;
        private ComboBox cbListaCategorias;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnModificarCategoría;
        private Button btnEliminarCategoria;
        private GroupBox groupBox1;
        private Label label11;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label3;
        private Button btnCrearCategoria;
        private BindingSource categoriaDAOBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private BindingSource productoBindingSource;
        private BindingSource categoriaBindingSource;
        private BindingSource proveedorDAOBindingSource;
        private BindingSource categoriaBindingSource1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}