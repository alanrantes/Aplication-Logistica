using LogisticaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticaApp.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Caminhao> Caminhoes { get; set; }
        public DbSet<Moto> Motos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
                .HasDiscriminator<string>("TipoVeiculo")
                .HasValue<Carro>("Carro")
                .HasValue<Caminhao>("Caminhao")
                .HasValue<Moto>("Moto");
        }
    }
}
