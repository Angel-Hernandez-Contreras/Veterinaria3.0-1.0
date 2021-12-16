using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria3._0_1._0.Models
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Telefono { get; set; }
        //declaracion de la relacion cliente/mascota
        public List<Mascota> Mascota { get; set; }
    }
}
