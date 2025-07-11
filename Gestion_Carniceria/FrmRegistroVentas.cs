using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Carniceria.Data;      // Para usar VentaDAO
using Gestion_Carniceria.Entities;  // Para usar Venta, Cliente, etc.

namespace Gestion_Carniceria
{
    public partial class FrmRegistroVentas : Form
    {
        public FrmRegistroVentas()
        {
            InitializeComponent();
        }

        // Se ejecuta al cargar el formulario
        private void FrmRegistroVentas_Load(object sender, EventArgs e)
        {
            CargarTodasLasVentas();
        }

        // Botón Buscar: filtra las ventas por nombre o apellido del cliente
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroCliente = textBox1.Text.Trim();
            string filtroFormatoPago = textBoxFP.Text.Trim();
            string filtroFecha = textBoxFecha.Text.Trim();

            VentaDAO dao = new VentaDAO();
            List<Venta> ventas = dao.ObtenerTodasLasVentas();

            // Filtro por Cliente (nombre o apellido)
            if (!string.IsNullOrEmpty(filtroCliente))
            {
                ventas = ventas.Where(v =>
                    (v.Cliente?.Nombre + " " + v.Cliente?.Apellido).ToLower().Contains(filtroCliente.ToLower())
                ).ToList();
            }

            // Filtro por Formato de Pago
            if (!string.IsNullOrEmpty(filtroFormatoPago))
            {
                ventas = ventas.Where(v =>
                    !string.IsNullOrEmpty(v.FormatoPago) && v.FormatoPago.ToLower().Contains(filtroFormatoPago.ToLower())
                ).ToList();
            }

            // Filtro por Fecha exacta (si se puede convertir a DateTime)
            if (!string.IsNullOrEmpty(filtroFecha) && DateTime.TryParse(filtroFecha, out DateTime fechaFiltro))
            {
                ventas = ventas.Where(v => v.Fecha.Date == fechaFiltro.Date).ToList();
            }

            // Convertir a vista
            List<RegistroVentaView> listaMostrar = ventas.Select(v => new RegistroVentaView
            {
                ID = v.ID,
                Fecha = v.Fecha,
                NombreCliente = v.Cliente.Nombre + " " + v.Cliente.Apellido,
                FormatoPago = v.FormatoPago,
                ValorTotal = v.ValorTotal,
                PagoParcial = v.PagoParcial
            }).ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaMostrar;
        }



        // Botón Volver: cierra el formulario
        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para cargar todas las ventas y mostrarlas en el DataGridView
        private void CargarTodasLasVentas()
        {
            VentaDAO dao = new VentaDAO();
            List<Venta> ventas = dao.ObtenerTodasLasVentas();

            List<RegistroVentaView> listaMostrar = ventas.Select(v => new RegistroVentaView
            {
                ID = v.ID,
                Fecha = v.Fecha,
                NombreCliente = v.Cliente.Nombre + " " + v.Cliente.Apellido,
                FormatoPago = v.FormatoPago,
                ValorTotal = v.ValorTotal,
                PagoParcial = v.PagoParcial
            }).ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaMostrar;
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalleVentaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0 && dgvVentas.SelectedRows[0].Cells["ID"].Value != null)
            {
                int ventaID = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["ID"].Value);
                CargarDetalleVenta(ventaID);
            }
        }

        private void CargarDetalleVenta(int ventaID)
        {
            VentaProductoDAO dao = new VentaProductoDAO();
            List<ItemVenta> items = dao.ObtenerItemsPorVenta(ventaID);

            var listaMostrar = items.Select(i => new
            {
                Producto = i.ProductoNombre,
                Tipo = i.ProductoTipo,
                Cantidad = i.Cantidad,
                PrecioUnitario = i.PrecioUnitario,
                Subtotal = i.Subtotal
            }).ToList();

            dgvDetalleVentaProducto.DataSource = null;
            dgvDetalleVentaProducto.DataSource = listaMostrar;
        }






    }
}
