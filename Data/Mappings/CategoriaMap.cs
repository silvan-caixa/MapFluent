using MapFluent.Moldes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MapFluent.Data.Mappings;

public class CategoriaMap : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        //table
        builder.ToTable("Categoria");

        //chave
        builder.HasKey("Id");

        //Identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        //Propriedade
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasColumnName("Nome")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        builder.Property(x => x.Descricao)
            .IsRequired()
            .HasColumnName("Descricao")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);
        //Indices
        builder.HasIndex(x => x.Nome, "IX_Categoria_Nome")
            .IsUnique();




    }
}