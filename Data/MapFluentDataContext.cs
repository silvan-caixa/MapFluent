using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MapFluent.Data;

public class MapFluentDataContext : DbContext
{
    public static string ConnectionString = "Server=develope.database.windows.net;Database=develope;User ID=dev;Password=Silvan@12345";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    //Testar conexao
    public static void TestConexao()
    {
        using var conexao = new SqlConnection(ConnectionString);
        try
        {
            conexao.Open();
            System.Console.WriteLine("Conexao aberta com sucesso!");
        }
        catch (SqlException ex)
        {

            System.Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
        }
    }
}