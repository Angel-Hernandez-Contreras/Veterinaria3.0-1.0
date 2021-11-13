using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria3._0_1._0.Models
{
    class Mascota
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string NombreMascota { get; set; }
        public string Especie { get; set; } 
        public string ColorPelo { get; set; }
        public string Sexo { get; set; }
    }
}
