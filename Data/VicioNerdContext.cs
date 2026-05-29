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
            
            // Caminho absoluto para a pasta
            var pastaBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            // Verifica e cria usando o caminho
            if (!Directory.Exists(pastaBanco))
            {
                Directory.CreateDirectory(pastaBanco);
            }

            // Banco dentro dessa mesma pasta
            var caminho = Path.Combine(pastaBanco, "vicionerd.db");

            options.UseSqlite($"Data Source={caminho}");
        }

    }
}