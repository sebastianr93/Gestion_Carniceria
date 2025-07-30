using Gestion_Carniceria.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Carniceria.Data
{
    public class ItemPedidoDAO
    {
        // 👉 Inserta un solo item en un pedido (sin subtotal)
        public void InsertarItem(int pedidoID, ItemPedido item)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"INSERT INTO itempedido 
                                 (id_pedido, id_producto, cantidad, preciounitario)
                                 VALUES (@PedidoID, @ProductoID, @Cantidad, @PrecioUnitario)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
                cmd.Parameters.AddWithValue("@ProductoID", item.Producto.ID);
                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario);

                cmd.ExecuteNonQuery();
            }
        }

        // 👉 Inserta una lista de items en un pedido
        public void InsertarItems(int pedidoID, List<ItemPedido> items)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                foreach (var item in items)
                {
                    string query = @"INSERT INTO itempedido 
                                     (id_pedido, id_producto, cantidad, preciounitario)
                                     VALUES (@PedidoID, @ProductoID, @Cantidad, @PrecioUnitario)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
                    cmd.Parameters.AddWithValue("@ProductoID", item.Producto.ID);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 👉 Obtiene todos los items asociados a un pedido
        public List<ItemPedido> ObtenerItemsPorPedido(int pedidoID)
        {
            List<ItemPedido> items = new List<ItemPedido>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT ip.id_producto, ip.cantidad, ip.preciounitario,
                           p.Nombre, p.Tipo, p.Precio
                    FROM itempedido ip
                    INNER JOIN producto p ON ip.id_producto = p.ID
                    WHERE ip.id_pedido = @PedidoID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PedidoID", pedidoID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ItemPedido item = new ItemPedido
                        {
                            Cantidad = Convert.ToDecimal(reader["cantidad"]),
                            PrecioUnitario = Convert.ToDecimal(reader["preciounitario"]),
                            Producto = new Producto
                            {
                                ID = Convert.ToInt32(reader["id_producto"]),
                                Nombre = reader.GetString("Nombre"),
                                Tipo = (TipoProducto)Enum.Parse(typeof(TipoProducto), reader.GetString("Tipo")),
                                Precio = Convert.ToDecimal(reader["Precio"])
                            }
                        };

                        items.Add(item);
                    }
                }
            }

            return items;
        }

        // 👉 Elimina todos los items asociados a un pedido (opcional)
        public void EliminarItemsPorPedido(int pedidoID)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM itempedido WHERE id_pedido = @PedidoID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
