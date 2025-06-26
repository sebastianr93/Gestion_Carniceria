using Gestion_Carniceria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Carniceria.Data
{

    public class CategoriaDAO
    {
        public List<Categoria> ObtenerTodasLasCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM categoria";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categoria c = new Categoria
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["Nombre"].ToString()
                    };

                    lista.Add(c);
                }

                reader.Close();
            }

            return lista;
        }

        public bool CrearCategoria(Categoria categoria)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO categoria (Nombre) VALUES (@Nombre)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool ModificarCategoria(Categoria categoria)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "UPDATE categoria SET Nombre = @Nombre WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@ID", categoria.ID);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool EliminarCategoria(int id)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM categoria WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
        public Categoria ObtenerCategoriaPorNombre(string nombre)
        {
            Categoria categoria = null;

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Nombre, Tipo FROM categoria WHERE Nombre = @nombre";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    categoria = new Categoria
                    {
                        Nombre = reader["Nombre"].ToString(),
                    };
                }
            }

            return categoria;
        }

    }




}
