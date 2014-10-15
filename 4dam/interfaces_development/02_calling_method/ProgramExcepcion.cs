using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationExcepcion
{
    class ProgramExcepcion
    {
        static void HacerSumarSinTry()
        {
            int numero1, numero2;
            string linea;

            Console.Write("Introduce numero 1: ");
            linea = Console.ReadLine();
            numero1 = Int32.Parse(linea);
            
            Console.Write("Introduce numero 2: ");
            linea = Console.ReadLine();
            numero2 = Int32.Parse(linea);

            Console.WriteLine("La suma es : " + (numero1 + numero2));
            Console.ReadKey();

        }

        static void HacerSumarConTry()
        {
            try
            {
                int numero1, numero2;
                string linea;

                Console.Write("Introduce numero 1: ");
                linea = Console.ReadLine();
                numero1 = Int32.Parse(linea);

                Console.Write("Introduce numero 2: ");
                linea = Console.ReadLine();
                numero2 = Int32.Parse(null);

                Console.WriteLine("La suma es : " + (numero1 + numero2));
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error en la conversión de números. " +
                    "Introduce SOLO números. " + e.Message);
                Console.ReadKey();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error en la conversión de números. " +
                    "No se ha introducido una cadena. " + e.Message);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            HacerSumarConTry();
        }
    }
}
