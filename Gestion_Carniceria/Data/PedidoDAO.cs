using Gestion_Carniceria.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Carniceria.Data
{
    public class PedidoDAO
    {
        public static bool InsertarPedido(Pedido pedido)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                MySqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    // 1. Insertar el pedido
                    string sqlPedido = @"INSERT INTO pedido (fecha, valortotal, pagoparcial, id_proveedor)
                                         VALUES (@fecha, @valortotal, @pagoparcial, @id_proveedor);";

                    MySqlCommand cmdPedido = new MySqlCommand(sqlPedido, conn, transaccion);
                    cmdPedido.Parameters.AddWithValue("@fecha", pedido.Fecha);
                    cmdPedido.Parameters.AddWithValue("@valortotal", pedido.ValorTotal);
                    cmdPedido.Parameters.AddWithValue("@pagoparcial", pedido.PagoParcial);
                    cmdPedido.Parameters.AddWithValue("@id_proveedor", pedido.Proveedor.ID);

                    cmdPedido.ExecuteNonQuery();

                    // Obtener ID generado
                    long idPedido = cmdPedido.LastInsertedId;
                    pedido.ID = (int)idPedido;

                    // 2. Insertar ítems
                    foreach (var item in pedido.Items)
                    {
                        string sqlItem = @"INSERT INTO itempedido (id_pedido, id_producto, cantidad, preciounitario)
                                           VALUES (@id_pedido, @id_producto, @cantidad, @preciounitario);";

                        MySqlCommand cmdItem = new MySqlCommand(sqlItem, conn, transaccion);
                        cmdItem.Parameters.AddWithValue("@id_pedido", pedido.ID);
                        cmdItem.Parameters.AddWithValue("@id_producto", item.Producto.ID);
                        cmdItem.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        cmdItem.Parameters.AddWithValue("@preciounitario", item.PrecioUnitario);

                        cmdItem.ExecuteNonQuery();
                    }

                    // 3. Confirmar transacción
                    transaccion.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al insertar el pedido: " + ex.Message);
                }
            }
        }

        public decimal ObtenerTotalPedidosPorFechas(DateTime desde, DateTime hasta)
        {
            decimal totalPedidos = 0;

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT IFNULL(SUM(valortotal), 0) FROM pedido 
                         WHERE fecha BETWEEN @Desde AND @Hasta";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    totalPedidos = Convert.ToDecimal(result);
            }

            return totalPedidos;
        }

        public List<Pedido> ObtenerTodosLosPedidos()
        {
            List<Pedido> lista = new List<Pedido>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
            SELECT p.ID, p.Fecha, p.ValorTotal, p.PagoParcial,
                   pr.ID as ProveedorID, pr.Nombre as NombreProveedor
            FROM pedido p
            INNER JOIN proveedor pr ON p.id_proveedor = pr.ID
            ORDER BY p.Fecha DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pedido pedido = new Pedido
                        {
                            ID = reader.GetInt32("ID"),
                            Fecha = reader.GetDateTime("Fecha"),
                            ValorTotal = reader.GetDecimal("ValorTotal"),
                            PagoParcial = reader.GetDecimal("PagoParcial"),
                            Proveedor = new Proveedor
                            {
                                ID = reader.GetInt32("ProveedorID"),
                                Nombre = reader.GetString("NombreProveedor")
                            }
                        };

                        lista.Add(pedido);
                    }
                }
            }

            return lista;
        }

        public Pedido ObtenerPedidoPorID(int pedidoID)
        {
            Pedido pedido = null;

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
            SELECT p.ID, p.Fecha, p.ValorTotal, p.PagoParcial,
                   pr.ID as ProveedorID, pr.Nombre as NombreProveedor
            FROM pedido p
            INNER JOIN proveedor pr ON p.id_proveedor = pr.ID
            WHERE p.ID = @ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", pedidoID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pedido = new Pedido
                        {
                            ID = reader.GetInt32("ID"),
                            Fecha = reader.GetDateTime("Fecha"),
                            ValorTotal = reader.GetDecimal("ValorTotal"),
                            PagoParcial = reader.GetDecimal("PagoParcial"),
                            Proveedor = new Proveedor
                            {
                                ID = reader.GetInt32("ProveedorID"),
                                Nombre = reader.GetString("NombreProveedor")
                            }
                        };
                    }
                }
            }

            return pedido;
        }



    }
}

