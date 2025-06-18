using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class ClienteDAO
{
    public List<Cliente> ObtenerTodosLosClientes()
    {
        List<Cliente> lista = new List<Cliente>();

        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = "SELECT * FROM cliente";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Cliente c = new Cliente
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    DNI = reader["DNI"].ToString()
                };

                c.AgregarDeuda(Convert.ToDecimal(reader["Deuda"]));
                lista.Add(c);
            }

            reader.Close();
        }

        return lista;
    }

    public bool CrearCliente(Cliente nuevoCliente)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = "INSERT INTO cliente (Nombre, Apellido, Telefono, Correo, DNI, Deuda) " +
                           "VALUES (@Nombre, @Apellido, @Telefono, @Correo, @DNI, @Deuda)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", nuevoCliente.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono);
            cmd.Parameters.AddWithValue("@Correo", nuevoCliente.Correo);
            cmd.Parameters.AddWithValue("@DNI", nuevoCliente.DNI);
            cmd.Parameters.AddWithValue("@Deuda", nuevoCliente.Deuda); // ← esta línea está corregida

            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }
}