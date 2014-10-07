using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationFor1
{
    class ProgramFor1
    {
        static void Main(string[] args)
        {
            int numero, contador;
            string linea;

            Console.Write("Introduce un número: ");
            linea = Console.ReadLine();
            numero = Int32.Parse(linea);

            for (contador = 1; contador <= numero; contador++)
            {
                Console.Write(contador + " ");
            }
            Console.ReadKey();
        }
    }
}
