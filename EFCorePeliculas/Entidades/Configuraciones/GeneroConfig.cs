using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("TablaGeneros");

            builder.HasKey(x => x.Identificador);

            builder
                .Property(x => x.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NombreGenero")
                .IsRequired();
        }
    }
}
