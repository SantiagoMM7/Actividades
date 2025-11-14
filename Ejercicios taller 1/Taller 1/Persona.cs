using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1
{
    internal class Personas
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; } 
            public string Telefono { get; set; }

            
            public Persona(string nombre, int edad, string genero, string telefono)
            {
                Nombre = nombre;
                Edad = edad;
                Genero = genero;
                Telefono = telefono;
            }

           
            public void EditarInformacion()
            {
                Console.WriteLine("Editar información de la persona:");

                Console.Write("Nuevo nombre: ");
                Nombre = Console.ReadLine();

                Console.Write("Nueva edad: ");
                Edad = int.Parse(Console.ReadLine());

                Console.Write("Nuevo género (F/M): ");
                Genero = Console.ReadLine();

                Console.Write("Nuevo teléfono: ");
                Telefono = Console.ReadLine();
            }

            
            public void ImprimirDetalles()
            {
                Console.WriteLine("\n--- Detalles de la Persona ---");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Edad: {Edad} años");
                Console.WriteLine($"Género: {Genero}");
                Console.WriteLine($"Teléfono: {Telefono}");
            }

            public void CalcularEdadEnDias()
            {
                int edadEnDias = Edad * 365;
                Console.WriteLine($"\nLa edad en días es aproximadamente: {edadEnDias} días");
            }
        }
    }
}

