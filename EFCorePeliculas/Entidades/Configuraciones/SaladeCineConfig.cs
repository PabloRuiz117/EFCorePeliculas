using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class SaladeCineConfig : IEntityTypeConfiguration<SalaDeCine>
    {
        public void Configure(EntityTypeBuilder<SalaDeCine> builder)
        {
            builder
                 .Property(x => x.Precio)
                 .HasColumnType("decimal(9,2)");
            builder.Property(x => x.TipoSalaDeCine).HasDefaultValue(TipoSalaDeCine.DosDimensiones);
        }
    }
}
