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
        }


        private void FrmTotales_Load(object sender, EventArgs e)
        {
            VentaDAO ventaDAO = new VentaDAO();

            decimal totalVentas = ventaDAO.ObtenerTotalVentas();

            labelTotalVentasValor.Text = totalVentas.ToString("C2");
        }


    }
}
