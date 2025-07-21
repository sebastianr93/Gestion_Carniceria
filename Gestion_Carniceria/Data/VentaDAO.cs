using Gestion_Carniceria.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

        // Nuevo método para obtener todas las ventas con info del cliente
        public List<Venta> ObtenerTodasLasVentas()
        {
            List<Venta> lista = new List<Venta>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT v.ID, v.Fecha, v.FormatoPago, v.ValorTotal, v.PagoParcial,
                           c.ID as ClienteID, c.Nombre, c.Apellido
                    FROM venta v
                    INNER JOIN cliente c ON v.ClienteID = c.ID
                    ORDER BY v.Fecha DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta
                        {
                            ID = reader.GetInt32("ID"),
                            Fecha = reader.GetDateTime("Fecha"),
                            FormatoPago = reader.GetString("FormatoPago"),
                            ValorTotal = reader.GetDecimal("ValorTotal"),
                            PagoParcial = reader.GetDecimal("PagoParcial"),
                            Cliente = new Cliente
                            {
                                ID = reader.GetInt32("ClienteID"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido")
                            }
                        };
                        lista.Add(venta);
                    }
                }
            }

            return lista;
        }

        // Nuevo método para obtener ventas filtrando por nombre o apellido cliente
        public List<Venta> ObtenerVentasPorCliente(string nombreCliente)
        {
            List<Venta> lista = new List<Venta>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT v.ID, v.Fecha, v.FormatoPago, v.ValorTotal, v.PagoParcial,
                           c.ID as ClienteID, c.Nombre, c.Apellido
                    FROM venta v
                    INNER JOIN cliente c ON v.ClienteID = c.ID
                    WHERE c.Nombre LIKE @Nombre OR c.Apellido LIKE @Nombre
                    ORDER BY v.Fecha DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombreCliente + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta
                        {
                            ID = reader.GetInt32("ID"),
                            Fecha = reader.GetDateTime("Fecha"),
                            FormatoPago = reader.GetString("FormatoPago"),
                            ValorTotal = reader.GetDecimal("ValorTotal"),
                            PagoParcial = reader.GetDecimal("PagoParcial"),
                            Cliente = new Cliente
                            {
                                ID = reader.GetInt32("ClienteID"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido")
                            }
                        };
                        lista.Add(venta);
                    }
                }
            }

            return lista;
        }

        public List<Venta> BuscarVentas(string filtro)
        {
            List<Venta> lista = new List<Venta>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"
            SELECT v.ID, v.Fecha, v.FormatoPago, v.ValorTotal, v.PagoParcial,
                   c.ID as ClienteID, c.Nombre, c.Apellido
            FROM venta v
            INNER JOIN cliente c ON v.ClienteID = c.ID
            WHERE 
                c.Nombre LIKE @filtro
                OR c.Apellido LIKE @filtro
                OR v.FormatoPago LIKE @filtro
                OR DATE_FORMAT(v.Fecha, '%Y-%m-%d') = @fechaExacta";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                // Intenta parsear filtro a fecha para comparar
                DateTime fecha;
                bool esFecha = DateTime.TryParse(filtro, out fecha);
                if (esFecha)
                {
                    cmd.Parameters.AddWithValue("@fechaExacta", fecha.ToString("yyyy-MM-dd"));
                }
                else
                {
                    // Si no es fecha, pasamos un valor que nunca coincida para no filtrar por fecha
                    cmd.Parameters.AddWithValue("@fechaExacta", "0000-00-00");
                }

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta
                        {
                            ID = reader.GetInt32("ID"),
                            Fecha = reader.GetDateTime("Fecha"),
                            FormatoPago = reader.GetString("FormatoPago"),
                            ValorTotal = reader.GetDecimal("ValorTotal"),
                            PagoParcial = reader.GetDecimal("PagoParcial"),
                            Cliente = new Cliente
                            {
                                ID = reader.GetInt32("ClienteID"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido")
                            }
                        };
                        lista.Add(venta);
                    }
                }
            }
            return lista;
        }

        public decimal ObtenerTotalVentas()
        {
            decimal totalVentas = 0;

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT IFNULL(SUM(ValorTotal), 0) FROM venta";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    totalVentas = Convert.ToDecimal(result);
                }
            }

            return totalVentas;
        }


        public decimal ObtenerTotalVentasPorFechas(DateTime desde, DateTime hasta)
        {
            decimal total = 0;
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT IFNULL(SUM(ValorTotal), 0) FROM venta WHERE Fecha BETWEEN @Desde AND @Hasta";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    total = Convert.ToDecimal(result);
            }
            return total;
        }

        public decimal ObtenerTotalCobradoPorFechas(DateTime desde, DateTime hasta)
        {
            decimal total = 0;
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT IFNULL(SUM(PagoParcial), 0) FROM venta WHERE Fecha BETWEEN @Desde AND @Hasta";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    total = Convert.ToDecimal(result);
            }
            return total;
        }
        public decimal ObtenerDeudaClientesPorFechas(DateTime desde, DateTime hasta)
        {
            decimal deuda = 0;

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT IFNULL(SUM(ValorTotal - PagoParcial), 0) FROM venta WHERE Fecha BETWEEN @Desde AND @Hasta";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    deuda = Convert.ToDecimal(result);
            }

            return deuda;
        }




    }
}
