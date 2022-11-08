using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder
                .Property(x => x.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.FechaNacimiento)
                .HasColumnType("date");
        }
    }
}
