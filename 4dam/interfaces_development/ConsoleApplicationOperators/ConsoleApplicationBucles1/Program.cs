using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationBucles1
{
    class Bucles1
    {
        static void Main(string[] args)
        {
            //int numero = 1, cantidad;
            //string linea;
            //
            //cantidad = 0;
            //while (numero != 0)
            //{
            //    Console.Write("Introduce numero: ");
            //    linea = Console.ReadLine();
            //    numero = Int32.Parse(linea);
            //    cantidad++;
            //}
            //Console.WriteLine("Se han leido " + cantidad + " números");
            //Console.ReadKey();

            //int numero, cantidad;
            //string linea;
            //
            //Console.Write("Introduce un número: ");
            //linea = Console.ReadLine();
            //numero = Int32(linea);
            //cantidad = 1;
            //while (numero != 0)
            //{
            //    Console.Write("Introduce numero: ");
            //    linea = Console.ReadLine();
            //    numero = Int32.Parse(linea);
            //    cantidad++;
            //}
            //Console.WriteLine("Se han leido " + cantidad + " números");
            //Console.ReadKey();

            int numero, cantidad;
            string linea;

            cantidad = 0;

            do
            {
                Console.Write("Introduce un número: ");
                linea = Console.ReadLine();
                numero = Int32.Parse(linea);
                cantidad++;
            } while (numero != 0);
            Console.WriteLine("Se han leido " + cantidad + " números");
            Console.ReadKey();
        }
    }
}
