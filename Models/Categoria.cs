using System.Collections.Generic;
namespace MapFluent.Moldes;

public class Categoria
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public List<Post> Posts { get; set; } = new();

}