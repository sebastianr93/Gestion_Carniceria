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
            productoBindingSource1 = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            btnEliminarProducto = new Button();
            btnVolver = new Button();
            txtNombreCategoria = new TextBox();
            cbListaCategorias = new ComboBox();
            categoriaDAOBindingSource = new BindingSource(components);
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblPrecioTipo = new Label();
            label10 = new Label();
            btnModificarCategoría = new Button();
            btnEliminarCategoria = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            txtPrecioCosto = new TextBox();
            rbTipoPeso = new RadioButton();
            rbTipoUnidad = new RadioButton();
            label11 = new Label();
            groupBox2 = new GroupBox();
            btnCrearCategoria = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnOrdenarPrecio = new Button();
            btnOrdenarID = new Button();
            btnOrdenarNombre = new Button();
            label12 = new Label();
            label9 = new Label();
            btnBuscar = new Button();
            txtBuscarProducto = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            label2 = new Label();
            lblNombreProducto = new Label();
            lblPrecioProducto = new Label();
            lblStockProducto = new Label();
            lblCategoriaProducto = new Label();
            lblDescripcionProducto = new Label();
            lblIDProducto = new Label();
            proveedorDAOBindingSource = new BindingSource(components);
            categoriaBindingSource1 = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PrecioCosto = new DataGridViewTextBoxColumn();
            pesoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaDAOBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            txtPesoProducto.Location = new Point(10, 195);
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
            txtCantidadProducto.Location = new Point(10, 239);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(147, 23);
            txtCantidadProducto.TabIndex = 7;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(10, 283);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(147, 23);
            txtPrecioProducto.TabIndex = 8;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(4, 357);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(69, 23);
            btnCrearProducto.TabIndex = 9;
            btnCrearProducto.Text = "Crear";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, Nombre, precioDataGridViewTextBoxColumn, PrecioCosto, pesoDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, Categoria });
            dgvProductos.DataSource = productoBindingSource1;
            dgvProductos.Location = new Point(12, 48);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(843, 343);
            dgvProductos.TabIndex = 10;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellEndEdit += dgvProductos_CellEndEdit;
            // 
            // productoBindingSource1
            // 
            productoBindingSource1.DataSource = typeof(Producto);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(362, 19);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(77, 23);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(875, 522);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(77, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(10, 54);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(142, 23);
            txtNombreCategoria.TabIndex = 14;
            // 
            // cbListaCategorias
            // 
            cbListaCategorias.DataSource = categoriaBindingSource;
            cbListaCategorias.DisplayMember = "Nombre";
            cbListaCategorias.FormattingEnabled = true;
            cbListaCategorias.Location = new Point(10, 112);
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
            label6.Location = new Point(10, 177);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 18;
            label6.Text = "⚖️ Cantidad en Kg:";
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
            label8.Location = new Point(10, 221);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 20;
            label8.Text = "🔢 Cantidad en Unidad:";
            // 
            // lblPrecioTipo
            // 
            lblPrecioTipo.AutoSize = true;
            lblPrecioTipo.Location = new Point(6, 265);
            lblPrecioTipo.Name = "lblPrecioTipo";
            lblPrecioTipo.Size = new Size(53, 15);
            lblPrecioTipo.TabIndex = 21;
            lblPrecioTipo.Text = "💲 Precio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 36);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 22;
            label10.Text = "📁 Nombre:";
            // 
            // btnModificarCategoría
            // 
            btnModificarCategoría.Location = new Point(83, 83);
            btnModificarCategoría.Name = "btnModificarCategoría";
            btnModificarCategoría.Size = new Size(69, 23);
            btnModificarCategoría.TabIndex = 23;
            btnModificarCategoría.Text = "Editar";
            btnModificarCategoría.UseVisualStyleBackColor = true;
            btnModificarCategoría.Click += btnModificarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(10, 141);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(67, 23);
            btnEliminarCategoria.TabIndex = 24;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtPrecioCosto);
            groupBox1.Controls.Add(rbTipoPeso);
            groupBox1.Controls.Add(rbTipoUnidad);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblPrecioTipo);
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
            groupBox1.Size = new Size(168, 389);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 309);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 32;
            label13.Text = "💲 Precio Costo";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(10, 328);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(147, 23);
            txtPrecioCosto.TabIndex = 31;
            // 
            // rbTipoPeso
            // 
            rbTipoPeso.AutoSize = true;
            rbTipoPeso.Location = new Point(82, 153);
            rbTipoPeso.Name = "rbTipoPeso";
            rbTipoPeso.Size = new Size(75, 19);
            rbTipoPeso.TabIndex = 29;
            rbTipoPeso.TabStop = true;
            rbTipoPeso.Text = "Peso (Kg)";
            rbTipoPeso.UseVisualStyleBackColor = true;
            rbTipoPeso.CheckedChanged += rbTipoPeso_CheckedChanged;
            // 
            // rbTipoUnidad
            // 
            rbTipoUnidad.AutoSize = true;
            rbTipoUnidad.Location = new Point(10, 153);
            rbTipoUnidad.Name = "rbTipoUnidad";
            rbTipoUnidad.Size = new Size(63, 19);
            rbTipoUnidad.TabIndex = 30;
            rbTipoUnidad.TabStop = true;
            rbTipoUnidad.Text = "Unidad";
            rbTipoUnidad.UseVisualStyleBackColor = true;
            rbTipoUnidad.CheckedChanged += rbTipoUnidad_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(-1, -3);
            label11.Name = "label11";
            label11.Size = new Size(125, 21);
            label11.TabIndex = 26;
            label11.Text = "Nuevo Producto";
            label11.Click += label11_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearCategoria);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnEliminarCategoria);
            groupBox2.Controls.Add(btnModificarCategoría);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cbListaCategorias);
            groupBox2.Controls.Add(txtNombreCategoria);
            groupBox2.Location = new Point(12, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 173);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.Location = new Point(10, 83);
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
            label1.Location = new Point(-1, 6);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 27;
            label1.Text = "Crear/Editar Categoría";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnOrdenarPrecio);
            groupBox3.Controls.Add(btnOrdenarID);
            groupBox3.Controls.Add(btnOrdenarNombre);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtBuscarProducto);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dgvProductos);
            groupBox3.Controls.Add(btnEliminarProducto);
            groupBox3.Location = new Point(186, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(875, 399);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // btnOrdenarPrecio
            // 
            btnOrdenarPrecio.Location = new Point(680, 19);
            btnOrdenarPrecio.Name = "btnOrdenarPrecio";
            btnOrdenarPrecio.Size = new Size(75, 23);
            btnOrdenarPrecio.TabIndex = 22;
            btnOrdenarPrecio.Text = "Precio";
            btnOrdenarPrecio.UseVisualStyleBackColor = true;
            btnOrdenarPrecio.Click += btnOrdenarPrecio_Click;
            // 
            // btnOrdenarID
            // 
            btnOrdenarID.Location = new Point(602, 19);
            btnOrdenarID.Name = "btnOrdenarID";
            btnOrdenarID.Size = new Size(75, 23);
            btnOrdenarID.TabIndex = 21;
            btnOrdenarID.Text = "ID";
            btnOrdenarID.UseVisualStyleBackColor = true;
            btnOrdenarID.Click += btnOrdenarID_Click;
            // 
            // btnOrdenarNombre
            // 
            btnOrdenarNombre.Location = new Point(521, 19);
            btnOrdenarNombre.Name = "btnOrdenarNombre";
            btnOrdenarNombre.Size = new Size(75, 23);
            btnOrdenarNombre.TabIndex = 20;
            btnOrdenarNombre.Text = "Nombre";
            btnOrdenarNombre.UseVisualStyleBackColor = true;
            btnOrdenarNombre.Click += btnOrdenarNombre_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(445, 23);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 19;
            label12.Text = "⬆️⬇️ Ordenar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 22);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 18;
            label9.Text = "🔎 Nombre/ID:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(287, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(69, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(103, 19);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(178, 23);
            txtBuscarProducto.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, -3);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 14;
            label3.Text = "Listado de Productos";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(lblNombreProducto);
            groupBox4.Controls.Add(lblPrecioProducto);
            groupBox4.Controls.Add(lblStockProducto);
            groupBox4.Controls.Add(lblCategoriaProducto);
            groupBox4.Controls.Add(lblDescripcionProducto);
            groupBox4.Controls.Add(lblIDProducto);
            groupBox4.Location = new Point(186, 417);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(683, 128);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Información del producto seleccionado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 13);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripción:";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombreProducto.Location = new Point(6, 16);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(69, 25);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "label2";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrecioProducto.Location = new Point(6, 104);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(54, 21);
            lblPrecioProducto.TabIndex = 5;
            lblPrecioProducto.Text = "label2";
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStockProducto.Location = new Point(6, 74);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(54, 21);
            lblStockProducto.TabIndex = 4;
            lblStockProducto.Text = "label2";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCategoriaProducto.Location = new Point(6, 43);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(36, 13);
            lblCategoriaProducto.TabIndex = 2;
            lblCategoriaProducto.Text = "label2";
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcionProducto.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcionProducto.Location = new Point(271, 34);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(406, 88);
            lblDescripcionProducto.TabIndex = 3;
            lblDescripcionProducto.Text = "label2";
            lblDescripcionProducto.Click += lblDescripcionProducto_Click;
            // 
            // lblIDProducto
            // 
            lblIDProducto.AutoSize = true;
            lblIDProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIDProducto.Location = new Point(6, 57);
            lblIDProducto.Name = "lblIDProducto";
            lblIDProducto.Size = new Size(36, 13);
            lblIDProducto.TabIndex = 0;
            lblIDProducto.Text = "label2";
            // 
            // proveedorDAOBindingSource
            // 
            proveedorDAOBindingSource.DataSource = typeof(ProveedorDAO);
            // 
            // categoriaBindingSource1
            // 
            categoriaBindingSource1.DataSource = typeof(Entities.Categoria);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PrecioCosto
            // 
            PrecioCosto.DataPropertyName = "PrecioCosto";
            PrecioCosto.HeaderText = "Costo $";
            PrecioCosto.Name = "PrecioCosto";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            pesoDataGridViewTextBoxColumn.HeaderText = "Kg Stock";
            pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Unidades";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.DataSource = categoriaBindingSource;
            Categoria.DisplayMember = "Nombre";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ValueMember = "Nombre";
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 583);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Name = "FrmStock";
            Text = "Stock de Productos";
            Load += FrmStock_Load;
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaDAOBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private Button btnVolver;
        private TextBox txtNombreCategoria;
        private ComboBox cbListaCategorias;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblPrecioTipo;
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
        private BindingSource productoBindingSource;
        private BindingSource categoriaBindingSource;
        private BindingSource proveedorDAOBindingSource;
        private BindingSource categoriaBindingSource1;
        private RadioButton rbTipoPeso;
        private RadioButton rbTipoUnidad;
        private Button btnBuscar;
        private TextBox txtBuscarProducto;
        private BindingSource productoBindingSource1;
        private Label lblStockProducto;
        private Label lblDescripcionProducto;
        private Label lblCategoriaProducto;
        private Label lblIDProducto;
        private Label lblNombreProducto;
        private GroupBox groupBox4;
        private Label lblPrecioProducto;
        private Label label2;
        private Label label9;
        private Button btnOrdenarNombre;
        private Label label12;
        private Button btnOrdenarPrecio;
        private Button btnOrdenarID;
        private Label label13;
        private TextBox txtPrecioCosto;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PrecioCosto;
        private DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Categoria;
    }
}