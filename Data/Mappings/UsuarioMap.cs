using MapFluent.Moldes;
using Microsoft.EntityFrameworkCore;

namespace MapFluent.Data.Mappings;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
    {
        //Table
        builder.ToTable("USUARIO");
        //Chave
        builder.HasKey(x => x.Id);
        //Identity
        builder.Property(x => x.Id)
            .HasColumnName("ID")
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        //Propriedade
        builder.Property(x => x.Cpf)
            .HasColumnName("CPF")
            .HasColumnType("Varchar")
            .HasMaxLength(15)
            .IsRequired();
        //Index
        builder.HasIndex(x => x.Cpf, "IX_USUARIO_CPF")
            .IsUnique();

    }
}