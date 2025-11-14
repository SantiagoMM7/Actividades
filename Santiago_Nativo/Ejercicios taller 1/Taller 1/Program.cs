using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Taller_1.Personas;

namespace Taller_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1
            //Console.Write("Ingrese el monto del préstamo: ");
            //double montoPrestamo = Convert.ToDouble(Console.ReadLine());


            //double tasaInteresAnual = 0.05; 
            //int plazoAnios = 5;


            //double interesAnual = montoPrestamo * tasaInteresAnual;
            //double interesMensual = interesAnual / 12;
            //double interesTrimestre = interesMensual * 3;
            //double totalIntereses = interesAnual * plazoAnios;
            //double totalPagado = montoPrestamo + totalIntereses;


            //Console.WriteLine("\n--- Detalle del préstamo ---");
            //Console.WriteLine($"Intereses pagados en un año: ${interesAnual:F2}");
            //Console.WriteLine($"Intereses pagados en el tercer trimestre: ${interesTrimestre:F2}");
            //Console.WriteLine($"Intereses pagados en el primer mes: ${interesMensual:F2}");
            //Console.WriteLine($"Total pagado al final del préstamo: ${totalPagado:F2}");

            //ejercicio 2
            //Console.Write("Ingrese el salario del empleado: ");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Ingrese el valor de ahorro mensual programado: ");
            //double ahorroMensual = Convert.ToDouble(Console.ReadLine());


            //double deduccionSalud = salario * 0.125;     
            //double deduccionPension = salario * 0.16;    


            //double totalDeducciones = deduccionSalud + deduccionPension + ahorroMensual;
            //double totalRecibir = salario - totalDeducciones;


            //Console.WriteLine("\n--- COLILLA DE PAGO ---");
            //Console.WriteLine($"Salario del Empleado: ${salario:F2}");
            //Console.WriteLine($"Ahorro Mensual Programado: ${ahorroMensual:F2}");
            //Console.WriteLine($"Deducción por Salud (12.5%): ${deduccionSalud:F2}");
            //Console.WriteLine($"Deducción por Pensión (16%): ${deduccionPension:F2}");
            //Console.WriteLine($"Total a Recibir: ${totalRecibir:F2}");

            //Ejercicio 3

            Console.WriteLine("Ingrese los datos de la persona:");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Género (F/M): ");
            string genero = Console.ReadLine();

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Persona persona = new Persona(nombre, edad, genero, telefono);

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Imprimir detalles de la persona");
                Console.WriteLine("2. Calcular edad en días");
                Console.WriteLine("3. Editar información");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        persona.ImprimirDetalles();
                        break;
                    case "2":
                        persona.CalcularEdadEnDias();
                        break;
                    case "3":
                        persona.EditarInformacion();
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
