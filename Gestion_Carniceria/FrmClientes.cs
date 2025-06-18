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
            TemaApp.AplicarTema(this);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes TextBox para cada campo:
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string dni = txtDNI.Text;

            // Creas un nuevo cliente
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
                // Opcional: limpiar campos o actualizar lista
            }
            else
            {
                MessageBox.Show("Error al crear el cliente");
            }
        }



    }
}
