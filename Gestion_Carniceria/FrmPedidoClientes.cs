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
    public partial class FrmPedidoClientes : Form
    {
        public FrmPedidoClientes()
        {
            InitializeComponent();
        }

        private void FrmPedidoClientes_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrilla();
            CargarClientes();
            CargarMediosDePago();
            ConfigurarGrillaItemsVenta();
            ActualizarGrillaVenta();

            txtPagoParcial.Enabled = false;
        }

        private List<Producto> productosOriginales = new List<Producto>();
        List<ItemVenta> itemsVenta = new List<ItemVenta>();

        private void CargarProductosEnGrilla()
        {
            ProductoDAO dao = new ProductoDAO();
            productosOriginales = dao.ObtenerTodosLosProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosOriginales;

        }

        private void ConfigurarGrillaItemsVenta()
        {
            dgvItemsVenta.Columns.Clear();

            // Agregar columna ProductoNombre al inicio, con nombre "ProductoNombre"
            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "ProductoNombre",
                Name = "ProductoNombre"
            });

            // No agregamos columna ProductoTipo, la quitamos (punto 2)

            // Continuar con las demás columnas (sin ProductoTipo)
            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Name = "Cantidad"
            });

            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio Unitario",
                DataPropertyName = "PrecioUnitario",
                Name = "PrecioUnitario"
            });

            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                Name = "Subtotal"
            });
        }



        private void ActualizarGrillaVenta()
        {
            var bindingList = new BindingList<ItemVenta>(itemsVenta);
            var source = new BindingSource(bindingList, null);

            dgvItemsVenta.DataSource = null;
            dgvItemsVenta.DataSource = source;

            CalcularMontoTotal();
        }


        private void CargarClientes()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            cbClientes.DataSource = clienteDAO.ObtenerTodosLosClientes();
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ID";
        }

        private void CargarMediosDePago()
        {
            MedioDePagoDAO dao = new MedioDePagoDAO();
            var medios = dao.ObtenerTodos();

            cbMediosDePago.DataSource = medios;
            cbMediosDePago.DisplayMember = "Nombre";
            cbMediosDePago.ValueMember = "Nombre"; // o "ID" si lo implementaste así
        }


        private void CalcularMontoTotal()
        {
            decimal total = itemsVenta.Sum(i => i.Subtotal);

            if (cbMediosDePago.SelectedItem is MedioDePago medio)
            {
                decimal ajuste = total * (medio.PorcentajeAjuste / 100m);
                decimal totalFinal = total + ajuste;

                lblTipoMDP.Text = medio.PorcentajeAjuste < 0
                    ? $"Descuento del {Math.Abs(medio.PorcentajeAjuste)}%"
                    : medio.PorcentajeAjuste > 0
                        ? $"Recargo del {medio.PorcentajeAjuste}%"
                        : "Sin ajuste";

                lblMontoTotal.Text = totalFinal.ToString("C");
            }
        }

        private void checkPagoParcial_CheckedChanged(object sender, EventArgs e)
        {
            txtPagoParcial.Enabled = checkPagoParcial.Checked;
            if (!checkPagoParcial.Checked)
                txtPagoParcial.Text = string.Empty;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProducto.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                string nombreProducto = row.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString().ToLower();
                row.Selected = nombreProducto.Contains(textoBusqueda);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (!decimal.TryParse(txtAgregarProducto.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            Producto producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            // Verificar y descontar stock
            if (producto.Tipo == TipoProducto.Unidad)
            {
                if (producto.Cantidad < (int)cantidad)
                {
                    MessageBox.Show("No hay suficiente stock de unidades.");
                    return;
                }
                producto.RestarStock((int)cantidad);
            }
            else
            {
                if (producto.Peso < cantidad)
                {
                    MessageBox.Show("No hay suficiente stock en kilos.");
                    return;
                }
                producto.Peso -= cantidad;
            }

            // Guardar el nuevo stock en la base
            ProductoDAO dao = new ProductoDAO();
            bool actualizado = dao.ActualizarStock(producto);
            if (!actualizado)
            {
                MessageBox.Show("No se pudo actualizar el stock en la base de datos.");
                return;
            }

            // Buscar si el producto ya está en la lista
            var itemExistente = itemsVenta.FirstOrDefault(i => i.Producto.ID == producto.ID);
            if (itemExistente != null)
            {
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                itemsVenta.Add(new ItemVenta
                {
                    Producto = producto,
                    Cantidad = cantidad
                });
            }

            ActualizarGrillaVenta();
            CargarProductosEnGrilla(); // Mostrar stock actualizado
            txtAgregarProducto.Clear();
        }




        private void cbMediosDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal();
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (dgvItemsVenta.CurrentRow?.DataBoundItem is ItemVenta item)
            {
                var productoEnLista = productosOriginales.FirstOrDefault(p => p.ID == item.Producto.ID);

                if (productoEnLista != null)
                {
                    ProductoDAO productoDAO = new ProductoDAO();

                    bool exito = productoDAO.AumentarStock(productoEnLista, item.Cantidad);

                    if (!exito)
                    {
                        MessageBox.Show("Error al reponer stock en la base de datos.");
                        return;
                    }

                    // Quitar item de la lista y refrescar
                    itemsVenta.Remove(item);
                    ActualizarGrillaVenta();

                    // Refrescar la grilla de productos para mostrar stock actualizado
                    dgvProductos.Refresh();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ítem válido para quitar.");
            }
        }



        private void dgvItemsVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvItemsVenta.Rows.Count)
                return;

            if (dgvItemsVenta.Rows[e.RowIndex].DataBoundItem is ItemVenta item)
            {
                MessageBox.Show($"Seleccionaste: {item.ProductoNombre} x {item.Cantidad} = ${item.Subtotal}");
            }
        }

        private void FrmPedidoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemsVenta.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas cerrar el formulario? Los cambios de la venta no se guardarán.",
                    "Confirmar cierre",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre
                    return;
                }

                // Si confirmó que sí, devolver stock de los ítems
                ProductoDAO dao = new ProductoDAO();
                foreach (var item in itemsVenta)
                {
                    dao.AumentarStock(item.Producto, item.Cantidad);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Triggea el FormClosing
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (itemsVenta.Count == 0)
            {
                MessageBox.Show("No hay productos agregados para la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pagoParcial = 0m;
            if (checkPagoParcial.Checked)
            {
                if (!decimal.TryParse(txtPagoParcial.Text, out pagoParcial) || pagoParcial < 0)
                {
                    MessageBox.Show("Ingrese un monto válido para el pago parcial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal total = itemsVenta.Sum(i => i.Subtotal);
                if (pagoParcial > total)
                {
                    MessageBox.Show("El pago parcial no puede ser mayor al total de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                Venta venta = new Venta
                {
                    Fecha = DateTime.Now,
                    Cliente = (Cliente)cbClientes.SelectedItem,
                    ValorTotal = itemsVenta.Sum(i => i.Subtotal),
                    PagoParcial = pagoParcial,
                    FormatoPago = cbMediosDePago.SelectedItem is MedioDePago mp ? mp.Nombre : "No especificado",
                    Items = new List<ItemVenta>(itemsVenta)
                };

                VentaDAO dao = new VentaDAO();
                int ventaID = dao.InsertarVenta(venta);

                if (ventaID > 0)
                {
                    dao.InsertarItemsVenta(ventaID, venta.Items);

                    // Actualizar deuda del cliente si hubo pago parcial
                    decimal deuda = venta.ValorTotal - venta.PagoParcial;

                    if (deuda > 0)
                    {
                        ClienteDAO clienteDAO = new ClienteDAO();
                        var cliente = venta.Cliente;
                        cliente.Deuda += deuda;
                        clienteDAO.ActualizarDeuda(cliente);
                    }

                    MessageBox.Show("Venta confirmada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar todo para nueva venta
                    itemsVenta.Clear();
                    ActualizarGrillaVenta();
                    txtPagoParcial.Clear();
                    checkPagoParcial.Checked = false;
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}
