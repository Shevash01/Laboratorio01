using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoriO_01.Poliformismo
{
    public class Docente2 : Empleado, IEmpleado
    {
        public string MateriaD2 { get; set; }
        public void PagoSalario(){  Console.WriteLine("Pagar a Docente2 (Docente)"); }
        public void AgregarDocente() { Console.WriteLine("Agregar a Docente2 (Docente)"); }

        public void EliminarDocente() { Console.WriteLine("Eliminar a Docente2 (Docente)"); }

    }
}
