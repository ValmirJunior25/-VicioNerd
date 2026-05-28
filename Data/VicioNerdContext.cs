using Microsoft.EntityFrameworkCore;
using VicioNerd.Models;

namespace VicioNerd.Data
{
    internal class VicioNerdContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set; }
        public DbSet<Jogo> Jogos {get; set; }
        public DbSet<Prateleira> Prateleiras {get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var caminho = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "Data", "vicionerd.db");

            options.UseSqlite($"Data Source={caminho}");
        }
    }
}