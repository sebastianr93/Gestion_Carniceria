using Gestion_Carniceria.Data;
using Gestion_Carniceria.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        }

        private List<Producto> productosOriginales = new List<Producto>();
        private Producto productoSeleccionado = null;

        private void CargarProductosEnGrilla()
        {
            ProductoDAO dao = new ProductoDAO();
            productosOriginales = dao.ObtenerTodosLosProductos(); // guardás la lista real

            var productosParaMostrar = productosOriginales.Select(p => new
            {
                p.ID,
                p.Nombre,
                p.Descripcion,
                p.Peso,
                p.Cantidad,
                p.Precio,
                Categoria = p.Categoria?.Nombre ?? "(Sin categoría)"
            }).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosParaMostrar;
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
            // Obtener valores de los controles
            string nombre = txtNombreProducto.Text;
            string descripcion = txtDescripcionProducto.Text;
            decimal peso = 0;
            int cantidad = 0;
            decimal precio = 0;
            int categoriaId = 0;

            // Validar y convertir números (puedes mejorar con try/catch o TryParse)
            decimal.TryParse(txtPesoProducto.Text, out peso);
            int.TryParse(txtCantidadProducto.Text, out cantidad);
            decimal.TryParse(txtPrecioProducto.Text, out precio);
            int.TryParse(cbCategoriaProducto.SelectedValue?.ToString(), out categoriaId);

            // Crear objeto Categoria con el ID ya asignado
            Categoria cat = new Categoria { ID = categoriaId };

            // Crear objeto Producto
            Producto nuevoProducto = new Producto
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Peso = peso,
                Cantidad = cantidad,
                Precio = precio,
                Categoria = cat
            };

            // DAO para guardar
            ProductoDAO dao = new ProductoDAO();
            bool exito = dao.CrearProducto(nuevoProducto);

            if (exito)
            {
                MessageBox.Show("Producto creado con éxito");
                CargarProductosEnGrilla(); // Recarga la grilla con datos actualizados

                // Limpiar campos
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

            // Obtener datos modificados
            productoSeleccionado.Nombre = txtNombreProducto.Text;
            productoSeleccionado.Descripcion = txtDescripcionProducto.Text;
            decimal.TryParse(txtPesoProducto.Text, out decimal peso);
            productoSeleccionado.Peso = peso;
            int.TryParse(txtCantidadProducto.Text, out int cantidad);
            productoSeleccionado.Cantidad = cantidad;
            decimal.TryParse(txtPrecioProducto.Text, out decimal precio);
            productoSeleccionado.Precio = precio;

            // Asignar nueva categoría
            int.TryParse(cbCategoriaProducto.SelectedValue?.ToString(), out int categoriaId);
            productoSeleccionado.Categoria = new Categoria { ID = categoriaId };

            // Llamar al DAO
            ProductoDAO dao = new ProductoDAO();
            bool exito = dao.ModificarProducto(productoSeleccionado);

            if (exito)
            {
                MessageBox.Show("Producto modificado con éxito.");
                CargarProductosEnGrilla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al modificar el producto.");
            }

            productoSeleccionado = null; // limpiar selección
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

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCategoria.Text.Trim();
            string tipo = cbTipoCategoria.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Por favor, seleccione si la categoría será por peso o cantidad.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria nuevaCategoria = new Categoria
            {
                Nombre = nombre,
                Tipo = tipo.Contains("Peso") ? "Peso" : "Cantidad"
            };

            CategoriaDAO dao = new CategoriaDAO();
            bool resultado = dao.CrearCategoria(nuevaCategoria);

            if (resultado)
            {
                MessageBox.Show("Categoría creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreCategoria.Clear();
                cbTipoCategoria.SelectedIndex = -1;
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
            if (cbCategoriaProducto.SelectedItem is Categoria categoria)
            {
                // Cargar la categoría seleccionada
                string tipoCategoria = categoria.Tipo;

                // Deshabilitar y habilitar los campos según la categoría
                if (tipoCategoria == "Peso")
                {
                    txtPesoProducto.Enabled = true;
                    txtCantidadProducto.Enabled = false;
                }
                else if (tipoCategoria == "Cantidad")
                {
                    txtPesoProducto.Enabled = false;
                    txtCantidadProducto.Enabled = true;
                }
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (cbListaCategorias.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)cbListaCategorias.SelectedItem;

            var confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la categoría '{categoriaSeleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                CategoriaDAO dao = new CategoriaDAO();
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

                    txtNombreCategoria.Clear(); // Limpiar si estás usando este TextBox
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la categoría. Puede que esté en uso por productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
