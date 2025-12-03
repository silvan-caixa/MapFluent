namespace MapFluent.Moldes;

public class Post
{
    public int Id { get; set; }

    public string? Titulo { get; set; }
    public string? Sumario { get; set; }
    public int AuthorId { get; set; }
    public Usuario? Usuario { get; set; }
    public int CategoriaId { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public DateTime DataCriacao { get; set; }
    public Categoria? Categoria { get; set; }
    public List<Role> Roles { get; set; } = new();
}