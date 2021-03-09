using System;

namespace TC4__Fundamentos.P.O
{

    class Program
    {
     static void Main(string[] args)
     {
        Persona persona1 = new Persona ("Axe Miguel", "Ramírez Florez");

        persona1.Presentarse();

        Alumno alumno1 = new Alumno ("Axel Miguel", "Ramírez Florez", 6417);

        Console.WriteLine("Primer alumno: " + alumno1.NombreCompleto);
        

    }





















    }
}