using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class ProgramInOut
    {
        static int sumaRef(ref int n1, int n2)
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
            // n1 guarda una referencia a numero1
            // n2 guarda una referencia a numero2
            suma = sumaRef(ref numero1, numero2);
            Console.Write("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
