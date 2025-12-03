using MapFluent.Data.Mappings;
using MapFluent.Moldes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MapFluent.Data;

public class MapFluentDataContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Post> Posts { get; set; }

    public static string ConnectionString = "Server=develope.database.windows.net;Database=develope;User ID=dev;Password=Silvan@12345";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoriaMap());
        modelBuilder.ApplyConfiguration(new RoleMap());
        modelBuilder.ApplyConfiguration(new CategoriaMap());
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