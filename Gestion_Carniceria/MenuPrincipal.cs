namespace Gestion_Carniceria
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnDatosClientes_Click(object sender, EventArgs e)
        {
            FrmClientes formularioClientes = new FrmClientes();
            formularioClientes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDatosProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores formularioProveedores = new FrmProveedores();
            formularioProveedores.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmStock formularioStock = new FrmStock();
            formularioStock.ShowDialog();
        }

        private void btnPedidosClientes_Click(object sender, EventArgs e)
        {
            FrmPedidoClientes formularioPedidoClientes = new FrmPedidoClientes();
            formularioPedidoClientes.ShowDialog();
        }

        private void btnPedidosProveedores_Click(object sender, EventArgs e)
        {
            FrmPedidoProveedores formularioPedidoProveedores = new FrmPedidoProveedores();
            formularioPedidoProveedores.ShowDialog();
        }

        private void ActivarModoOscuro()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);

            foreach (Control c in this.Controls)
            {
                c.ForeColor = Color.White;

                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(50, 50, 50);
                    ((Button)c).FlatStyle = FlatStyle.Flat;
                    ((Button)c).FlatAppearance.BorderColor = Color.Gray;
                }
            }
        }

        private void ActivarModoClaro()
        {
            this.BackColor = SystemColors.Control;

            foreach (Control c in this.Controls)
            {
                c.ForeColor = SystemColors.ControlText;

                if (c is Button)
                {
                    c.BackColor = SystemColors.Control;
                    ((Button)c).FlatStyle = FlatStyle.Standard;
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void btnMediosDePago_Click(object sender, EventArgs e)
        {
            FrmMediosDePago frmMediosDePago = new FrmMediosDePago();
            frmMediosDePago.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas registroVentasForm = new FrmRegistroVentas();
            registroVentasForm.ShowDialog();
        }

   
        private void btnTotales_Click(object sender, EventArgs e)
        {
            FrmTotales frmTotales = new FrmTotales();
            frmTotales.ShowDialog();
        }

        private void btnCierreDelDia_Click(object sender, EventArgs e)
        {
            FrmCierreDelDia frmCierreDelDia = new FrmCierreDelDia();
            frmCierreDelDia.ShowDialog();
        }

        private void buttonHistorialPedidos_Click(object sender, EventArgs e)
        {
            FrmRegistroPedidos frmPedidos = new FrmRegistroPedidos();
            frmPedidos.ShowDialog();
        }

        private void DeudaClienteMenu_Click(object sender, EventArgs e)
        {
            FrmClientesDeuda frmDeudas = new FrmClientesDeuda();
            frmDeudas.ShowDialog();
        }

        private void CeuntaCorrienteMenu_Click(object sender, EventArgs e)
        {
            FrmProveedoresDeuda frmDeudasProveedores = new FrmProveedoresDeuda();
            frmDeudasProveedores.ShowDialog();
        }
    }

}
