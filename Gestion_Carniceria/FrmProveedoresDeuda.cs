using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Carniceria
{
    public partial class FrmProveedoresDeuda : Form
    {
        public FrmProveedoresDeuda()
        {
            InitializeComponent();
            this.Load += FrmProveedoresDeuda_Load;
        }

        private void FrmProveedoresDeuda_Load(object sender, EventArgs e)
        {
            CargarProveedoresEnGrilla();
            comboBoxDeuda.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxPagoParcial.Enabled = false;
            buttonPagarDeuda.Enabled = false;
        }

        private void CargarProveedoresEnGrilla()
        {
            ProveedorDAO proveedorDAO = new ProveedorDAO();
            List<Proveedor> listaProveedores = proveedorDAO.ObtenerTodosLosProveedores();
            var proveedoresConDeuda = listaProveedores
                .Where(p => p.CuentaCorriente > 0)
                .ToList();

            dataGridViewProveedoresDeuda.DataSource = null;
            dataGridViewProveedoresDeuda.DataSource = proveedoresConDeuda;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProveedorDAO dao = new ProveedorDAO();
            List<Proveedor> proveedores = dao.ObtenerTodosLosProveedores()
                .Where(p => p.CuentaCorriente > 0)
                .ToList();

            dataGridViewProveedoresDeuda.DataSource = null;
            dataGridViewProveedoresDeuda.DataSource = proveedores;

            bool encontrado = false;

            foreach (DataGridViewRow fila in dataGridViewProveedoresDeuda.Rows)
            {
                bool coincide = true;

                if (!string.IsNullOrWhiteSpace(txtNombreBuscar.Text))
                {
                    string valor = fila.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtNombreBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtApellidoBuscar.Text)) //LO USE PARA DESCRIPCIÓN
                {
                    string valor = fila.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                    if (!valor.Contains(txtApellidoBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
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
                    dataGridViewProveedoresDeuda.FirstDisplayedScrollingRowIndex = fila.Index;
                    encontrado = true;
                }
                else
                {
                    fila.Selected = false;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún proveedor con esos datos.");
            }
        }

        private void comboBoxDeuda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDeuda.SelectedItem == null)
                return;

            string seleccion = comboBoxDeuda.SelectedItem.ToString();

            if (seleccion == "Parcial")
            {
                textBoxPagoParcial.Enabled = true;
                buttonPagarDeuda.Enabled = true;
            }
            else if (seleccion == "Total")
            {
                textBoxPagoParcial.Enabled = false;
                textBoxPagoParcial.Text = "";
                buttonPagarDeuda.Enabled = true;
            }
        }

        private void buttonPagarDeuda_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedoresDeuda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un proveedor primero.");
                return;
            }

            if (comboBoxDeuda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un tipo de pago (Parcial o Total).");
                return;
            }

            string tipoPago = comboBoxDeuda.SelectedItem.ToString();
            Proveedor proveedorSeleccionado = (Proveedor)dataGridViewProveedoresDeuda.SelectedRows[0].DataBoundItem;

            decimal nuevaDeuda = proveedorSeleccionado.CuentaCorriente;

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

                if (montoParcial > proveedorSeleccionado.CuentaCorriente)
                {
                    MessageBox.Show("El monto ingresado es mayor a la deuda del proveedor.");
                    return;
                }

                nuevaDeuda -= montoParcial;
            }

            string mensajeConfirmacion = tipoPago == "Total"
                ? $"Vas a saldar la deuda total del proveedor ({proveedorSeleccionado.CuentaCorriente:C}).\n¿Deseás continuar?"
                : $"Vas a descontar {textBoxPagoParcial.Text} de una deuda de {proveedorSeleccionado.CuentaCorriente:C}.\n" +
                  $"La nueva deuda será de {nuevaDeuda:C}.\n¿Deseás continuar?";

            DialogResult confirmacion = MessageBox.Show(
                mensajeConfirmacion,
                "Confirmar pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes)
                return;

            proveedorSeleccionado.CuentaCorriente = nuevaDeuda;

            ProveedorDAO dao = new ProveedorDAO();
            bool actualizado = dao.ActualizarProveedor(proveedorSeleccionado);

            if (actualizado)
            {
                MessageBox.Show("La deuda fue actualizada correctamente.");
                CargarProveedoresEnGrilla();
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
        private void textBoxPagoParcial_TextChanged(object sender, EventArgs e)
        {
            // (opcional) lógica de validación en tiempo real
        }

        private void dataGridViewProveedoresDeuda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // (opcional) lógica si querés manejar clicks en celdas
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
