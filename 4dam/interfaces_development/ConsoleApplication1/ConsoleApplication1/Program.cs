using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 288;
            StreamWriter fichero = new StreamWriter("fichero");

            fichero.WriteLine("Hola");
            fichero.WriteLine("Hola");
            fichero.Close();

            Console.WriteLine("Hola ");
            Console.WriteLine("El numero es " + numero + "n Euros");
            Console.ReadKey();
        }
    }
}
