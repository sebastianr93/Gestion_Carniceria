using Gestion_Carniceria.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Carniceria.Data
{
    public class MedioDePagoDAO
    {
        public List<MedioDePago> ObtenerTodos()
        {
            List<MedioDePago> lista = new List<MedioDePago>();

            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM mediopago";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MedioDePago m = new MedioDePago
                    {
                        ID = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        PorcentajeAjuste = Convert.ToInt32(reader["porcentaje_ajuste"])
                    };

                    lista.Add(m);
                }

                reader.Close();
            }

            return lista;
        }

        public bool Crear(MedioDePago medio)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"INSERT INTO mediopago (nombre, porcentaje_ajuste)
                                 VALUES (@Nombre, @Ajuste)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", medio.Nombre);
                cmd.Parameters.AddWithValue("@Ajuste", medio.PorcentajeAjuste);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Actualizar(MedioDePago medio)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"UPDATE mediopago 
                                 SET nombre = @Nombre, 
                                     porcentaje_ajuste = @Ajuste 
                                 WHERE id = @ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", medio.Nombre);
                cmd.Parameters.AddWithValue("@Ajuste", medio.PorcentajeAjuste);
                cmd.Parameters.AddWithValue("@ID", medio.ID);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (MySqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM mediopago WHERE id = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
}

