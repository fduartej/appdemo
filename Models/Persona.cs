using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appdemo.Models
{
    public class Persona
    {
        public string Dni {get; set; }
        public string Nombre {get; set; }

        public string Apellido {get; set; }

        public string Genero {get; set; }

        public DateTime FechaVencimiento {get; set; }
    }
}