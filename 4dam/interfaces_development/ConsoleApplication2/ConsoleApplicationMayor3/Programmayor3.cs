using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationMayor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            string linea;

            Console.WriteLine("Introduce el numero 1: ");
            linea = Console.ReadLine();
            numero1 = Int32.Parse(linea);

            Console.WriteLine("Introduce el numero 2: ");
            linea = Console.ReadLine();
            numero2 = Int32.Parse(linea);

            Console.WriteLine("Introduce el numero 3: ");
            linea = Console.ReadLine();
            numero3 = Int32.Parse(linea);

            if (numero1 >= numero2 && numero1 >= numero3)
                Console.WriteLine("El mayor es el primero que es " + numero1);
            else
                if (numero2 >= numero1 && numero2 >= numero3)
                    Console.WriteLine("El mayor es el segundo que es " + numero2);
                else
                    Console.WriteLine("El mayor es el tercero que es " + numero3);
            Console.ReadKey();
        }
    }
}
