using Gestion_Carniceria.Data;
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
    public partial class FrmTotales : Form
    {
        public FrmTotales()
        {
            InitializeComponent();
            this.Load += FrmTotales_Load;

            // Inicializar los label con valores por defecto
            labelTotalVentasValor.Text = "$ 0.00";
            labelTotalACobrarValor.Text = "$ 0.00";
            labelTotalACobrarValor.Text = "$ 0.00";
            labelDeudaProveedoresValor.Text = "$ 0.00";
        }


        private void FrmTotales_Load(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1Inicio.Value.Date;
            DateTime hasta = dateTimePicker2Final.Value.Date.AddDays(1).AddSeconds(-1);

            VentaDAO ventaDAO = new VentaDAO();
            PedidoDAO pedidoDAO = new PedidoDAO();
            ClienteDAO clienteDAO = new ClienteDAO();

            decimal totalVentas = ventaDAO.ObtenerTotalVentasPorFechas(desde, hasta);
            decimal deudaClientes = clienteDAO.ObtenerDeudaTotalClientes();


            decimal totalPedidos = pedidoDAO.ObtenerTotalPedidosPorFechas(desde, hasta);

            labelTotalVentasValor.Text = totalVentas.ToString("C2");
            labelTotalACobrarValor.Text = "$ " + deudaClientes.ToString("N2");

            labelDeudaProveedoresValor.Text = "$ " + totalPedidos.ToString("N2");

        }

        private void ButtonBuscarEntreFechas_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1Inicio.Value.Date;
            DateTime hasta = dateTimePicker2Final.Value.Date.AddDays(1).AddSeconds(-1); // Incluir toda la fecha

            VentaDAO ventaDAO = new VentaDAO();
            PedidoDAO pedidoDAO = new PedidoDAO();
            ClienteDAO clienteDAO = new ClienteDAO();

            decimal totalVentas = ventaDAO.ObtenerTotalVentasPorFechas(desde, hasta);
            decimal deudaClientes = clienteDAO.ObtenerDeudaTotalClientes();
            decimal totalCobrado = totalVentas - deudaClientes;
            decimal totalPedidos = pedidoDAO.ObtenerTotalPedidosPorFechas(desde, hasta);

            labelTotalVentasValor.Text = totalVentas.ToString("C2");
            labelTotalACobrarValor.Text = "$ " + deudaClientes.ToString("N2");
            labelDeudaProveedoresValor.Text = "$ " + totalPedidos.ToString("N2");

            // Cálculo del balance
            decimal balance = totalVentas - deudaClientes - totalPedidos;

            // Mostrar en un label (que vos podés llamar como quieras, ej: BalanceLabel)
            BalanceLabel.Text = "" + balance.ToString("C2");
            if (balance < 0)
                BalanceLabel.ForeColor = Color.Red;
            else
                BalanceLabel.ForeColor = Color.Green;
        }

        private void dateTimePicker1Inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2Final_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelDeudaProveedoresValor_Click(object sender, EventArgs e)
        {

        }

        private void BalanceLabel_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener total de ventas desde el label
                decimal totalVentas = decimal.Parse(labelTotalVentasValor.Text.Replace("$", "").Trim());

                // Obtener deuda total de todos los clientes desde la base
                ClienteDAO clienteDAO = new ClienteDAO();
                decimal deudaClientes = clienteDAO.ObtenerDeudaTotalClientes();

                // Obtener deuda de proveedores desde el label
                decimal deudaProveedores = decimal.Parse(labelDeudaProveedoresValor.Text.Replace("$", "").Trim());

                // Calcular balance
                decimal balance = totalVentas - deudaClientes - deudaProveedores;

                // Mostrar balance con color según positivo o negativo
                BalanceLabel.Text = "Balance: " + balance.ToString("C2");
                BalanceLabel.ForeColor = balance < 0 ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el balance: " + ex.Message);
            }
        }



    }
}
