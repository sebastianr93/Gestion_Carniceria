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





    }
}
