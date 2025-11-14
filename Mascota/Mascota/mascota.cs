using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    internal class mascota
    {
        private string nombre;
        private int edad;
        private string tipo;
        private double peso;

        public void SetNombre(string nombre) => this.nombre = nombre;
        public void SetEdad(int edad) => this.edad = edad;
        public void SetTipo(string tipo) => this.tipo = tipo.ToLower(); 
        public void SetPeso(double peso) => this.peso = peso;

        
        public string GetNombre() => nombre;
        public int GetEdad() => edad;
        public string GetTipo() => tipo;
        public double GetPeso() => peso;

        
        public void MostrarInformacion()
        {
            Console.WriteLine("----- Información de la Mascota -----");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Peso: {peso} kg");
        }

        
        public int EdadEnAniosHumanos()
        {
            if (tipo == "perro") return edad * 7;
            else if (tipo == "gato") return edad * 6;
            else return edad;
        }
    }
}
