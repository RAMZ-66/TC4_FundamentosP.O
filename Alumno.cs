using System;

namespace TC4__Fundamentos.P.O
{

    class Alumno : Persona
    {

        public int matricula;
        static public string escuela = "CRESP";

        public Alumno(string nombre, string apellido, int matricula) : base (nombre, apellido)
        {
        
        this.matricula = matricula;
        
        }

        public override void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {this.NombreCompleto} y estudio en {Alumno.escuela}, mi matricula es {this.matricula}");
        }
    }
}