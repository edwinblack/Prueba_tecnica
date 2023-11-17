using Microsoft.EntityFrameworkCore;
using Prueba_tecnica.Models.Domain;

namespace Prueba_tecnica.Data
{
    public class PruebaTecnicaDbContext : DbContext
    {
        public PruebaTecnicaDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<EncuestasEncabezado> EncuestasEncabezados { get; set; }
        public DbSet<EncuestaCampos> EncuestaCampos { get; set; }
    }
}
