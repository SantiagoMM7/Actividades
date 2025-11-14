using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            mascota mascota1 = new mascota();
            mascota1.SetNombre("Firulais");
            mascota1.SetEdad(4);
            mascota1.SetTipo("Perro");
            mascota1.SetPeso(12.5);

            mascota mascota2 = new mascota();
            mascota2.SetNombre("Michi");
            mascota2.SetEdad(3);
            mascota2.SetTipo("Gato");
            mascota2.SetPeso(4.2);

            mascota1.MostrarInformacion();
            Console.WriteLine($"Edad en años humanos: {mascota1.EdadEnAniosHumanos()} años\n");

            mascota2.MostrarInformacion();
            Console.WriteLine($"Edad en años humanos: {mascota2.EdadEnAniosHumanos()} años\n");
        
    }
    }
}
