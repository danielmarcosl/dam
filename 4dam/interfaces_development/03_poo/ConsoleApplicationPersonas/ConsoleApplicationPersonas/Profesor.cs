using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPersonas
{
    class Profesor
    {
        // Atributos
        private string nombre;
        private int sueldo;
        private int anios;
        private string titulo;

        // Constructor
        public Profesor()
        {
            nombre = "profesorqw";
            sueldo = 288;
            anios = 30;
            titulo = "Titulo estandar de profesor de barra de bar";
        }

        public Profesor(string no, int su, int an, string ti)
        {
            sueldo = su;
            anios = an;
            titulo = ti;
        }

        public string NombreProfesor()
        {
            return("Nombre: " + nombre + " Sueldo: " + sueldo + " Anios: " + anios + " Titulo: " + titulo);
        }
    }
}
