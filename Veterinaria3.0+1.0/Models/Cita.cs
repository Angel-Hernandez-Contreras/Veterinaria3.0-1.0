using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria3._0_1._0.Models
{
    class Cita
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string NombreVeterinario { get; set; }
    }
}
