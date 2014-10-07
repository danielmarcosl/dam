using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class ProgramSwitch
    {
        static void Main(string[] args)
        {
            char letra = 's';

            switch (letra)
            {
                case 's':
                    Console.WriteLine("Ha pulsado sí");
                    break;
                case 'S':
                    Console.WriteLine("Ha pulsado sí");
                    break;
                case 'n':
                    Console.WriteLine("Ha pulsado no");
                    break;
                case 'N':
                    Console.WriteLine("Ha pulsado no");
                    break;
            }
            Console.ReadKey();
        }
    }
}
