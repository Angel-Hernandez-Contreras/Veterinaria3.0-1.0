using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria3._0_1._0.Models
{
    class ApplicationDbContext: DbContext
    {

        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Mercancia> Mercancia { get; set; }
    }
}
