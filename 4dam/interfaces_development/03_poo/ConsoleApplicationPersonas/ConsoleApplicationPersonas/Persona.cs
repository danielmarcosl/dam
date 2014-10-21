using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPersonas
{
    class ProgramEdadPersona
    {
        static void Main(string[] args)
        {
            int diaN, mesN, anioN,
                diaA, mesA, anioA,
                edad;
            string linea;

            // Vesion 2. Leyendo fechas con /
            Console.Write("Introduce fecha nacimiento (separado por /): ");
            linea = Console.ReadLine();
            string[] campos = linea.Split(new Char[] { '/', '-' });
            diaN = Int32.Parse(campos[0]);
            mesN = Int32.Parse(campos[1]);
            anioN = Int32.Parse(campos[2]);

            Console.Write("Introduce fecha actual (separado por /): ");
            linea = Console.ReadLine();
            campos = linea.Split(new Char[] { '/', '-' });
            diaA = Int32.Parse(campos[0]);
            mesA = Int32.Parse(campos[1]);
            anioA = Int32.Parse(campos[2]);

            //// 1. Leer la fecha de nacimiento
            //Console.Write("Introduce dia: ");
            //linea = Console.ReadLine();
            //diaN = Int32.Parse(linea);
            //Console.Write("Introduce mes: ");
            //linea = Console.ReadLine();
            //mesN = Int32.Parse(linea);
            //Console.Write("Introduce año: ");
            //linea = Console.ReadLine();
            //anioN = Int32.Parse(linea);
            //// 2. Leer la fecha actual
            //Console.Write("Introduce dia: ");
            //linea = Console.ReadLine();
            //diaA = Int32.Parse(linea);
            //Console.Write("Introduce mes: ");
            //linea = Console.ReadLine();
            //mesA = Int32.Parse(linea);
            //Console.Write("Introduce año: ");
            //linea = Console.ReadLine();
            //anioA = Int32.Parse(linea);


            if ((mesA < mesN) || ((mesA == mesN) && (diaA < diaN)))
            {
                edad = (anioA - anioN) - 1;
            }
            else
            {
                edad = (anioA - anioN);
            }
            Console.WriteLine("La edad es: " + edad);
            Console.ReadKey();
        }
    }
}