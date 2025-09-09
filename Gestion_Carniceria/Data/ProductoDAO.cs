using Gestion_Carniceria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Carniceria.Data
{
    public class ProductoDAO
    {
        public List<Producto> ObtenerTodosLosProductos()
        {
            List<Producto> lista = new List<Producto>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT p.ID, p.Nombre, p.Descripcion, p.Peso, p.Cantidad, p.Precio, p.PrecioCosto, p.Tipo,
                c.ID AS CategoriaID, c.Nombre AS CategoriaNombre
         FROM producto p
         INNER JOIN categoria c ON p.CategoriaID = c.ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        ID = Convert.ToInt32(reader["CategoriaID"]),
                        Nombre = reader["CategoriaNombre"].ToString()
                    };

                    Producto p = new Producto
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Peso = Convert.ToDecimal(reader["Peso"]),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        PrecioCosto = reader["PrecioCosto"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["PrecioCosto"]),
                        Categoria = categoria,
                        Tipo = Enum.TryParse<TipoProducto>(reader["Tipo"].ToString(), out var tipo) ? tipo : TipoProducto.Unidad
                    };

                    lista.Add(p);
                }

                reader.Close();
            }

            return lista;
        }

        public bool CrearProducto(Producto p)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"INSERT INTO producto (Nombre, Descripcion, Peso, Cantidad, Precio, PrecioCosto, CategoriaID, Tipo)
                VALUES (@Nombre, @Descripcion, @Peso, @Cantidad, @Precio, @PrecioCosto, @CategoriaID, @Tipo)";



                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Peso", p.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@CategoriaID", p.Categoria.ID);
                cmd.Parameters.AddWithValue("@Tipo", p.Tipo.ToString());
                cmd.Parameters.AddWithValue("@PrecioCosto", p.PrecioCosto);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool ModificarProducto(Producto p)
        {
            try
            {
                using (MySqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = @"UPDATE producto
 SET Nombre = @Nombre, Descripcion = @Descripcion, Peso = @Peso,
     Cantidad = @Cantidad, Precio = @Precio, PrecioCosto = @PrecioCosto, CategoriaID = @CategoriaID, Tipo = @Tipo
 WHERE ID = @ID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", p.ID);
                    cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@Peso", p.Peso);
                    cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", p.Precio);
                    cmd.Parameters.AddWithValue("@CategoriaID", p.Categoria.ID);
                    cmd.Parameters.AddWithValue("@Tipo", p.Tipo.ToString());
                    cmd.Parameters.AddWithValue("@PrecioCosto", p.PrecioCosto);
                    

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
                return false;
            }
        }

        public void ActualizarCategoria(int idProducto, int idCategoria)
        {
            using (var conn = ConexionBD.ObtenerConexion())
            {
                string query = "UPDATE producto SET idcategoria = @idCategoria WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                cmd.ExecuteNonQuery();
            }
        }


        public bool EliminarProducto(int id)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM producto WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            List<Producto> lista = new List<Producto>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT p.ID, p.Nombre, p.Descripcion, p.Peso, p.Cantidad, p.Precio, p.Tipo,
                                c.ID AS CategoriaID, c.Nombre AS CategoriaNombre
                         FROM producto p
                         INNER JOIN categoria c ON p.CategoriaID = c.ID
                         WHERE p.Nombre LIKE @Nombre";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        ID = Convert.ToInt32(reader["CategoriaID"]),
                        Nombre = reader["CategoriaNombre"].ToString()
                    };

                    Producto p = new Producto
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Peso = Convert.ToDecimal(reader["Peso"]),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Categoria = categoria,
                        Tipo = Enum.TryParse<TipoProducto>(reader["Tipo"].ToString(), out var tipo) ? tipo : TipoProducto.Unidad
                    };

                    lista.Add(p);
                }

                reader.Close();
            }

            return lista;
        }

        public bool ActualizarStock(Producto p)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"UPDATE producto
                         SET Peso = @Peso,
                             Cantidad = @Cantidad
                         WHERE ID = @ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", p.ID);
                cmd.Parameters.AddWithValue("@Peso", p.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool AumentarStock(Producto p, decimal cantidadAumentar)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                // Validación simple
                if (cantidadAumentar <= 0)
                    throw new ArgumentException("La cantidad a aumentar debe ser mayor a cero.");

                // Actualizar valores en memoria según tipo
                if (p.Tipo == TipoProducto.Unidad)
                {
                    // Convertir cantidad decimal a int, redondeando hacia abajo para evitar errores
                    int cantidadEntera = (int)Math.Floor(cantidadAumentar);
                    p.Cantidad += cantidadEntera;
                }
                else
                {
                    p.Peso += cantidadAumentar;
                }

                string query = @"UPDATE producto
                         SET Peso = @Peso,
                             Cantidad = @Cantidad
                         WHERE ID = @ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", p.ID);
                cmd.Parameters.AddWithValue("@Peso", p.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }


    }
}
