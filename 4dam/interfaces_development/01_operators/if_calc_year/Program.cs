using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationCalculaAnyo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa que lea dos fechas: nacimiento y actual. Escriba por pantalla la edad de la persona

            int actDia, actMes, actAnyo, nacDia, nacMes, nacAnyo, edadDia = 0, edadMes = 0, edadAnyo = 0;
            string linea;

            Console.WriteLine("Introduce los datos con formato numérico");
            // Fecha actual
            Console.Write("Introduce el día actual: ");
            linea = Console.ReadLine();
            actDia = Int32.Parse(linea);

            Console.Write("Introduce el mes actual: ");
            linea = Console.ReadLine();
            actMes = Int32.Parse(linea);

            Console.Write("Introduce el año actual: ");
            linea = Console.ReadLine();
            actAnyo = Int32.Parse(linea);

            // Fecha nacimiento
            Console.Write("Introduce el día de nacimiento: ");
            linea = Console.ReadLine();
            nacDia = Int32.Parse(linea);

            Console.Write("Introduce el mes de nacimiento: ");
            linea = Console.ReadLine();
            nacMes = Int32.Parse(linea);

            Console.Write("Introduce el año de nacimiento: ");
            linea = Console.ReadLine();
            nacAnyo = Int32.Parse(linea);

            if (actAnyo > nacAnyo || actAnyo == nacAnyo && actMes > nacMes || actAnyo == nacAnyo && actMes == nacMes && actDia > nacDia)
            {
                // Calcular el día de la edad actual
                if (actDia > nacDia)
                {
                    edadDia = actDia - nacDia;
                }
                else
                {
                    if (actMes == 1 && (actAnyo % 4) != 0)
                    {
                        edadDia = (actDia + 28) - nacDia;
                        actMes--;
                    }
                    else
                    {
                        if (actMes == 1 && (actAnyo % 4) == 0)
                        {
                            edadDia = (actDia + 29) - nacDia;
                            actMes--;
                        }
                        else
                            if (actMes == 3 || actMes == 5 || actMes == 8 || actMes == 10)
                            {
                                edadDia = (actDia + 30) - nacDia;
                                actMes--;
                            }
                            else
                            {
                                edadDia = (actDia + 31) - nacDia;
                                actMes--;
                            }
                    }
                }

                // Calcular el mes de la edad actual
                if (actMes > nacMes)
                {
                    edadMes = actMes - nacMes;
                }
                else
                {
                    edadMes = (actMes + 12) - nacMes;
                    actAnyo--;
                }

                // Calcular el año de la edad actual
                edadAnyo = actAnyo - nacAnyo;
            }
            else
            {
                Console.WriteLine("Has introducido mal las fechas");
            }

            Console.WriteLine("Tu edad son " + edadDia + " días, " + edadMes + " meses y " + edadAnyo + " años.");
            Console.ReadKey();
        }
    }
}
