using Gestion_Carniceria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace Gestion_Carniceria
{
    public partial class FrmCierreDelDia : Form
    {
        public FrmCierreDelDia()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaCierre.Value.Date;

            VentaDAO dao = new VentaDAO();
            List<Venta> ventas = dao.ObtenerVentasPorFecha(fechaSeleccionada);

            dgvVentasDelDia.DataSource = null;
            dgvVentasDelDia.DataSource = ventas.Select(v => new
            {
                v.ID,
                v.Fecha,
                Cliente = v.Cliente.Nombre + " " + v.Cliente.Apellido,
                v.FormatoPago,
                v.ValorTotal,
                v.PagoParcial
            }).ToList();

            decimal totalRecaudado = ventas.Sum(v => v.PagoParcial > 0 ? v.PagoParcial : v.ValorTotal);
            lblTotalRecaudado.Text = $"${totalRecaudado:N2}";
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvVentasDelDia.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Primero debe generar el cierre del día.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                sfd.FileName = $"CierreDelDia_{dtpFechaCierre.Value:yyyyMMdd}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var hoja = workbook.Worksheets.Add("Cierre del Día");

                            // Encabezados
                            for (int i = 0; i < dgvVentasDelDia.Columns.Count; i++)
                            {
                                hoja.Cell(1, i + 1).Value = dgvVentasDelDia.Columns[i].HeaderText;
                            }

                            // Datos
                            for (int i = 0; i < dgvVentasDelDia.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvVentasDelDia.Columns.Count; j++)
                                {
                                    hoja.Cell(i + 2, j + 1).Value = dgvVentasDelDia.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // Total recaudado
                            int filaTotal = dgvVentasDelDia.Rows.Count + 3;
                            hoja.Cell(filaTotal, 1).Value = "TOTAL RECAUDADO:";
                            hoja.Cell(filaTotal, 2).Value = lblTotalRecaudado.Text;

                            // Ajustes visuales
                            hoja.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Archivo exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
