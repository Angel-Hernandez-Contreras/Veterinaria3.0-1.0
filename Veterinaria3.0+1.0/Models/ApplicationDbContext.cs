using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria3._0_1._0.Models
{
    class ApplicationDbContext : DbContext
    {
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseNpgsql("Host=localhost; Database=Veterinaria; Username=postgres; password=Roman55;").EnableSensitiveDataLogging(true);
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog= Veterinaria; Integrated Security=true;");
        }

        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Mercancia> Mercancia { get; set; }
        public DbSet<Historial> Historial { get; set; }
    }
}
