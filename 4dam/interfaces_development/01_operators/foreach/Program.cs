using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationForeach1
{
    class ProgramForeach1
    {
        static void Main(string[] args)
        {
            int[] tabla = { 2, 4, 6, 8, 10, 12 };
            int valor;

            // Versión 1. Recorrer la tabla con for
            for (int i = 0; i < 6; i++)
            {
                valor = tabla[i];
                Console.Write(valor + " ");
            }
            Console.ReadKey();

            // Versión 2. Recorrer la tabla con foreach
            foreach(int valor2 in tabla)
            {
                Console.Write(valor2 + " ");
            }
            Console.ReadKey();
        }
    }
}
