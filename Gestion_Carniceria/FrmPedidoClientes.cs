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
            this.Shown += FrmPedidoClientes_Shown;
            dgvProductos.KeyDown += dgvProductos_KeyDown_CustomTab;
            dgvItemsVenta.KeyDown += dgvItemsVenta_KeyDown_CustomTab;
            dgvItemsVenta.KeyDown += dgvItemsVenta_KeyDown_Backspace;
            txtBuscarProducto.KeyDown += txtBuscarProducto_KeyDown;

            this.KeyPreview = true; // Muy importante para capturar teclas en todo el formulario
            this.KeyPress += FrmPedidoClientes_KeyPress;
        }

        private void FrmPedidoClientes_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrilla();
            CargarClientes();
            CargarMediosDePago();
            ConfigurarGrillaItemsVenta();
            ActualizarGrillaVenta();

            dgvItemsVenta.CellFormatting += dgvItemsVenta_CellFormatting;
            dgvProductos.KeyDown += dgvProductos_KeyDown;
            dgvItemsVenta.KeyDown += dgvItemsVenta_KeyDown;
           


            txtPagoParcial.Enabled = false;

            // Seleccionar el primer producto y poner foco en la grilla
            if (dgvProductos.Rows.Count > 0)
            {
                dgvProductos.CurrentCell = dgvProductos.Rows[0].Cells[0]; // primera celda
                dgvProductos.Rows[0].Selected = true; // resaltar fila
                dgvProductos.Focus(); // poner foco para que las teclas funcionen
            }
        }

        private void FrmPedidoClientes_Shown(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                // Selecciona la primera fila y la primera celda
                dgvProductos.CurrentCell = dgvProductos.Rows[0].Cells[0];
                dgvProductos.Rows[0].Selected = true;

                // Fuerza el foco en la grilla
                dgvProductos.Focus();
            }
        }


        //*******************************CONTROLES DE TECLADO PARA MOVERSE ENTRE GRILLAS***********************************//
        private void dgvProductos_KeyDown_CustomTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true; // Evita el tab normal
                dgvItemsVenta.Focus(); // Pasa el foco al otro DataGridView
            }
        }

        private void dgvItemsVenta_KeyDown_CustomTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true; // Evita el tab normal
                dgvProductos.Focus(); // Vuelve el foco al primero
            }
        }
        private void dgvItemsVenta_KeyDown(object sender, KeyEventArgs e)
        {
            // Tecla Retroceso (Backspace)
            if (e.KeyCode == Keys.Back)
            {
                btnQuitarItem.PerformClick();
                e.Handled = true; // Evita cualquier otra acción de la tecla
            }
        }

        private void FrmPedidoClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignoramos teclas de control como Enter, Tab, Escape, etc.
            if (!char.IsControl(e.KeyChar))
            {
                txtBuscarProducto.Focus();

                // Insertamos la letra presionada al final del texto actual
                txtBuscarProducto.Text += e.KeyChar;

                // Movemos el cursor al final
                txtBuscarProducto.SelectionStart = txtBuscarProducto.Text.Length;

                // Disparamos el evento de filtrado
                FiltrarProductos();

                // Evitamos que la letra se repita en otro control
                e.Handled = true;
            }
        }

        private void dgvItemsVenta_KeyDown_Backspace(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) // <-- esta es la tecla borrar/retroceso
            {
                if (dgvItemsVenta.CurrentRow != null && dgvItemsVenta.CurrentRow.DataBoundItem != null)
                {
                    var result = MessageBox.Show("¿Desea eliminar el producto seleccionado?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        itemVentaBindingSource.Remove(dgvItemsVenta.CurrentRow.DataBoundItem);

                        // Seleccionar otra fila si hay elementos
                        if (dgvItemsVenta.Rows.Count > 0)
                            dgvItemsVenta.CurrentCell = dgvItemsVenta.Rows[0].Cells[0];
                    }
                }

                e.Handled = true;
            }
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvProductos.CurrentRow != null)
            {
                e.Handled = true; // Evita que Enter pase al siguiente control

                Producto producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

                // Pedir cantidad al usuario
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Ingrese la cantidad para {producto.Nombre}:",
                    "Agregar producto",
                    "1" // valor por defecto
                );

                if (decimal.TryParse(input, out decimal cantidad) && cantidad > 0)
                {
                    // Validar si es por unidad que no tenga decimales
                    if (producto.Tipo == TipoProducto.Unidad && cantidad != Math.Floor(cantidad))
                    {
                        MessageBox.Show("No se pueden vender fracciones de una unidad. Ingrese un número entero.");
                        return;
                    }

                    // Ahora podés reutilizar la lógica que ya tenés en btnAgregarProducto
                    txtAgregarProducto.Text = cantidad.ToString();
                    btnAgregarProducto.PerformClick();
                }
            }
        }
        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProducto.PerformClick(); // Ejecuta la búsqueda
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dgvProductos.Focus(); // Devuelve el foco a la grilla
                e.Handled = true;
            }
        }


        private void FiltrarProductos()
        {
            string filtro = txtBuscarProducto.Text.ToLower();
            var listaFiltrada = productoBindingSource.DataSource as List<Producto>;

            if (listaFiltrada != null)
            {
                var resultado = listaFiltrada
                    .Where(p => p.Nombre.ToLower().Contains(filtro))
                    .ToList();

                productoBindingSource.DataSource = resultado;
            }
        }


        //*****************************FIN DE CONTROLES DE TECLADO PARA MOVERSE ENTRE GRILLAS***********************//



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

            dgvItemsVenta.AutoGenerateColumns = false;

            // Agregar columna ProductoNombre al inicio, con nombre "ProductoNombre"
            dgvItemsVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto Nombre",      // lo que ve el usuario
                DataPropertyName = "ProductoNombre", // propiedad de ItemVenta
                Name = "ProductoNombre",
                Width = 200

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
                HeaderText = "Tipo",
                Name = "ProductoTipo",
                Width = 80
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

            // Ocultar la columna "Producto"
            if (dgvItemsVenta.Columns["Producto"] != null)
                dgvItemsVenta.Columns["Producto"].Visible = false;

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

            // Validar que no haya decimales si es por unidad
            if (producto.Tipo == TipoProducto.Unidad && cantidad != Math.Floor(cantidad))
            {
                MessageBox.Show("No se pueden vender fracciones de una unidad. Ingrese un número entero.");
                return;
            }

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

            if (cbClientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMediosDePago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un medio de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                decimal total = itemsVenta.Sum(i => i.Subtotal);
                decimal deuda = pagoParcial > 0 ? total - pagoParcial : 0;

                Venta venta = new Venta
                {
                    Fecha = DateTime.Now,
                    Cliente = (Cliente)cbClientes.SelectedItem,
                    ValorTotal = total,
                    PagoParcial = pagoParcial,
                    DeudaCompra = deuda,
                    FormatoPago = cbMediosDePago.SelectedItem is MedioDePago mp ? mp.Nombre : "No especificado",
                    Items = new List<ItemVenta>(itemsVenta)
                };

                VentaDAO dao = new VentaDAO();
                int ventaID = dao.InsertarVenta(venta);

                if (ventaID > 0)
                {
                    dao.InsertarItemsVenta(ventaID, venta.Items);

                    // Actualizar deuda del cliente solo si hubo pago parcial
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


        //PARA FORMATEAR LA PROPIEDAS PESO A KG
        private void dgvItemsVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvItemsVenta.Columns[e.ColumnIndex].Name == "ProductoTipo")
            {
                if (dgvItemsVenta.Rows[e.RowIndex].DataBoundItem is ItemVenta item)
                {
                    e.Value = item.Producto.Tipo == TipoProducto.Peso ? "KG" : "Unidad";
                    e.FormattingApplied = true;
                }
            }
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}
