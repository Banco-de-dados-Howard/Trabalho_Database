using Npgsql;

public class SelectData
{
    private Conn db = new Conn();

    public void selecionar()
    {
        using var conn = db.GetConnection();
        using var cmd = new NpgsqlCommand("SELECT * FROM teste;", conn);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(reader["id"] + " | " + reader["nome"]);
        }
    }
}
