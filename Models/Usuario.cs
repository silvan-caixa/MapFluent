namespace MapFluent.Moldes;

public class Usuario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }

    public List<Post> Posts { get; set; } = new();

}