using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationAreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1, circulo2;

            circulo1 = new Circulo(11,11,11);
            circulo2 = new Circulo(222);

            Console.WriteLine("Circulo 1");
            circulo1.Escribir();
            Console.WriteLine("Circulo 2");
            circulo2.Escribir();
            Console.ReadKey();
        }
    }   
}