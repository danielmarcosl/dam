using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class ProgramSwitch
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            switch (nombre)
            {
                case "Pepe":
                    Console.WriteLine("Hola Pepe");
                    break;
                case "Paco":
                    Console.WriteLine("Hola Paco");
                    break;
                default:
                    Console.WriteLine("Usuario desconocido");
                    break;
            }
            Console.ReadKey();
        }
    }
}