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
            ActualizarGrillaVenta();
            ConfigurarGrillaItemsVenta();

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

            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "ProductoNombre", // propiedad que vamos a agregar abajo
                Name = "Producto"
            });

            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tipo",
                DataPropertyName = "ProductoTipo",
                Name = "Tipo"
            });

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
            dgvItemsVenta.DataSource = null;
            dgvItemsVenta.DataSource = itemsVenta;
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
            cbMediosDePago.DataSource = MedioDePago.ObtenerMediosPorDefecto();
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
                string nombreProducto = row.Cells["Nombre"].Value.ToString().ToLower();
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

            itemsVenta.Add(new ItemVenta
            {
                Producto = producto,
                Cantidad = cantidad
            });

            ActualizarGrillaVenta();
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
                itemsVenta.Remove(item);
                ActualizarGrillaVenta();
            }
            else
            {
                MessageBox.Show("Seleccione un ítem válido para quitar.");
            }
        }
    }
    }
