using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFInalTiago.Database
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FinalDbContext>
    {
        public FinalDbContext CreateDbContext(string[] args)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "siscras.db");

            var optionsBuilder = new DbContextOptionsBuilder<FinalDbContext>();
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new FinalDbContext(optionsBuilder.Options);
        }
    }
}
