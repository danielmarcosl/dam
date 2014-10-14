using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationProgramOut
{
    class ProgramOut
    {
        // El valor de la función se coloca en res
        // Se le pasan los parámetros y los almacena
        static void sumarOut(int n1, int n2, out int res)
        {
            res = (n1 + n2);
        }

        static void Main(string[] args)
        {
            int numero1, numero2, suma;

            Console.Write("Introduce numero1: ");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce numero2: ");
            numero2 = Int32.Parse(Console.ReadLine());
            sumarOut(numero1, numero2, out suma);
            Console.Write("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
