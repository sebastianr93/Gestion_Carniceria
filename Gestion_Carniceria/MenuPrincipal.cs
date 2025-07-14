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
            formularioClientes.Show();
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
            formularioProveedores.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmStock formularioStock = new FrmStock();
            formularioStock.Show();
        }

        private void btnPedidosClientes_Click(object sender, EventArgs e)
        {
            FrmPedidoClientes formularioPedidoClientes = new FrmPedidoClientes();
            formularioPedidoClientes.Show();
        }

        private void btnPedidosProveedores_Click(object sender, EventArgs e)
        {
            FrmPedidoProveedores formularioPedidoProveedores = new FrmPedidoProveedores();
            formularioPedidoProveedores.Show();
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
            frmAbout.Show();
        }

        private void btnMediosDePago_Click(object sender, EventArgs e)
        {
            FrmMediosDePago frmMediosDePago = new FrmMediosDePago();
            frmMediosDePago.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("¡Conexión exitosa a la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo abrir la conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas registroVentasForm = new FrmRegistroVentas();
            registroVentasForm.Show(); // Esto abre el formulario de forma no modal
                                       // Si querés que sea modal (bloquea el formulario padre), usá:
                                       // registroVentasForm.ShowDialog();
        }

    }

}
