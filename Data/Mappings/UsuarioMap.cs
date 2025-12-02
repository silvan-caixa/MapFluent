using MapFluent.Moldes;
using Microsoft.EntityFrameworkCore;

namespace MapFluent.Data.Mappings;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
    {
        //Chave
        builder.HasKey(x => x.Id);
        //Identity
        //Propriedade
        //Index
    }
}