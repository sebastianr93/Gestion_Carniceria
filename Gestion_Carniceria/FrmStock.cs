using Gestion_Carniceria.Data;
using Gestion_Carniceria.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Carniceria
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrilla();
            CargarCategorias();
            LimpiarInfoProducto();

            lblDescripcionProducto.TextAlign = ContentAlignment.TopLeft;

            // Columna ID solo lectura
            if (dgvProductos.Columns["iDDataGridViewTextBoxColumn"] != null)
                dgvProductos.Columns["iDDataGridViewTextBoxColumn"].ReadOnly = true;

        }

        // Variables para almacenar los productos y el producto seleccionado
        private List<Producto> productosOriginales = new List<Producto>();


        // Variables para ordenamiento de la grilla
        private bool ordenNombreAscendente = true;
        private bool ordenIDAscendente = true;
        private bool ordenPrecioAscendente = true;

        // métodos utilizados en el formulario para el control de productos y categorías

        private void CargarProductosEnGrilla()
        {
            ProductoDAO dao = new ProductoDAO();
            dgvProductos.AutoGenerateColumns = false;
            productosOriginales = dao.ObtenerTodosLosProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosOriginales;

            CargarCategoriasEnGrilla();

        }

        private void CargarCategoriasEnGrilla()
        {
            // Obtener las categorías desde la base de datos
            CategoriaDAO dao = new CategoriaDAO();
            List<Categoria> listaCategorias = dao.ObtenerTodasLasCategorias();

            // Asignar la lista de categorías al DataGridViewComboBoxColumn
            var colCombo = dgvProductos.Columns["Categoria"] as DataGridViewComboBoxColumn;
            if (colCombo != null)
            {
                colCombo.DisplayMember = "Nombre";
                colCombo.ValueMember = "ID";
                colCombo.DataPropertyName = "CategoriaID";
                colCombo.DataSource = listaCategorias;
            }
        }

        private void CargarCategorias()
        {
            CategoriaDAO dao = new CategoriaDAO();
            List<Categoria> lista = dao.ObtenerTodasLasCategorias();

            cbListaCategorias.DataSource = null;
            cbListaCategorias.DataSource = lista;
            cbListaCategorias.DisplayMember = "Nombre";
            cbListaCategorias.ValueMember = "ID";
            cbListaCategorias.SelectedIndex = -1;

            cbCategoriaProducto.DataSource = null;
            cbCategoriaProducto.DataSource = lista;
            cbCategoriaProducto.DisplayMember = "Nombre";
            cbCategoriaProducto.ValueMember = "ID";
            cbCategoriaProducto.SelectedIndex = -1;
        }


        private void LimpiarInfoProducto()
        {
            lblIDProducto.Text = "";
            lblNombreProducto.Text = "";
            lblDescripcionProducto.Text = "";
            lblCategoriaProducto.Text = "";
            lblStockProducto.Text = "";
            lblPrecioProducto.Text = "";

            // Opcional: ocultar todos los labels
            lblIDProducto.Visible = false;
            lblNombreProducto.Visible = false;
            lblDescripcionProducto.Visible = false;
            lblCategoriaProducto.Visible = false;
            lblStockProducto.Visible = false;
            lblPrecioProducto.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtPesoProducto.Text = "";
            txtCantidadProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtPrecioCosto.Text = "";
            cbCategoriaProducto.SelectedIndex = -1;
        }

        private void RecargarGrillaOrdenada(List<Producto> filasOrdenadas)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = filasOrdenadas;
        }

        // Controles de eventos para crear, eliminar y modificar productos

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            // Validaciones de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ||
                cbCategoriaProducto.SelectedItem == null ||
                (!rbTipoUnidad.Checked && !rbTipoPeso.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios y seleccione un tipo de conteo (Peso o Unidad).");
                return;
            }



            // Declaración de variables
            decimal peso = 0;
            int cantidad = 0;
            TipoProducto tipo;

            // Validación según el tipo seleccionado
            if (rbTipoPeso.Checked)
            {
                tipo = TipoProducto.Peso;


                if (string.IsNullOrWhiteSpace(txtPesoProducto.Text) || !decimal.TryParse(txtPesoProducto.Text, out peso) || peso <= 0)
                {
                    MessageBox.Show("Ingrese un peso válido mayor a 0.");
                    return;
                }

                cantidad = 0; // Por peso, cantidad no aplica
            }
            else // rbTipoUnidad.Checked
            {
                tipo = TipoProducto.Unidad;


                if (string.IsNullOrWhiteSpace(txtCantidadProducto.Text) || !int.TryParse(txtCantidadProducto.Text, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a 0.");
                    return;
                }

                peso = 0; // Por unidad, peso no aplica
            }

            // Validación del precio
            if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.");
                return;
            }

            // Validación de categoría
            if (!int.TryParse(cbCategoriaProducto.SelectedValue?.ToString(), out int categoriaId) || categoriaId <= 0)
            {
                MessageBox.Show("Seleccione una categoría válida.");
                return;
            }



            if (!decimal.TryParse(txtPrecioCosto.Text, out decimal precioCosto) || precioCosto <= 0)
            {
                MessageBox.Show("Ingrese un precio de costo válido mayor a 0.");
                return;
            }


            // Crear objeto Categoria y Producto
            Categoria cat = new Categoria { ID = categoriaId };

            Producto nuevoProducto = new Producto
            {
                Nombre = txtNombreProducto.Text.Trim(),
                Descripcion = txtDescripcionProducto.Text.Trim(),
                Peso = peso,
                Cantidad = cantidad,
                Precio = precio,
                PrecioCosto = precioCosto, // <-- asignar
                Categoria = cat,
                Tipo = tipo
            };

            ProductoDAO dao = new ProductoDAO();
            bool exito = dao.CrearProducto(nuevoProducto);

            if (exito)
            {
                MessageBox.Show("Producto creado con éxito");
                CargarProductosEnGrilla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al crear el producto");
            }
        }



        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            // Recuperar el objeto anónimo que representa la fila
            var fila = dgvProductos.CurrentRow.DataBoundItem;

            // Usar reflexión para obtener el valor de la propiedad "ID"
            var propiedadID = fila.GetType().GetProperty("ID");
            if (propiedadID == null)
            {
                MessageBox.Show("No se pudo obtener el ID del producto.");
                return;
            }

            int idSeleccionado = (int)propiedadID.GetValue(fila);

            // Buscar el Producto real en la lista original
            Producto productoSeleccionado = productosOriginales.FirstOrDefault(p => p.ID == idSeleccionado);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            // Confirmar con el usuario
            DialogResult respuesta = MessageBox.Show(
                $"¿Desea eliminar el producto '{productoSeleccionado.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                ProductoDAO dao = new ProductoDAO();
                bool exito = dao.EliminarProducto(productoSeleccionado.ID);

                if (exito)
                {
                    MessageBox.Show("Producto eliminado con éxito.");
                    CargarProductosEnGrilla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.");
                }
            }
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvProductos.Rows[e.RowIndex];

            // Obtener ID del producto
            int id = Convert.ToInt32(fila.Cells["iDDataGridViewTextBoxColumn"].Value);
            Producto productoOriginal = productosOriginales.FirstOrDefault(p => p.ID == id);
            if (productoOriginal == null) return;

            try
            {
                // Confirmación del usuario
                DialogResult confirmar = MessageBox.Show(
                    "¿Desea guardar los cambios en este producto?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmar != DialogResult.Yes)
                {
                    CargarProductosEnGrilla();
                    return;
                }

                // Clonar para modificar sin afectar el original si ocurre un error
                Producto productoModificado = (Producto)productoOriginal.Clone();

                // Nombre
                if (e.ColumnIndex == fila.Cells["Nombre"].ColumnIndex)
                    productoModificado.Nombre = fila.Cells[e.ColumnIndex].Value?.ToString();

                // Descripción
                if (e.ColumnIndex == fila.Cells["descripcionDataGridViewTextBoxColumn"].ColumnIndex)
                    productoModificado.Descripcion = fila.Cells[e.ColumnIndex].Value?.ToString() ?? "";

                // Precio venta
                if (e.ColumnIndex == fila.Cells["precioDataGridViewTextBoxColumn"].ColumnIndex)
                    productoModificado.Precio = Convert.ToDecimal(fila.Cells[e.ColumnIndex].Value);

                // Precio costo
                if (fila.Cells["PrecioCosto"] != null &&
                    e.ColumnIndex == fila.Cells["PrecioCosto"].ColumnIndex)
                {
                    productoModificado.PrecioCosto = Convert.ToDecimal(fila.Cells[e.ColumnIndex].Value);
                }

                // Peso
                if (e.ColumnIndex == fila.Cells["pesoDataGridViewTextBoxColumn"].ColumnIndex)
                {
                    if (productoModificado.Tipo != TipoProducto.Peso)
                    {
                        MessageBox.Show("Este producto no es de tipo 'Peso'. No puede asignar peso.");
                        CargarProductosEnGrilla();
                        return;
                    }

                    decimal peso = Convert.ToDecimal(fila.Cells[e.ColumnIndex].Value);
                    if (peso <= 0)
                    {
                        MessageBox.Show("Peso inválido para producto tipo 'Peso'.");
                        CargarProductosEnGrilla();
                        return;
                    }

                    productoModificado.Peso = peso;
                    productoModificado.Cantidad = 0; // Reset cantidad
                }

                // Cantidad
                if (e.ColumnIndex == fila.Cells["cantidadDataGridViewTextBoxColumn"].ColumnIndex)
                {
                    if (productoModificado.Tipo != TipoProducto.Unidad)
                    {
                        MessageBox.Show("Este producto no es de tipo 'Unidad'. No puede asignar cantidad.");
                        CargarProductosEnGrilla();
                        return;
                    }

                    int cantidad = Convert.ToInt32(fila.Cells[e.ColumnIndex].Value);
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("Cantidad inválida para producto tipo 'Unidad'.");
                        CargarProductosEnGrilla();
                        return;
                    }

                    productoModificado.Cantidad = cantidad;
                    productoModificado.Peso = 0; // Reset peso
                }

                // Guardar en la base de datos
                ProductoDAO dao = new ProductoDAO();
                dao.ModificarProducto(productoModificado);

                // Reemplazar el producto original con el modificado en la lista
                int index = productosOriginales.FindIndex(p => p.ID == productoModificado.ID);
                if (index >= 0)
                    productosOriginales[index] = productoModificado;

                CargarProductosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                CargarProductosEnGrilla();
            }
        }



        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Categoria")
            {
                int fila = e.RowIndex;
                if (fila >= 0)
                {
                    var producto = (Producto)dgvProductos.Rows[fila].DataBoundItem;
                    var nuevaCategoriaID = dgvProductos.Rows[fila].Cells["Categoria"].Value;

                    // Actualizar en la base
                    producto.Categoria.ID = Convert.ToInt32(nuevaCategoriaID);
                    new ProductoDAO().ActualizarCategoria(producto.ID, producto.Categoria.ID);
                }
            }
        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProducto.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Ingrese un nombre o ID de producto para buscar.");
                return;
            }

            bool alMenosUnoEncontrado = false;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                string valorId = fila.Cells["iDDataGridViewTextBoxColumn"].Value?.ToString().ToLower() ?? "";
                string valorNombre = fila.Cells["Nombre"].Value?.ToString().ToLower() ?? "";

                if (valorId.Contains(textoBusqueda) || valorNombre.Contains(textoBusqueda))
                {
                    fila.Selected = true;
                    alMenosUnoEncontrado = true;
                }
                else
                {
                    fila.Selected = false;
                }
            }

            if (!alMenosUnoEncontrado)
            {
                MessageBox.Show("No se encontraron productos con ese nombre o ID.");
            }
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0)
            {
                var producto = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                lblIDProducto.Text = producto.ID.ToString();
                lblNombreProducto.Text = producto.Nombre;
                lblDescripcionProducto.Text = FormatearDescripcion(producto.Descripcion);
                lblCategoriaProducto.Text = producto.Categoria?.Nombre ?? "";

                if (producto.Tipo == TipoProducto.Peso)
                {
                    lblStockProducto.Text = $"{producto.Peso} kg";
                    lblPrecioProducto.Text = $"${producto.Precio} por kg";
                }
                else
                {
                    lblStockProducto.Text = $"{producto.Cantidad} unidades";
                    lblPrecioProducto.Text = $"${producto.Precio} por unidad";
                }

                MostrarLabelsInfo();
            }
        }


        private void MostrarLabelsInfo()
        {
            lblIDProducto.Visible = true;
            lblNombreProducto.Visible = true;
            lblDescripcionProducto.Visible = true;
            lblCategoriaProducto.Visible = true;
            lblStockProducto.Visible = true;
            lblPrecioProducto.Visible = true;
        }

        private string FormatearDescripcion(string descripcion)
        {
            // Si ya contiene saltos de línea, los respeta
            if (descripcion.Contains("\n")) return descripcion;

            // Cada 80 caracteres aprox., insertamos un salto
            const int maxLineLength = 80;
            StringBuilder resultado = new StringBuilder();

            int contador = 0;
            foreach (string palabra in descripcion.Split(' '))
            {
                if (contador + palabra.Length > maxLineLength)
                {
                    resultado.AppendLine();
                    contador = 0;
                }

                resultado.Append(palabra + " ");
                contador += palabra.Length + 1;
            }

            return resultado.ToString().TrimEnd();
        }



        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria nuevaCategoria = new Categoria
            {
                Nombre = nombre,
            };

            CategoriaDAO dao = new CategoriaDAO();
            bool resultado = dao.CrearCategoria(nuevaCategoria);

            if (resultado)
            {
                MessageBox.Show("Categoría creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreCategoria.Clear();
                txtNombreCategoria.Focus();

                CargarCategorias();
            }
            else
            {
                MessageBox.Show("Error al crear la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (cbListaCategorias.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoNombre = txtNombreCategoria.Text.Trim();
            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Ingrese un nuevo nombre para la categoría.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)cbListaCategorias.SelectedItem;
            categoriaSeleccionada.Nombre = nuevoNombre;

            CategoriaDAO dao = new CategoriaDAO();
            bool resultado = dao.ModificarCategoria(categoriaSeleccionada);

            if (resultado)
            {
                MessageBox.Show("Categoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreCategoria.Clear();
                CargarProductosEnGrilla();
                CargarCategorias();

                // Recargar ComboBox
                cbListaCategorias.DataSource = null;
                cbListaCategorias.DataSource = dao.ObtenerTodasLasCategorias();
                cbListaCategorias.DisplayMember = "Nombre";
                cbListaCategorias.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("No se pudo modificar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbListaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListaCategorias.SelectedItem is Categoria categoria)
            {
                txtNombreCategoria.Text = categoria.Nombre;
            }
        }

        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (cbListaCategorias.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)cbListaCategorias.SelectedItem;

            CategoriaDAO dao = new CategoriaDAO();

            // Verificar si la categoría tiene productos asociados
            int cantidadProductos = dao.ContarProductosPorCategoria(categoriaSeleccionada.ID);
            if (cantidadProductos > 0)
            {
                MessageBox.Show("No se puede eliminar la categoría porque tiene productos asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la categoría '{categoriaSeleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool resultado = dao.EliminarCategoria(categoriaSeleccionada.ID);

                if (resultado)
                {
                    MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar ComboBoxes
                    cbListaCategorias.DataSource = null;
                    cbListaCategorias.DataSource = dao.ObtenerTodasLasCategorias();
                    cbListaCategorias.DisplayMember = "Nombre";
                    cbListaCategorias.ValueMember = "ID";

                    cbCategoriaProducto.DataSource = null;
                    cbCategoriaProducto.DataSource = dao.ObtenerTodasLasCategorias();
                    cbCategoriaProducto.DisplayMember = "Nombre";
                    cbCategoriaProducto.ValueMember = "ID";

                    txtNombreCategoria.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la categoría. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbTipoUnidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoUnidad.Checked)
            {
                txtCantidadProducto.Enabled = true;
                txtPesoProducto.Enabled = false;
                txtPesoProducto.Text = ""; // limpiar campo inhabilitado
                lblPrecioTipo.Text = "Precio por unidad:";
            }
        }

        private void rbTipoPeso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoPeso.Checked)
            {
                txtPesoProducto.Enabled = true;
                txtCantidadProducto.Enabled = false;
                txtCantidadProducto.Text = ""; // limpiar campo inhabilitado
                lblPrecioTipo.Text = "Precio por kilogramo:";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDescripcionProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarNombre_Click(object sender, EventArgs e)
        {
            List<Producto> productosOrdenados;

            if (ordenNombreAscendente)
                productosOrdenados = productosOriginales.OrderBy(p => p.Nombre).ToList();
            else
                productosOrdenados = productosOriginales.OrderByDescending(p => p.Nombre).ToList();

            ordenNombreAscendente = !ordenNombreAscendente;
            RecargarGrillaOrdenada(productosOrdenados);
        }


        private void btnOrdenarID_Click(object sender, EventArgs e)
        {
            List<Producto> productosOrdenados;

            if (ordenIDAscendente)
                productosOrdenados = productosOriginales.OrderBy(p => p.ID).ToList();
            else
                productosOrdenados = productosOriginales.OrderByDescending(p => p.ID).ToList();

            ordenIDAscendente = !ordenIDAscendente;
            RecargarGrillaOrdenada(productosOrdenados);
        }



        private void btnOrdenarPrecio_Click(object sender, EventArgs e)
        {
            List<Producto> productosOrdenados;

            if (ordenPrecioAscendente)
                productosOrdenados = productosOriginales.OrderBy(p => p.Precio).ToList();
            else
                productosOrdenados = productosOriginales.OrderByDescending(p => p.Precio).ToList();

            ordenPrecioAscendente = !ordenPrecioAscendente;
            RecargarGrillaOrdenada(productosOrdenados);
        }


    }
}
