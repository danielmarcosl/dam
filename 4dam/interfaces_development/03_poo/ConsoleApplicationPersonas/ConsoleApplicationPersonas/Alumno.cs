using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPersonas
{
    class Alumno : Persona
    {
        // Atributos
        string nMatricula;
        string curso;

        // Constructor
        public Alumno()
        {
            nMatricula = "1111111";
            curso = "4º";
        }

        public Alumno(string no, int an, string di, string nMat, string cu)
            : base(no,an,di)
        {
            nMatricula = nMat;
            curso = cu;
        }

        public string NombreAlumno()
        {
            return (" Nº Matricula: " + nMatricula + " Curso: " + curso);
        }
    }
}
