﻿using Gestion_Carniceria.Data;
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

namespace Gestion_Carniceria
{
    public partial class FrmPedidoProveedores : Form
    {
        public FrmPedidoProveedores()
        {
            InitializeComponent();
        }
        // Listas para almacenar productos e items del pedido
        private List<Producto> productosDisponibles = new List<Producto>();
        private List<ItemPedido> itemsPedido = new List<ItemPedido>();

        // Instancias de DAOs para acceder a la base de datos
        private ProductoDAO productoDAO = new ProductoDAO();
        private ProveedorDAO proveedorDAO = new ProveedorDAO();

        private void FrmPedidoProveedores_Load(object sender, EventArgs e)
        {
            ActualizarGrillaProductos();
            CargarProveedores();

            txtPagoParcial.Enabled = false;
        }

        // Métodos genéricos

        private void ActualizarGrillaProductos()
        {
            productosDisponibles = productoDAO.ObtenerTodosLosProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosDisponibles;
            dgvProductos.ClearSelection();

            if (dgvProductos.Columns.Contains("Categoria"))
                dgvProductos.Columns["Categoria"].Visible = false;

            if (dgvProductos.Columns.Contains("Tipo"))
                dgvProductos.Columns["Tipo"].Visible = false;
        }

        private void ActualizarMontoTotal()
        {
            decimal total = itemsPedido.Sum(i => i.Subtotal);
            lblMontoTotal.Text = $"${total:0.00}";

            // Validar pago parcial
            if (checkPagoParcial.Checked && decimal.TryParse(txtPagoParcial.Text.Trim(), out decimal pagoParcial))
            {
                if (pagoParcial > total)
                {
                    MessageBox.Show("El pago parcial no puede ser mayor al monto total.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPagoParcial.Clear();
                }
            }
        }

        private void ConfigurarGrillaItemsPedido()
        {
            dgvItemsPedido.AutoGenerateColumns = false;
            dgvItemsPedido.Columns.Clear();

            dgvItemsPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProducto",
                HeaderText = "Producto"
            });

            dgvItemsPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad"
            });

            dgvItemsPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioUnitario",
                HeaderText = "Precio Unitario",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvItemsPedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }


        private void CargarProveedores()
        {
            // Obtener la lista de proveedores desde la base de datos
            List<Proveedor> proveedores = proveedorDAO.ObtenerTodosLosProveedores();

            // Asignar la lista al ComboBox
            cbProveedores.DataSource = proveedores;
            cbProveedores.DisplayMember = "Nombre";
            cbProveedores.ValueMember = "Id";
        }

        // Controles de Productos
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscarProducto.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un ID o nombre de producto para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var encontrado = productosDisponibles.FirstOrDefault(p =>
                p.Nombre.ToLower().Contains(criterio) || p.ID.ToString() == criterio);

            if (encontrado != null)
            {
                int rowIndex = productosDisponibles.IndexOf(encontrado);
                dgvProductos.ClearSelection();
                dgvProductos.Rows[rowIndex].Selected = true;
                dgvProductos.FirstDisplayedScrollingRowIndex = rowIndex;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = dgvProductos.CurrentRow?.DataBoundItem as Producto;
            if (productoSeleccionado == null) return;

            if (!decimal.TryParse(txtAgregarProducto.Text.Trim(), out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar si ya existe un ítem con ese producto
            var itemExistente = itemsPedido.FirstOrDefault(i => i.Producto.ID == productoSeleccionado.ID);

            if (itemExistente != null)
            {
                // Sumar la cantidad al ítem existente
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                // Crear nuevo ítem
                var item = new ItemPedido
                {
                    Producto = productoSeleccionado,
                    Cantidad = cantidad,
                    PrecioUnitario = productoSeleccionado.Precio
                };
                itemsPedido.Add(item);
            }

            // Forzar refresco visual
            dgvItemsPedido.DataSource = null;
            dgvItemsPedido.DataSource = itemsPedido;

            ActualizarMontoTotal();
            ConfigurarGrillaItemsPedido();
            txtAgregarProducto.Clear();
        }


        // Controles de Items del Pedido

        private void checkPagoParcial_CheckedChanged(object sender, EventArgs e)
        {
            txtPagoParcial.Enabled = checkPagoParcial.Checked;

            if (!checkPagoParcial.Checked)
            {
                txtPagoParcial.Clear();
            }
        }

        private void txtPagoParcial_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPagoParcial.Text.Trim(), out decimal pagoParcial) || pagoParcial < 0)
            {
                MessageBox.Show("Ingrese un monto válido para el pago parcial.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagoParcial.Clear();
                return;
            }

            decimal montoTotal = itemsPedido.Sum(i => i.Cantidad * i.PrecioUnitario);

            if (pagoParcial > montoTotal)
            {
                MessageBox.Show("El pago parcial no puede ser mayor al monto total del pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagoParcial.Clear();
            }
        }
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            // Validar que la grilla no esté vacía
            if (itemsPedido == null || itemsPedido.Count == 0)
            {
                MessageBox.Show("No hay productos agregados para el pedido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya proveedor seleccionado
            if (cbProveedores.SelectedItem is not Proveedor proveedorSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un proveedor para realizar el pedido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular el total del pedido
            decimal montoTotal = itemsPedido.Sum(i => i.Subtotal);
            decimal pagoParcial = 0;
            decimal deuda = 0;

            // Validar pago parcial si está activado
            if (checkPagoParcial.Checked)
            {
                if (!decimal.TryParse(txtPagoParcial.Text.Trim(), out pagoParcial) || pagoParcial <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido para el pago parcial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pagoParcial > montoTotal)
                {
                    MessageBox.Show("El pago parcial no puede ser mayor al monto total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                deuda = montoTotal - pagoParcial;
            }
            else
            {
                pagoParcial = montoTotal;
            }

            // Confirmación con el usuario
            var confirmar = MessageBox.Show(
                $"¿Desea confirmar el pedido para el proveedor '{proveedorSeleccionado.Nombre}'?\nMonto total: {montoTotal:C2}",
                "Confirmar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            // ACTUALIZAR STOCK
            foreach (var item in itemsPedido)
            {
                productoDAO.AumentarStock(item.Producto, item.Cantidad);
            }

            // GUARDAR PEDIDO EN HISTORIAL
            Pedido nuevoPedido = new Pedido
            {
                Fecha = DateTime.Now,
                ValorTotal = montoTotal,
                PagoParcial = pagoParcial,
                Proveedor = proveedorSeleccionado,
                Items = new List<ItemPedido>(itemsPedido) // Hacer una copia para preservar
            };

            PedidoDAO.InsertarPedido(nuevoPedido);

            // Paso 8: Actualizar Cuenta Corriente del proveedor si hay deuda
            if (deuda > 0)
            {
                proveedorSeleccionado.CuentaCorriente += deuda;
                proveedorDAO.ActualizarCuentaCorriente(proveedorSeleccionado); // Método que deberás implementar
            }

            // Paso 9: Limpiar datos del formulario
            itemsPedido.Clear();
            dgvItemsPedido.DataSource = null;
            txtPagoParcial.Clear();
            txtAgregarProducto.Clear();
            checkPagoParcial.Checked = false;

            // Actualizar productos en pantalla
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productoDAO.ObtenerTodosLosProductos(); // O el método que uses para recargar

            ActualizarMontoTotal();
            ActualizarGrillaProductos();

            // Paso 10: Mensaje de éxito
            string mensaje = $"Pedido confirmado de '{proveedorSeleccionado.Nombre}'\n" +
                             $"Fecha: {nuevoPedido.Fecha:dd/MM/yyyy HH:mm}\n" +
                             $"Monto total: {montoTotal:C2}";

            if (deuda > 0)
            {
                mensaje += $"\nMonto abonado: {pagoParcial:C2}\nMonto restante: {deuda:C2}";
            }

            MessageBox.Show(mensaje, "Pedido Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (dgvItemsPedido.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un ítem para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvItemsPedido.CurrentRow.Index;

            if (index >= 0 && index < itemsPedido.Count)
            {
                itemsPedido.RemoveAt(index);

                dgvItemsPedido.DataSource = null;
                dgvItemsPedido.DataSource = itemsPedido;

                ActualizarMontoTotal();
                ConfigurarGrillaItemsPedido();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual
        }

        private void FrmPedidoProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemsPedido != null && itemsPedido.Count > 0)
            {
                var resultado = MessageBox.Show(
                    "Hay ítems sin confirmar en el pedido. Si sale, perderá los cambios.\n¿Está seguro que desea salir?",
                    "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario
                }
            }
        }
    }
}
