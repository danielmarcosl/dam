using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationMayor2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for compare two numbers and tell which is the higher
            int numero1, numero2;
            string linea;
            Console.WriteLine("Introduce el numero 1: ");
            // It's diferent to the scanf of C, here it has to read a line and convert it to a number
            // For read a line, we have to declaro a string
            linea = Console.ReadLine();
            // For convert the string to a number, we use Int32
            numero1 = Int32.Parse(linea);
            // Repeat the process for the number2
            Console.WriteLine("Introduce el numero 2: ");
            linea = Console.ReadLine();
            numero2 = Int32.Parse(linea);
            // Use a if for know who is the higher number
            if (numero1 > numero2)
                Console.WriteLine("El mayor es " + numero1);
            else
                Console.WriteLine("El mayor es " + numero2);
            Console.ReadKey();
        }
    }
}
