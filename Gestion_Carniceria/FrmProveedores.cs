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

            // Configurar columnas para que no sean editables
            dgvProveedor.Columns["ID"].ReadOnly = true;
            dgvProveedor.Columns["CuentaCorriente"].ReadOnly = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDescripcion.Clear();
        }



        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, completá los campos obligatorios: Nombre, Teléfono y Correo.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Proveedor nuevoProveedor = new Proveedor
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    CuentaCorriente = 0m // Cuenta corriente inicializada a 0
                };

                ProveedorDAO dao = new ProveedorDAO();
                bool resultado = dao.CrearProveedor(nuevoProveedor);

                if (resultado)
                {
                    MessageBox.Show("Proveedor creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedoresEnGrilla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el proveedor. Verificá que no esté duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear proveedor: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Proveedor proveedorActual = null;



        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccioná un proveedor para eliminar.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que querés eliminar este proveedor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvProveedor.SelectedRows[0];

                    if (filaSeleccionada.DataBoundItem is Proveedor proveedor)
                    {
                        int idProveedor = proveedor.ID;

                        ProveedorDAO dao = new ProveedorDAO();
                        bool eliminado = dao.EliminarProveedor(idProveedor);

                        if (eliminado)
                        {
                            MessageBox.Show("Proveedor eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarProveedoresEnGrilla();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el proveedor. Puede estar asociado a otros registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener el proveedor seleccionado.", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al eliminar el proveedor: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProveedor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];
                if (fila.DataBoundItem is Proveedor proveedorEditado)
                {
                    // Validaciones básicas
                    if (string.IsNullOrWhiteSpace(proveedorEditado.Nombre) ||
                        string.IsNullOrWhiteSpace(proveedorEditado.Telefono) ||
                        string.IsNullOrWhiteSpace(proveedorEditado.Correo) ||
                        string.IsNullOrWhiteSpace(proveedorEditado.Descripcion))
                    {
                        MessageBox.Show("Ningún campo puede quedar vacío. Se deshará el cambio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CargarProveedoresEnGrilla(); // Volver a cargar la grilla para revertir
                        return;
                    }

                    DialogResult confirmacion = MessageBox.Show(
                        "¿Deseás guardar los cambios realizados en este proveedor?",
                        "Confirmar modificación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        ProveedorDAO dao = new ProveedorDAO();
                        bool actualizado = dao.ActualizarProveedor(proveedorEditado);

                        if (!actualizado)
                        {
                            MessageBox.Show("No se pudo actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CargarProveedoresEnGrilla(); // Deshacer cambios
                        }
                    }
                    else
                    {
                        CargarProveedoresEnGrilla(); // Deshacer cambios
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnVolverAlMenuP_Click(object sender, EventArgs e)
        {
            this.Close(); // Simplemente cerrás la ventana actual
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            // Validar que al menos un campo tenga contenido
            if (string.IsNullOrWhiteSpace(txtNombreBuscar.Text) &&
                string.IsNullOrWhiteSpace(txtTelefonoBuscar.Text) &&
                string.IsNullOrWhiteSpace(txtDescripcionBuscar.Text) &&
                string.IsNullOrWhiteSpace(txtCorreoBuscar.Text))
            {
                MessageBox.Show("Por favor, completá al menos un campo para realizar la búsqueda.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Normalizamos texto a minúsculas y sin espacios al inicio/fin
            string nombre = txtNombreBuscar.Text.Trim().ToLower();
            string telefono = txtTelefonoBuscar.Text.Trim().ToLower();
            string descripcion = txtDescripcionBuscar.Text.Trim().ToLower();
            string correo = txtCorreoBuscar.Text.Trim().ToLower();

            dgvProveedor.ClearSelection(); // Limpiar selección anterior

            foreach (DataGridViewRow fila in dgvProveedor.Rows)
            {
                if (fila.DataBoundItem is Proveedor proveedor)
                {
                    bool coincide = false;

                    if (!string.IsNullOrEmpty(nombre) && proveedor.Nombre.ToLower().Contains(nombre))
                        coincide = true;

                    if (!string.IsNullOrEmpty(telefono) && proveedor.Telefono.ToLower().Contains(telefono))
                        coincide = true;

                    if (!string.IsNullOrEmpty(descripcion) && proveedor.Descripcion.ToLower().Contains(descripcion))
                        coincide = true;

                    if (!string.IsNullOrEmpty(correo) && proveedor.Correo.ToLower().Contains(correo))
                        coincide = true;

                    if (coincide)
                        fila.Selected = true;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
