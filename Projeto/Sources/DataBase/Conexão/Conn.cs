using Npgsql;

public class Conn
{
    protected readonly string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres";

    public NpgsqlConnection GetConnection()
    {
        var conn = new NpgsqlConnection(_connectionString);
        conn.Open();
        return conn;
    }
}
