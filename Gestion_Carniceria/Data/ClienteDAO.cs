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

    public List<Cliente> BuscarClientes(string termino)
    {
        List<Cliente> lista = new List<Cliente>();

        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = @"SELECT * FROM cliente 
                         WHERE Nombre LIKE @Termino OR 
                               Apellido LIKE @Termino OR 
                               Telefono LIKE @Termino OR 
                               Correo LIKE @Termino OR 
                               DNI LIKE @Termino";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Termino", "%" + termino + "%");

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

    public bool ActualizarCliente(Cliente cliente)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = @"UPDATE cliente SET 
                            Nombre = @Nombre, 
                            Apellido = @Apellido, 
                            Telefono = @Telefono, 
                            Correo = @Correo, 
                            DNI = @DNI
                         WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@DNI", cliente.DNI);
            cmd.Parameters.AddWithValue("@ID", cliente.ID);

            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }

    public bool EliminarCliente(int id)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = "DELETE FROM cliente WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }



}