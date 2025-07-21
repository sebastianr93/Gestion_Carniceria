using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class ProveedorDAO
{
    public List<Proveedor> ObtenerTodosLosProveedores()
    {
        List<Proveedor> lista = new List<Proveedor>();

        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = "SELECT * FROM proveedor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Proveedor p = new Proveedor
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nombre = reader["Nombre"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString()
                };

                p.AgregarAlaCuentaCorriente(Convert.ToDecimal(reader["CuentaCorriente"]));
                lista.Add(p);
            }

            reader.Close();
        }

        return lista;
    }

    public bool CrearProveedor(Proveedor nuevoProveedor)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = @"INSERT INTO proveedor 
                            (Nombre, Telefono, Correo, Descripcion, CuentaCorriente)
                             VALUES 
                            (@Nombre, @Telefono, @Correo, @Descripcion, @CuentaCorriente)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Nombre", nuevoProveedor.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", nuevoProveedor.Telefono);
            cmd.Parameters.AddWithValue("@Correo", nuevoProveedor.Correo);
            cmd.Parameters.AddWithValue("@Descripcion", nuevoProveedor.Descripcion);
            cmd.Parameters.AddWithValue("@CuentaCorriente", nuevoProveedor.CuentaCorriente);

            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }

    public List<Proveedor> BuscarProveedores(string termino)
    {
        List<Proveedor> lista = new List<Proveedor>();

        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = @"SELECT * FROM proveedor 
                             WHERE Nombre LIKE @Termino OR 
                                   Telefono LIKE @Termino OR 
                                   Correo LIKE @Termino OR 
                                   Descripcion LIKE @Termino";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Termino", "%" + termino + "%");

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Proveedor p = new Proveedor
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nombre = reader["Nombre"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Descripcion = reader["Descripcion"].ToString()
                };

                p.AgregarAlaCuentaCorriente(Convert.ToDecimal(reader["CuentaCorriente"]));
                lista.Add(p);
            }

            reader.Close();
        }

        return lista;
    }

    public bool ActualizarProveedor(Proveedor proveedor)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = @"UPDATE proveedor SET 
                                Nombre = @Nombre, 
                                Telefono = @Telefono, 
                                Correo = @Correo, 
                                Descripcion = @Descripcion, 
                                CuentaCorriente = @CuentaCorriente
                             WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
            cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
            cmd.Parameters.AddWithValue("@Descripcion", proveedor.Descripcion);
            cmd.Parameters.AddWithValue("@CuentaCorriente", proveedor.CuentaCorriente);
            cmd.Parameters.AddWithValue("@ID", proveedor.ID);

            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }

    public decimal ObtenerDeudaTotalProveedores()
    {
        decimal totalDeuda = 0;

        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = "SELECT IFNULL(SUM(CuentaCorriente), 0) FROM proveedor";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                totalDeuda = Convert.ToDecimal(result);
            }
        }

        return totalDeuda;
    }

    public bool EliminarProveedor(int id)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = "DELETE FROM proveedor WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }

    public bool ActualizarCuentaCorriente(Proveedor proveedor)
    {
        using (MySqlConnection conn = ConexionBD.ObtenerConexion())
        {
            string query = @"UPDATE proveedor
                         SET CuentaCorriente = @CuentaCorriente
                         WHERE ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CuentaCorriente", proveedor.CuentaCorriente);
            cmd.Parameters.AddWithValue("@ID", proveedor.ID);

            int filas = cmd.ExecuteNonQuery();
            return filas > 0;
        }
    }

}
