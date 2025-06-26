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
                string query = @"SELECT p.ID, p.Nombre, p.Descripcion, p.Peso, p.Cantidad, p.Precio,
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
                        Categoria = categoria
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
                string query = @"INSERT INTO producto (Nombre, Descripcion, Peso, Cantidad, Precio, CategoriaID)
                             VALUES (@Nombre, @Descripcion, @Peso, @Cantidad, @Precio, @CategoriaID)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Peso", p.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@CategoriaID", p.Categoria.ID);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool ModificarProducto(Producto p)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"UPDATE producto
                             SET Nombre = @Nombre, Descripcion = @Descripcion, Peso = @Peso,
                                 Cantidad = @Cantidad, Precio = @Precio, CategoriaID = @CategoriaID
                             WHERE ID = @ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", p.ID);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Peso", p.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@CategoriaID", p.Categoria.ID);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
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
    }


}
