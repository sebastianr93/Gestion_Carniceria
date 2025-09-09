using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Carniceria.Data; 
using Gestion_Carniceria.Entities;
using ClosedXML.Excel; // Para exportar a Excel
using System.IO;

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
            InicializarLabelsDetalleVenta();
            CargarMediosDePago();
        }

        //lista para guardar busquedas originales
        private List<RegistroVentaView> ventasOriginales;

        private void InicializarLabelsDetalleVenta()
        {
            lblNombreCliente.Text = string.Empty;
            lblFechaVenta.Text = string.Empty;
            lblValorTotal.Text = string.Empty;
            lblMontoAbonado.Text = string.Empty;
        }

        private void CargarMediosDePago()
        {
            cmbMDP.Items.Clear();
            cmbMDP.Items.Add(""); // Opción vacía (sin filtro)

            MedioDePagoDAO dao = new MedioDePagoDAO();
            List<MedioDePago> lista = dao.ObtenerTodos();

            foreach (MedioDePago mdp in lista)
            {
                cmbMDP.Items.Add(mdp.Nombre);
            }

            cmbMDP.SelectedIndex = 0;
        }

        // Botón Buscar: filtra las ventas por nombre o apellido del cliente
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtNombreCliente.Text.Trim().ToLower();
            DateTime fechaBuscada = dtpFechaBuscar.Value.Date;
            string mdpBuscado = cmbMDP.SelectedItem?.ToString();

            // Filtramos desde ventasOriginales
            var listaFiltrada = ventasOriginales.Where(v =>
                (string.IsNullOrEmpty(textoBuscado) || v.NombreCliente.ToLower().Contains(textoBuscado)) &&
                (!dtpFechaBuscar.Checked || v.Fecha.Date == fechaBuscada) &&
                (string.IsNullOrEmpty(mdpBuscado) || v.FormatoPago == mdpBuscado)
            ).ToList();

            // Mostramos en el DataGridView
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaFiltrada;

            // Si no hay resultados, aviso
            if (listaFiltrada.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias con los criterios de búsqueda.",
                    "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Ocultar columna ID
            if (dgvVentas.Columns["ID"] != null)
            {
                dgvVentas.Columns["ID"].Visible = false;
            }
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

            // Convertimos a la lista que vas a mostrar
            ventasOriginales = ventas.Select(v => new RegistroVentaView
            {
                ID = v.ID,
                Fecha = v.Fecha,
                NombreCliente = v.Cliente.Nombre + " " + v.Cliente.Apellido,
                FormatoPago = v.FormatoPago,
                ValorTotal = v.ValorTotal,
                PagoParcial = v.PagoParcial
            }).ToList();

            // Enlazamos al DataGridView
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventasOriginales;

            // Ocultamos columna ID si existe
            if (dgvVentas.Columns["ID"] != null)
            {
                dgvVentas.Columns["ID"].Visible = false;
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalleVentaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0 && dgvVentas.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value != null)
            {
                int ventaID = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
                CargarDetalleVenta(ventaID);
            }
            if (dgvVentas.Columns["iDDataGridViewTextBoxColumn"] != null)
            {
                dgvVentas.Columns["iDDataGridViewTextBoxColumn"].Visible = false;
            }

        }

        private void CargarDetalleVenta(int ventaID)
        {

            VentaDAO ventaDAO = new VentaDAO();
            Venta venta = ventaDAO.ObtenerVentaPorID(ventaID);

            if (venta == null) return;

            lblNombreCliente.Text = $"{venta.Cliente.Nombre} {venta.Cliente.Apellido}";
            lblFechaVenta.Text = venta.Fecha.ToString("dd/MM/yyyy");
            lblValorTotal.Text = $"Valor Total: ${venta.ValorTotal:F2}";

            decimal monto = venta.PagoParcial > 0 ? venta.PagoParcial : venta.ValorTotal;
            lblMontoAbonado.Text = $"Monto Abonado: ${monto:F2}";

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

        private void btnExportar_Click(object sender, EventArgs e)
            {
                if (dgvVentas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivo Excel (*.xlsx)|*.xlsx",
                    FileName = "Ventas.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Ventas");

                        // Encabezados
                        for (int col = 0; col < dgvVentas.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgvVentas.Columns[col].HeaderText;
                        }

                        // Datos
                        for (int row = 0; row < dgvVentas.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvVentas.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dgvVentas.Rows[row].Cells[col].Value?.ToString();
                            }
                        }

                        try
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Exportación completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

}
}
