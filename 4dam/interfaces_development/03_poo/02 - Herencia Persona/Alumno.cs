using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPersonas
{
    class Alumno : Persona
    {
        // Atributos
        private string nMatricula;
        private string curso;

        // Constructor
        public Alumno() : base() 
        {
            nMatricula = "1111111";
            curso = "4º";
        }

        public Alumno(string nMat, string cu)
        {
            nMatricula = nMat;
            curso = cu;
        }


        public Alumno(string no, int an, string di, string nMat, string cu)
            : base(no, an, di)
        {
            nMatricula = nMat;
            curso = cu;
        }

        public string NombreAlumno()
        {
            return (NombreCompleto() + 
                    " Nº Matricula: " + nMatricula +
                    " Curso: " + curso);
        }


    }
}
