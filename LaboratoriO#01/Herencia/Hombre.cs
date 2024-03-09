using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoriO_01.Herencia
{
    public class Hombre :Humano, IHumano
    {
        public string genero { get; set; };
        public void Comer(); { }
        public void Dormir(); { }
        public void Reproduccion();{ }

    }
}
