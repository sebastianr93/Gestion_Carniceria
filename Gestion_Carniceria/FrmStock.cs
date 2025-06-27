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

        }

        private List<Producto> productosOriginales = new List<Producto>();
        private Producto productoSeleccionado = null;

        private void CargarProductosEnGrilla()
        {
            ProductoDAO dao = new ProductoDAO();
            productosOriginales = dao.ObtenerTodosLosProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosOriginales;

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
            cbCategoriaProducto.SelectedIndex = -1;
        }


        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            // Validaciones de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
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

            // Crear objeto Categoria y Producto
            Categoria cat = new Categoria { ID = categoriaId };

            Producto nuevoProducto = new Producto
            {
                Nombre = txtNombreProducto.Text.Trim(),
                Descripcion = txtDescripcionProducto.Text.Trim(),
                Peso = peso,
                Cantidad = cantidad,
                Precio = precio,
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


        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            try
            {
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                    cbCategoriaProducto.SelectedItem == null ||
                    (!rbTipoUnidad.Checked && !rbTipoPeso.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios y seleccione un tipo (Unidad o Peso).");
                    return;
                }

                // Tipo de producto
                TipoProducto tipo = rbTipoPeso.Checked ? TipoProducto.Peso : TipoProducto.Unidad;
                productoSeleccionado.Tipo = tipo;

                // Nombre y descripción
                productoSeleccionado.Nombre = txtNombreProducto.Text.Trim();
                productoSeleccionado.Descripcion = txtDescripcionProducto.Text.Trim();

                // Cantidad/Peso según tipo
                if (tipo == TipoProducto.Peso)
                {
                    if (!decimal.TryParse(txtPesoProducto.Text, out decimal peso) || peso <= 0)
                    {
                        MessageBox.Show("Ingrese un peso válido mayor a 0.");
                        return;
                    }

                    productoSeleccionado.Peso = peso;
                    productoSeleccionado.Cantidad = 0;
                }
                else // Unidad
                {
                    if (!int.TryParse(txtCantidadProducto.Text, out int cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show("Ingrese una cantidad válida mayor a 0.");
                        return;
                    }

                    productoSeleccionado.Cantidad = cantidad;
                    productoSeleccionado.Peso = 0;
                }

                // Precio
                if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido mayor a 0.");
                    return;
                }
                productoSeleccionado.Precio = precio;

                // Categoría
                if (!int.TryParse(cbCategoriaProducto.SelectedValue?.ToString(), out int categoriaId) || categoriaId <= 0)
                {
                    MessageBox.Show("Seleccione una categoría válida.");
                    return;
                }
                productoSeleccionado.Categoria = new Categoria { ID = categoriaId };

                // Modificar en base de datos
                ProductoDAO dao = new ProductoDAO();
                bool exito = dao.ModificarProducto(productoSeleccionado);

                if (exito)
                {
                    MessageBox.Show("Producto modificado con éxito.");
                    CargarProductosEnGrilla();
                    LimpiarCampos();
                    productoSeleccionado = null;
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
                return;

            var fila = dgvProductos.CurrentRow.DataBoundItem;
            var propiedadID = fila.GetType().GetProperty("ID");

            if (propiedadID == null)
            {
                MessageBox.Show("No se pudo obtener el ID del producto.");
                return;
            }

            int idSeleccionado = (int)propiedadID.GetValue(fila);

            // Buscar el Producto real en la lista original
            productoSeleccionado = productosOriginales.FirstOrDefault(p => p.ID == idSeleccionado);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            // Rellenar los campos del formulario con los datos del producto
            txtNombreProducto.Text = productoSeleccionado.Nombre;
            txtDescripcionProducto.Text = productoSeleccionado.Descripcion;
            txtPesoProducto.Text = productoSeleccionado.Peso.ToString();
            txtCantidadProducto.Text = productoSeleccionado.Cantidad.ToString();
            txtPrecioProducto.Text = productoSeleccionado.Precio.ToString();
            cbCategoriaProducto.SelectedValue = productoSeleccionado.Categoria.ID;

            MessageBox.Show("Producto cargado para modificación.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProducto.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            bool alMenosUnoEncontrado = false;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells["Nombre"].Value != null &&
                    fila.Cells["Nombre"].Value.ToString().ToLower().Contains(textoBusqueda))
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
                MessageBox.Show("No se encontraron productos con ese nombre.");
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
    }
}
