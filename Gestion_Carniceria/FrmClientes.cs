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

            // Configurar el DataGridView para que no permita editar ciertas columnas
            dgvClientes.Columns["ID"].ReadOnly = true;
            dgvClientes.Columns["Deuda"].ReadOnly = true;
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
                CargarClientesEnGrilla(); // Carga el cliente nuevo en el DataGridView

                // Limpiar los campos
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
                    string valor = fila.Cells["Nombre"].Value.ToString();
                    if (!valor.Contains(txtNombreBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtApellidoBuscar.Text))
                {
                    string valor = fila.Cells["Apellido"].Value.ToString();
                    if (!valor.Contains(txtApellidoBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtDNIBuscar.Text))
                {
                    string valor = fila.Cells["DNI"].Value.ToString();
                    if (!valor.Contains(txtDNIBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtCorreoBuscar.Text))
                {
                    string valor = fila.Cells["Correo"].Value.ToString();
                    if (!valor.Contains(txtCorreoBuscar.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                        coincide = false;
                }

                if (!string.IsNullOrWhiteSpace(txtTelefonoBuscar.Text))
                {
                    string valor = fila.Cells["Telefono"].Value.ToString();
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
            this.Close(); // Cierra el formulario actual y vuelve al menú principal
        }

        private void dgvClientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener fila y columna editada
                int filaIndex = e.RowIndex;
                int colIndex = e.ColumnIndex;

                if (filaIndex < 0 || colIndex < 0)
                    return;

                DataGridViewRow fila = dgvClientes.Rows[filaIndex];
                DataGridViewColumn columna = dgvClientes.Columns[colIndex];

                // No permitir editar ID ni Deuda
                if (columna.Name == "ID" || columna.Name == "Deuda")
                {
                    MessageBox.Show("No se puede modificar este campo.");
                    CargarClientesEnGrilla(); // recargar para revertir
                    return;
                }

                // Nuevo valor editado
                object nuevoValor = fila.Cells[colIndex].Value;

                // Opcional: validar no vacío
                if (nuevoValor == null || string.IsNullOrWhiteSpace(nuevoValor.ToString()))
                {
                    MessageBox.Show("El valor no puede estar vacío.");
                    CargarClientesEnGrilla();
                    return;
                }

                // Confirmación
                DialogResult respuesta = MessageBox.Show(
                    $"¿Confirma cambiar el campo '{columna.HeaderText}' al valor:\n{nuevoValor}?",
                    "Confirmar edición",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    CargarClientesEnGrilla();
                    return;
                }

                // Obtener el cliente de la fila actual para actualizar
                Cliente clienteModificado = new Cliente
                {
                    ID = Convert.ToInt32(fila.Cells["ID"].Value),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Apellido = fila.Cells["Apellido"].Value.ToString(),
                    Telefono = fila.Cells["Telefono"].Value.ToString(),
                    Correo = fila.Cells["Correo"].Value.ToString(),
                    DNI = fila.Cells["DNI"].Value.ToString(),
                    // Deuda no editable, no hace falta setear
                };

                // Actualizar en base de datos
                ClienteDAO dao = new ClienteDAO();
                bool exito = dao.ActualizarCliente(clienteModificado);

                if (exito)
                {
                    MessageBox.Show("Cliente actualizado con éxito.");
                    CargarClientesEnGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                    CargarClientesEnGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
                CargarClientesEnGrilla();
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
