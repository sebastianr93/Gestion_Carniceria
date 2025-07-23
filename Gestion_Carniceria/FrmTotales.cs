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
            VentaDAO ventaDAO = new VentaDAO();

            decimal totalVentas = ventaDAO.ObtenerTotalVentas();
            DateTime desde = dateTimePicker1Inicio.Value.Date;
            DateTime hasta = dateTimePicker2Final.Value.Date;
            decimal deudaClientes = ventaDAO.ObtenerDeudaClientesPorFechas(desde, hasta);
            ProveedorDAO proveedorDAO = new ProveedorDAO();
            decimal deudaProveedores = proveedorDAO.ObtenerDeudaTotalProveedores();

            labelTotalVentasValor.Text = totalVentas.ToString("C2");

            labelTotalACobrarValor.Text = "$ " + deudaClientes.ToString("N2");
            labelDeudaProveedoresValor.Text = "$ " + "-" + deudaProveedores.ToString("N2");
        }

        private void ButtonBuscarEntreFechas_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1Inicio.Value.Date;
            DateTime hasta = dateTimePicker2Final.Value.Date.AddDays(1).AddSeconds(-1); // Para incluir toda la fecha

            VentaDAO ventaDAO = new VentaDAO();
            decimal totalVentas = ventaDAO.ObtenerTotalVentasPorFechas(desde, hasta);
            decimal deudaClientes = ventaDAO.ObtenerDeudaClientesPorFechas(desde, hasta);


            labelTotalVentasValor.Text = totalVentas.ToString("C2");
            labelTotalACobrarValor.Text = "$ " + deudaClientes.ToString("N2");

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
    }
}
