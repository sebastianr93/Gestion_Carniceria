using Gestion_Carniceria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Carniceria.Data
{
    public class VentaDAO
    {
        public int InsertarVenta(Venta venta)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"INSERT INTO venta (ClienteID, Fecha, FormatoPago, ValorTotal, PagoParcial)
                         VALUES (@ClienteID, @Fecha, @FormatoPago, @ValorTotal, @PagoParcial);
                         SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClienteID", venta.Cliente.ID);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@FormatoPago", venta.FormatoPago);
                cmd.Parameters.AddWithValue("@ValorTotal", venta.ValorTotal);
                cmd.Parameters.AddWithValue("@PagoParcial", venta.PagoParcial);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void InsertarItemsVenta(int ventaID, List<ItemVenta> items)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                foreach (var item in items)
                {
                    string query = @"INSERT INTO ventaproducto (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal)
                                 VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioUnitario, @Subtotal)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@VentaID", ventaID);
                    cmd.Parameters.AddWithValue("@ProductoID", item.Producto.ID);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
