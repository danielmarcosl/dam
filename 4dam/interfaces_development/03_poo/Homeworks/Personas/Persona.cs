using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personas
{
    class Persona
    {
        // Atributos
        private string nombre;
        private int anioNac;
        private string direccion;

        // Constructores
        public Persona()
        {
            nombre = "";
            anioNac = 2000;
            direccion = Madrid;
        }

        public Persona(string n, int a,string d)
        {
            nombre = "";
            anioNac = 2000;
            direccion = Madrid;
        }
    }
}
