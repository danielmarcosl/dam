using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationNextDay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa que determine el día siguiente a uno dado
            //
            //Realizar un programa que lea dos fechas: nacimiento y actual. Escriba por pantalla la edad de la persona
            int day, month, year;
            string line;

            Console.WriteLine("Introduce los datos con el formato 00 para día y mes");
            Console.Write("Introduce el día: ");
            line = Console.ReadLine();
            day = Int32.Parse(line);

            Console.Write("Introduce el mes: ");
            line = Console.ReadLine();
            month = Int32.Parse(line);

            Console.Write("Introduce el año: ");
            line = Console.ReadLine();
            year = Int32.Parse(line);

            if(month != 2
        }
    }
}
