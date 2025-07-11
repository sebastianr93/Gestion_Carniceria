using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Carniceria.Entities;

namespace Gestion_Carniceria
{
    public partial class FrmClientes : Form
    {


        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            CargarClientesEnGrilla();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string dni = txtDNI.Text;

            Cliente nuevoCliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Correo = correo,
                DNI = dni
            };

            ClienteDAO dao = new ClienteDAO();
            bool exito = dao.CrearCliente(nuevoCliente);

            if (exito)
            {
                MessageBox.Show("Cliente creado con éxito");
                CargarClientesEnGrilla(); // 👈 Carga el cliente nuevo en el DataGridView

                // Limpiar los campos si querés
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtDNI.Text = "";
            }
            else
            {
                MessageBox.Show("Error al crear el cliente");
            }
        }


        private void CargarClientesEnGrilla()
        {
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> lista = dao.ObtenerTodosLosClientes();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = lista;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Mostrar todos los clientes en la grilla
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> todos = dao.ObtenerTodosLosClientes();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = todos;

            bool encontrado = false;

            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                bool coincide = true;

                // Comparar cada campo si tiene texto
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

                // Si todos los campos coinciden, seleccionar fila
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
            this.Close(); // Simplemente cerrás la ventana actual
        }

        private Cliente clienteActual = null;

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                // MODO EDITAR - Obtener cliente de la fila seleccionada
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccioná un cliente para editar.");
                    return;
                }

                try
                {
                    DataGridViewRow fila = dgvClientes.SelectedRows[0];

                    clienteActual = new Cliente
                    {
                        ID = Convert.ToInt32(fila.Cells[0].Value),
                        Nombre = fila.Cells[1].Value.ToString(),
                        Apellido = fila.Cells[2].Value.ToString(),
                        Telefono = fila.Cells[3].Value.ToString(),
                        Correo = fila.Cells[4].Value.ToString(),
                        DNI = fila.Cells[5].Value.ToString()
                    };

                    // Cargar datos en los campos de texto
                    txtNombre.Text = clienteActual.Nombre;
                    txtApellido.Text = clienteActual.Apellido;
                    txtTelefono.Text = clienteActual.Telefono;
                    txtCorreo.Text = clienteActual.Correo;
                    txtDNI.Text = clienteActual.DNI;

                    // Cambiar texto del botón
                    btnEditarCliente.Text = "Guardar Cambios";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el cliente: " + ex.Message);
                    clienteActual = null;
                }
            }
            else
            {
                // MODO GUARDAR - Guardar cambios del cliente

                clienteActual.Nombre = txtNombre.Text.Trim();
                clienteActual.Apellido = txtApellido.Text.Trim();
                clienteActual.Telefono = txtTelefono.Text.Trim();
                clienteActual.Correo = txtCorreo.Text.Trim();
                clienteActual.DNI = txtDNI.Text.Trim();

                ClienteDAO dao = new ClienteDAO();
                bool exito = dao.ActualizarCliente(clienteActual);

                if (exito)
                {
                    MessageBox.Show("Cliente actualizado con éxito.");
                    CargarClientesEnGrilla();

                    // Limpiar campos
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtDNI.Text = "";

                    clienteActual = null;
                    btnEditarCliente.Text = "Editar Cliente";
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccioná un cliente para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que querés eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = dgvClientes.SelectedRows[0];
                    int idCliente = Convert.ToInt32(fila.Cells[0].Value); // Asegurate de que la columna 0 sea el ID

                    ClienteDAO dao = new ClienteDAO();
                    bool eliminado = dao.EliminarCliente(idCliente);

                    if (eliminado)
                    {
                        MessageBox.Show("Cliente eliminado con éxito.");
                        CargarClientesEnGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
