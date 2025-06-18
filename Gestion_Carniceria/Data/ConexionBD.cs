using MySql.Data.MySqlClient;

public static class ConexionBD
{
    private static string connectionString = "server=localhost;database=mibasededatos;uid=root;pwd=admin;";


    public static MySqlConnection ObtenerConexion()
    {
        MySqlConnection conexion = new MySqlConnection(connectionString);
        conexion.Open();
        return conexion;
    }
}
