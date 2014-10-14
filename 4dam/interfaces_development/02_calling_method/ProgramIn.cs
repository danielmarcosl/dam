using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ProgramIn
    {
        static int sumar(int n1, int n2)
        {
            int v = n1 + n2;
            n1 = 0;
            return v;
        }

        static void Main(string[] args)
        {
            int numero1, numero2, suma;

            Console.Write("Introduce numero1: ");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce numero2: ");
            numero2 = Int32.Parse(Console.ReadLine());
            suma = sumar( numero1, numero2);
            Console.Write("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
