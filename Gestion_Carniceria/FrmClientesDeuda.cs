using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Carniceria.Entities;

namespace Gestion_Carniceria
{
    public partial class FrmClientesDeuda : Form
    {
        public FrmClientesDeuda()
        {
            InitializeComponent();
        }

        private void FrmClientesDeuda_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> clientesConDeuda = dao.ObtenerClientesConDeuda();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientesConDeuda;
        }


        private void CargarClientesEnGrilla()
        {
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> lista = dao.ObtenerTodosLosClientes(); // Cambiar a ObtenerClientesConDeuda() si lo tenés
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> todos = dao.ObtenerClientesConDeuda(); // <-- cambio importante
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = todos;

            bool encontrado = false;

            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                bool coincide = true;

                if (!string.IsNullOrWhiteSpace(txtNombreBuscar.Text))
                {
                    string valor = fila.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtNombreBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtApellidoBuscar.Text))
                {
                    string valor = fila.Cells["apellidoDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtApellidoBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtDNIBuscar.Text))
                {
                    string valor = fila.Cells["dNIDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtDNIBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtCorreoBuscar.Text))
                {
                    string valor = fila.Cells["correoDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtCorreoBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtTelefonoBuscar.Text))
                {
                    string valor = fila.Cells["telefonoDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtTelefonoBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (coincide)
                {
                    fila.Selected = true;
                    dgvClientes.FirstDisplayedScrollingRowIndex = fila.Index;
                    encontrado = true;
                }
                else
                {
                    fila.Selected = false;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún cliente con esos datos.");
            }
        }



        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
