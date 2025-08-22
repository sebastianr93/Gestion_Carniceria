using Gestion_Carniceria.Data;
using Gestion_Carniceria.Entities;
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
    public partial class FrmMediosDePago : Form
    {
        public FrmMediosDePago()
        {
            InitializeComponent();
        }

        private MedioDePagoDAO medioDAO = new MedioDePagoDAO();

        private void FrmMediosDePago_Load(object sender, EventArgs e)
        {
            AjustesMDP();
            ConfigurarGrillaMediosPago();
        }

        private void AjustesMDP()
        {
            nudAjuste.Minimum = -100;
            nudAjuste.Maximum = 100;
            nudAjuste.Increment = 1;
            nudAjuste.DecimalPlaces = 0;
            nudAjuste.ThousandsSeparator = false;
            nudAjuste.TextAlign = HorizontalAlignment.Right;
            nudAjuste.Value = 0; // valor por defecto
        }

        private void ConfigurarGrillaMediosPago()
        {
            dgvMediosPago.AutoGenerateColumns = false;
            dgvMediosPago.Columns.Clear();

            dgvMediosPago.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 200
            });

            dgvMediosPago.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PorcentajeAjuste",
                HeaderText = "Ajuste (%)",
                Width = 100
            });

            dgvMediosPago.DataSource = medioDAO.ObtenerTodos();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int ajuste = (int)nudAjuste.Value;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el medio de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MedioDePago nuevo = new MedioDePago
            {
                Nombre = nombre,
                PorcentajeAjuste = ajuste
            };

            if (medioDAO.Crear(nuevo))
            {
                MessageBox.Show("Medio de pago creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                nudAjuste.Value = 0;
                ConfigurarGrillaMediosPago();
            }
            else
            {
                MessageBox.Show("No se pudo crear el medio de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMediosPago.CurrentRow?.DataBoundItem is not MedioDePago seleccionado)
            {
                MessageBox.Show("Debe seleccionar un medio de pago para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"¿Seguro que desea eliminar el medio de pago '{seleccionado.Nombre}'?",
                                          "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (medioDAO.Eliminar(seleccionado.ID))
                {
                    MessageBox.Show("Medio de pago eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConfigurarGrillaMediosPago();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el medio de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMediosPago_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMediosPago.CurrentRow?.DataBoundItem is MedioDePago editado)
            {
                // Validación adicional por seguridad
                if (editado.PorcentajeAjuste < -100 || editado.PorcentajeAjuste > 100)
                {
                    MessageBox.Show("El ajuste debe estar entre -100% y 100%.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ConfigurarGrillaMediosPago(); // Deshacer
                    return;
                }

                if (!medioDAO.Actualizar(editado))
                {
                    MessageBox.Show("No se pudo actualizar el medio de pago en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvMediosPago_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvMediosPago.Columns[e.ColumnIndex].DataPropertyName == "PorcentajeAjuste")
            {
                string input = e.FormattedValue.ToString();

                if (!int.TryParse(input, out int valor))
                {
                    dgvMediosPago.Rows[e.RowIndex].ErrorText = "Solo se permiten números enteros.";
                    e.Cancel = true;
                    return;
                }

                if (valor < -100 || valor > 100)
                {
                    dgvMediosPago.Rows[e.RowIndex].ErrorText = "El valor debe estar entre -100 y 100.";
                    e.Cancel = true;
                    return;
                }

                dgvMediosPago.Rows[e.RowIndex].ErrorText = string.Empty;
            }
        }


        private void dgvMediosPago_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is MedioDePago medio)
            {
                var confirm = MessageBox.Show($"¿Seguro que desea eliminar el medio de pago '{medio.Nombre}'?",
                                              "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    e.Cancel = true; // cancelar la eliminación
                }
            }

        }
    }
}
