using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria3._0_1._0.Models
{
    class Historial
    {
        public int Id { get; set; } 
        public DateTime Fecha { get; set; }
        public string ProductoCantidadPrecio { get; set; }
        public int Total { get; set; }
    }
}
