using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPersonas
{
    class ProgramPersona
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", 2000, "Madrid");
            Alumno alumno1 = new Alumno("Pepe", 2014, "Toledo", "12345", "4ºD");
            Profesor profesor1 = new Profesor("Pepe Luis", 1234, 35, "Ingeniero Aeronautico");

            Console.WriteLine(persona1.NombreCompleto());
            Console.WriteLine(alumno1.NombreAlumno());
            Console.WriteLine(profesor1.NombreProfesor());
            Console.ReadKey();
        }
    }
}