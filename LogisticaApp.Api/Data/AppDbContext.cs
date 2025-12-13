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
            // 🔹 Mapeamento de herança (Table Per Type - TPT)
            modelBuilder.Entity<Carro>().ToTable("Carros");
            modelBuilder.Entity<Caminhao>().ToTable("Caminhoes");
            modelBuilder.Entity<Moto>().ToTable("Motos");

            base.OnModelCreating(modelBuilder);
        }
    }
}
