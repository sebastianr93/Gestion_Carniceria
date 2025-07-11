using Gestion_Carniceria.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Carniceria.Data
{
    public class VentaProductoDAO
    {
        // 👉 Inserta un solo producto en una venta, pasando el VentaID por parámetro
        public void InsertarItem(int ventaID, ItemVenta item)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"INSERT INTO ventaproducto 
                                (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal)
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

        // 👉 Inserta una lista de productos en una venta
        public void InsertarItems(int ventaID, List<ItemVenta> items)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                foreach (var item in items)
                {
                    string query = @"INSERT INTO ventaproducto 
                                    (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal)
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

        // 👉 Devuelve todos los productos de una venta específica
        public List<ItemVenta> ObtenerItemsPorVenta(int ventaID)
        {
            List<ItemVenta> items = new List<ItemVenta>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT vp.ProductoID, vp.Cantidad, vp.PrecioUnitario, vp.Subtotal,
                           p.Nombre, p.Tipo, p.Precio
                    FROM ventaproducto vp
                    INNER JOIN producto p ON vp.ProductoID = p.ID
                    WHERE vp.VentaID = @VentaID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VentaID", ventaID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemVenta item = new ItemVenta
                        {
                            Cantidad = Convert.ToDecimal(reader["Cantidad"]),
                            Producto = new Producto
                            {
                                ID = reader.GetInt32("ProductoID"),
                                Nombre = reader.GetString("Nombre"),
                                Tipo = (TipoProducto)Enum.Parse(typeof(TipoProducto), reader.GetString("Tipo")),
                                Precio = reader.GetDecimal("Precio")
                            }
                        };

                        items.Add(item);
                    }
                }
            }

            return items;
        }

        // 👉 Elimina todos los productos asociados a una venta
        public void EliminarItemsPorVenta(int ventaID)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM ventaproducto WHERE VentaID = @VentaID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VentaID", ventaID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
