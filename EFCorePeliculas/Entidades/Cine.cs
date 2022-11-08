using NetTopologySuite.Geometries;

namespace EFCorePeliculas.Entidades
{
    public class Cine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Point Ubicacion { get; set; } //Permite colocar la longitud y latitud a un cine
        public CineOferta CineOferta { get; set; }
        public HashSet<SalaDeCine> SalasDeCines { get; set; }
    }
}
