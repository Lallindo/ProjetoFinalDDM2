using Microsoft.EntityFrameworkCore;
using ProjetoFInalTiago.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFInalTiago.Database
{
    public class FinalDbContext : DbContext
    {
        public FinalDbContext(DbContextOptions<FinalDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clima> Climas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasMany(u => u.Buscas)
                    .WithOne(b => b.Usuario)
                    .IsRequired();
            });
        }

        public static string GetSqLiteConnection()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "siscras.db");
            return dbPath;
        }
    }
}
