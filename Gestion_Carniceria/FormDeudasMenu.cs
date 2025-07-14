using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Carniceria
{
    public partial class FormDeudasMenu : Form
    {
        public FormDeudasMenu()
        {
            InitializeComponent();
        }

        private void buttonClientesD_Click(object sender, EventArgs e)
        {
            FrmClientesDeuda formClientesDeuda = new FrmClientesDeuda();
            formClientesDeuda.Show(); // Podés usar ShowDialog() si querés que sea modal
        }


        private void buttonProveedoresD_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
