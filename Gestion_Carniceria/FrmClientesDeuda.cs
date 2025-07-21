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
            comboBoxDeuda.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxPagoParcial.Enabled = false;
            buttonPagarDeuda.Enabled = false;
        }


        private void CargarClientesEnGrilla()
        {
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> lista = dao.ObtenerClientesConDeuda(); // Cambiar a ObtenerClientesConDeuda() si lo tenés
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

        private void comboBoxDeuda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDeuda.SelectedItem == null)
                return; // No hacer nada si no hay selección

            string seleccion = comboBoxDeuda.SelectedItem.ToString();

            if (seleccion == "Parcial")
            {
                textBoxPagoParcial.Enabled = true;
                buttonPagarDeuda.Enabled = true;
            }
            else if (seleccion == "Total")
            {
                textBoxPagoParcial.Enabled = false;
                textBoxPagoParcial.Text = ""; // opcional
                buttonPagarDeuda.Enabled = true;
            }
        }


        private void textBoxPagoParcial_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPagarDeuda_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un cliente primero.");
                return;
            }

            if (comboBoxDeuda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un tipo de pago (Parcial o Total).");
                return;
            }

            string tipoPago = comboBoxDeuda.SelectedItem.ToString();
            Cliente clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

            decimal nuevaDeuda = clienteSeleccionado.Deuda;

            if (tipoPago == "Total")
            {
                nuevaDeuda = 0;
            }
            else if (tipoPago == "Parcial")
            {
                if (!decimal.TryParse(textBoxPagoParcial.Text, out decimal montoParcial))
                {
                    MessageBox.Show("Ingresá un valor numérico válido.");
                    return;
                }

                if (montoParcial <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a 0.");
                    return;
                }

                if (montoParcial > clienteSeleccionado.Deuda)
                {
                    MessageBox.Show("El monto ingresado es mayor a la deuda del cliente.");
                    return;
                }

                nuevaDeuda -= montoParcial;
            }

            // 🔔 Confirmación con detalle
            string mensajeConfirmacion = "";

            if (tipoPago == "Total")
            {
                mensajeConfirmacion = $"Vas a saldar la deuda total del cliente ({clienteSeleccionado.Deuda:C}).\n¿Deseás continuar?";
            }
            else if (tipoPago == "Parcial")
            {
                mensajeConfirmacion = $"Vas a descontar {textBoxPagoParcial.Text} de una deuda de {clienteSeleccionado.Deuda:C}.\n" +
                                      $"La nueva deuda será de {nuevaDeuda:C}.\n¿Deseás continuar?";
            }

            DialogResult confirmacion = MessageBox.Show(
                mensajeConfirmacion,
                "Confirmar pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes)
            {
                return; // Cancela si el usuario responde "No"
            }

            // 🧾 Guardar nueva deuda
            clienteSeleccionado.Deuda = nuevaDeuda;

            ClienteDAO dao = new ClienteDAO();
            bool actualizado = dao.ActualizarDeuda(clienteSeleccionado);

            if (actualizado)
            {
                MessageBox.Show("La deuda fue actualizada correctamente.");
                CargarClientesEnGrilla();
                comboBoxDeuda.SelectedIndex = -1;
                textBoxPagoParcial.Text = "";
                textBoxPagoParcial.Enabled = false;
                buttonPagarDeuda.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la deuda.");
            }
        }



    }
}
