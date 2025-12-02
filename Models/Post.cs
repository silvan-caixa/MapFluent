namespace MapFluent.Moldes;

public class Post
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Sumario { get; set; }

    public Usuario? Usuario { get; set; }
    public Categoria? Categoria { get; set; }
}