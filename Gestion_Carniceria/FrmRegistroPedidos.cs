using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gestion_Carniceria.Data;
using Gestion_Carniceria.Entities;

namespace Gestion_Carniceria
{
    public partial class FrmRegistroPedidos : Form
    {
        public FrmRegistroPedidos()
        {
            InitializeComponent();
            this.Load += FrmRegistroPedidos_Load;
            dataGridViewPedidosHistorial.SelectionChanged += dataGridViewPedidosHistorial_SelectionChanged;
        }

        private void FrmRegistroPedidos_Load(object sender, EventArgs e)
        {
            CargarTodosLosPedidos();
            InicializarLabelsDetallePedido();
        }

        private void InicializarLabelsDetallePedido()
        {
            lblProveedor.Text = string.Empty;
            lblFechaPedido.Text = string.Empty;
            lblValorTotal.Text = string.Empty;
            lblPagoParcial.Text = string.Empty;
        }

        private void CargarTodosLosPedidos()
        {
            PedidoDAO dao = new PedidoDAO();
            var pedidos = dao.ObtenerTodosLosPedidos();

            var listaMostrar = pedidos.Select(p => new
            {
                ID = p.ID,
                Fecha = p.Fecha.ToString("dd/MM/yyyy"),
                Proveedor = p.Proveedor.Nombre,
                Total = p.ValorTotal,
                PagoParcial = p.PagoParcial
            }).ToList();

            dataGridViewPedidosHistorial.AutoGenerateColumns = true; // <- Asegurate de esto también
            dataGridViewPedidosHistorial.DataSource = null;
            dataGridViewPedidosHistorial.DataSource = listaMostrar;

            // 👇 Esto muestra los nombres de columnas reales
            foreach (DataGridViewColumn col in dataGridViewPedidosHistorial.Columns)
            {
                Console.WriteLine($"Columna: {col.Index} - {col.Name}");
            }
        }

        private void dataGridViewPedidosHistorial_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPedidosHistorial.SelectedRows.Count > 0 &&
                dataGridViewPedidosHistorial.SelectedRows[0].Cells["ID"].Value != null)
            {
                int pedidoID = Convert.ToInt32(dataGridViewPedidosHistorial.SelectedRows[0].Cells["ID"].Value);
                CargarDetallePedido(pedidoID);
            }
        }



        private void CargarDetallePedido(int pedidoID)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            Pedido pedido = pedidoDAO.ObtenerPedidoPorID(pedidoID);

            if (pedido == null) return;

            lblProveedor.Text = $"Proveedor: {pedido.Proveedor.Nombre}";
            lblFechaPedido.Text = $"Fecha: {pedido.Fecha:dd/MM/yyyy}";
            lblValorTotal.Text = $"Total: ${pedido.ValorTotal:F2}";
            lblPagoParcial.Text = $"Pago Parcial: ${pedido.PagoParcial:F2}";

            ItemPedidoDAO dao = new ItemPedidoDAO();
            List<ItemPedido> items = dao.ObtenerItemsPorPedido(pedidoID);

            var listaMostrar = items.Select(i => new
            {
                Producto = i.Producto.Nombre,
                Tipo = i.Producto.Tipo,
                Cantidad = i.Cantidad,
                PrecioUnitario = i.PrecioUnitario,
                Subtotal = i.Cantidad * i.PrecioUnitario
            }).ToList();

            dataGridViewDetallePedido.DataSource = null;
            dataGridViewDetallePedido.DataSource = listaMostrar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Podés implementar búsqueda más adelante si querés
        }

        private void dataGridViewPedidosHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Podés dejarlo vacío si no lo usás
        }
    }
}
