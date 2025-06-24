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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedoresEnGrilla();
        }

        private void CargarProveedoresEnGrilla()
        {
            ProveedorDAO dao = new ProveedorDAO();
            List<Proveedor> lista = dao.ObtenerTodosLosProveedores();

            dgvProveedor.AutoGenerateColumns = true;
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDescripcion.Text = "";
            txtCuentaCorriente.Text = "";
        }


        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor nuevoProveedor = new Proveedor
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Descripcion = txtDescripcion.Text
                };

                decimal cuentaCorriente;
                if (decimal.TryParse(txtCuentaCorriente.Text, out cuentaCorriente))
                {
                    nuevoProveedor.AgregarAlaCuentaCorriente(cuentaCorriente);
                }
                else
                {
                    MessageBox.Show("Cuenta Corriente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProveedorDAO dao = new ProveedorDAO();
                bool resultado = dao.CrearProveedor(nuevoProveedor);

                if (resultado)
                {
                    MessageBox.Show("Proveedor creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedoresEnGrilla(); // Refresca la tabla
                    LimpiarCampos(); // Limpia los inputs
                }
                else
                {
                    MessageBox.Show("No se pudo crear el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Proveedor proveedorActual = null;



        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccioná un proveedor para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que querés eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = dgvProveedor.SelectedRows[0];
                    int idProveedor = Convert.ToInt32(fila.Cells[0].Value); // Asegurate de que la columna 0 sea el ID

                    ProveedorDAO dao = new ProveedorDAO();
                    bool eliminado = dao.EliminarProveedor(idProveedor);

                    if (eliminado)
                    {
                        MessageBox.Show("Proveedor eliminado con éxito.");
                        CargarProveedoresEnGrilla(); // Refresca la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proveedor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
                }
            }
        }


        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (proveedorActual == null)
            {
                // MODO EDITAR: cargar datos desde la fila seleccionada
                if (dgvProveedor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccioná un proveedor para editar.");
                    return;
                }

                try
                {
                    DataGridViewRow fila = dgvProveedor.SelectedRows[0];

                    proveedorActual = new Proveedor
                    {
                        ID = Convert.ToInt32(fila.Cells[0].Value),
                        Nombre = fila.Cells[1].Value.ToString(),
                        Telefono = fila.Cells[2].Value.ToString(),
                        Correo = fila.Cells[3].Value.ToString(),
                        Descripcion = fila.Cells[4].Value.ToString()
                    };

                    decimal cuentaCorriente;
                    if (decimal.TryParse(fila.Cells[5].Value.ToString(), out cuentaCorriente))
                        proveedorActual.AgregarAlaCuentaCorriente(cuentaCorriente);

                    // Cargar datos en los campos
                    txtNombre.Text = proveedorActual.Nombre;
                    txtTelefono.Text = proveedorActual.Telefono;
                    txtCorreo.Text = proveedorActual.Correo;
                    txtDescripcion.Text = proveedorActual.Descripcion;
                    txtCuentaCorriente.Text = proveedorActual.CuentaCorriente.ToString();

                    btnEditarProveedor.Text = "Guardar Cambios";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el proveedor: " + ex.Message);
                    proveedorActual = null;
                }
            }
            else
            {
                // MODO GUARDAR: guardar cambios
                proveedorActual.Nombre = txtNombre.Text.Trim();
                proveedorActual.Telefono = txtTelefono.Text.Trim();
                proveedorActual.Correo = txtCorreo.Text.Trim();
                proveedorActual.Descripcion = txtDescripcion.Text.Trim();

                decimal cuenta;
                if (decimal.TryParse(txtCuentaCorriente.Text, out cuenta))
                {
                    proveedorActual = new Proveedor
                    {
                        ID = proveedorActual.ID,
                        Nombre = proveedorActual.Nombre,
                        Telefono = proveedorActual.Telefono,
                        Correo = proveedorActual.Correo,
                        Descripcion = proveedorActual.Descripcion
                    };
                    proveedorActual.AgregarAlaCuentaCorriente(cuenta);
                }
                else
                {
                    MessageBox.Show("Cuenta Corriente debe ser un número válido.");
                    return;
                }

                ProveedorDAO dao = new ProveedorDAO();
                bool exito = dao.ActualizarProveedor(proveedorActual);

                if (exito)
                {
                    MessageBox.Show("Proveedor actualizado con éxito.");
                    CargarProveedoresEnGrilla();
                    LimpiarCampos();

                    proveedorActual = null;
                    btnEditarProveedor.Text = "Editar Proveedor";
                }
                else
                {
                    MessageBox.Show("Error al actualizar el proveedor.");
                }
            }
        }

        private void btnVolverAlMenuP_Click(object sender, EventArgs e)
        {
            this.Close(); // Simplemente cerrás la ventana actual
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
