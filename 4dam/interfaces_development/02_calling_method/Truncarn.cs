using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTruncar2
{
    class Truncarn
    {
        static double truncarNum(double num, int parteDecimal)
        {
            double resultado;

            resultado = Math.Round(num, parteDecimal, MidpointRounding.ToEven);
            return resultado;
        }

        static void Main(string[] args)
        {
            // Truncar1: Un parámetro de tipo entero y devuelve el número tras truncar la parte decimal a 0 decimales. Ej. 764.783 764
            // Truncar2: Un parámetro de tipo entero y otro parámetro de tipo entero y devuelve el número tras truncar la parte decimal 
            // a los decimales indicado por el segundo parámetro. Ej. 764.783 y 2 764.78 
            // Truncar3: Tres parámetros de tipo entero y devuelve el número tras truncar la parte decimal a los decimales indicado por 
            // el segundo parámetro y añadiendo la cifra indicada en el tercer parámetro. Ej. 764.783 , 2 y 7 764.787

            double numero1, truncar;
            int decimals;

            Console.Write("Introduce un número: ");
            numero1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce los decimales: ");
            decimals = Int32.Parse(Console.ReadLine());
            truncar = truncarNum(numero1, decimals);
            Console.WriteLine("El número truncado es " + truncar);
            Console.ReadKey();
        }
    }
}
