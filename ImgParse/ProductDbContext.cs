using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgParse
{
    internal class ProductDbContext : DbContext
    {
        public DbSet<Cpu> Processors { get; set; }
       // public DbSet<GraphicsCard> GraphicsCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;username=postgres;database=BuildGeniusTest2;password=131313");
        }
    }
}
