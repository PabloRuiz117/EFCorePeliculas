using EFCorePeliculas.Entidades;
using EFCorePeliculas.Entidades.Configuraciones;
using EFCorePeliculas.Entidades.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCorePeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CinesOfertas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<SalaDeCine> SalasDeCines { get; set; }
        public DbSet<PeliculaActor> PeliculaActor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new GeneroConfig());
            //builder.ApplyConfiguration(new ActorConfig());
            //builder.ApplyConfiguration(new CineConfig());
            //builder.ApplyConfiguration(new SaladeCineConfig());
            //builder.ApplyConfiguration(new PeliculaConfig());

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<CineOferta>()
                .Property(x => x.PorcentajeDescuento)
                .HasColumnType("decimal(5,2)");

            builder.Entity<CineOferta>()
                .Property(x => x.FechaInicio)
                .HasColumnType("date");

            builder.Entity<CineOferta>()
                .Property(x => x.FechaFin)
                .HasColumnType("date");

            builder.Entity<PeliculaActor>().HasKey(pa => new { pa.PeliculaId, pa.ActorId });
            builder.Entity<PeliculaActor>().Property(x => x.Personaje).HasMaxLength(150);

            SeedingModuloConsulta.Seed(builder);
        }
    }
}
