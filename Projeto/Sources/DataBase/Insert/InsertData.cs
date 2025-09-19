using System.Data.Common;
using Npgsql;

public class InsertData
{
    Conn db = new Conn();

    public void inserir(String nome, int valor)
    {
        using var conn = db.GetConnection();
        using var cmd = new NpgsqlCommand($"INSERT INTO TESTE VALUES({valor},'{nome}')", conn);

        cmd.ExecuteScalar();
    }
}