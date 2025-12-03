using MapFluent.Moldes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MapFluent.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        //Table
        builder.ToTable("POST");
        //Key
        builder.HasKey("Id");
        //Identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        //Propriedade
        builder.Property(x => x.Titulo)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(80)
            .HasColumnName("Titulo");
        builder.Property(x => x.Sumario)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("Sumario")
            .HasMaxLength(80);

        builder.Property(x => x.AuthorId);
        builder.Property(x => x.CategoriaId);
        builder.Property(x => x.DataAtualizacao)
            .HasColumnName("DataAtualizacao")
            .HasColumnType("SAMLLDATETIME")
            .HasDefaultValueSql("GETDATE()"); // Data gerado pelo banco
                                              //.HasDefaultValue(DateTime.Now.ToUniversalTime()); // Data gerada no codigo



        builder.Property(x => x.DataCriacao);

        //Index
        builder.HasIndex(x => x.Titulo)
            .IsUnique();

        //Relacionamento Usuario
        builder.HasOne(x => x.Usuario)
        .WithMany(x => x.Posts)
        .HasConstraintName("FK_POST_USUARIO")
        .OnDelete(DeleteBehavior.Cascade);

        // Relacionamento Categoria
        builder.HasOne(x => x.Categoria)
        .WithMany(x => x.Posts)
        .HasConstraintName("FK_POST_CATEGORIA")
        .OnDelete(DeleteBehavior.Cascade);

    }
}