using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationObjetos
{
    class Circulo
    {
        // Atributos
        private double radio;
        public double coordX, coordY;
  
        // Métodos

        public Circulo()
        {
            radio = 2;
            coordX = 10;
            coordY = 50;
        }

        public Circulo(double r)
        {
            radio = r;
            coordX = 10;
            coordY = 50;
        }

        public Circulo(double r,double px,double py)
        {
            radio = r;
            coordX = px;
            coordY = py;
        }

   
        public double Area()
        {
            return (3.1416 * radio * radio);
        }

        public void  CambiaRadio(double r)
        {
            radio = r;
        }

        public void Escribir()
        {
            Console.WriteLine("Radio: " + radio +  
                " PosX = " + coordX + " PosY = " + coordY);
        }



    }
}
