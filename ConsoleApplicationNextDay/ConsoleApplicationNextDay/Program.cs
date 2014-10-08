﻿using System;
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

            int day, month, year;
            string line;

            Console.WriteLine("Introduce los datos con formato numérico");
            Console.Write("Introduce el día: ");
            line = Console.ReadLine();
            day = Int32.Parse(line);

            Console.Write("Introduce el mes: ");
            line = Console.ReadLine();
            month = Int32.Parse(line);

            Console.Write("Introduce el año: ");
            line = Console.ReadLine();
            year = Int32.Parse(line);

            if (day < 28 && month == 2 || day < 30 && month == 4 || day < 30 && month == 6 || day < 30 && month == 9 || day < 30 && month == 11)
            {
                if (day != 31)
                {
                    Console.Write("El siguiente día es " + (day + 1) + " del mes " + month + " del año " + year + ".");
                }
            }
            else
            {
                if (day == 31 && month <= 11)
                {
                    day = day - 30;
                    month++;
                    Console.Write("El siguiente día es " + day + " del mes " + month + " del año " + year + ".");
                }
                else
                {
                    if (day == 31 && month == 12)
                    {
                        day = day - 30;
                        month = month - 11;
                        year++;
                        Console.Write("El siguiente día es " + day + " del mes " + month + " del año " + year + ".");
                    }
                    else
                    {
                        if (day == 28 && month == 2)
                        {
                            day = day - 27;
                            month++;
                            Console.Write("El siguiente día es " + day + " del mes " + month + " del año " + year + ".");
                        }
                        else
                        {
                            if (day == 30 && month == 4 || day == 30 && month == 6 || day == 30 && month == 9 || day == 30 && month == 11)
                            {
                                day = day - 29;
                                month++;
                                Console.Write("El siguiente día es " + day + " del mes " + month + " del año " + year + ".");
                            }
                            else
                            {
                                if ((year % 4) == 0 && month == 2 && day <= 28)
                                {
                                    day++;
                                    month++;
                                    Console.Write("El siguiente día es " + day + " del mes " + month + " del año " + year + ".");
                                }
                                else
                                {
                                    if (day == 29)
                                    {
                                        day = day - 28;
                                        month++;
                                        Console.Write("El siguiente día es " + day + " del mes " + month + " del año " + year + ".");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}