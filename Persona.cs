using System;

namespace TC4__Fundamentos.P.O
{
    class Persona
    {
        public string nombre;

        public string apellido;

        private string colorFavorito;

        public string ColorFavorito
        {
            get => this.colorFavorito;

            set => this.colorFavorito = value;
        }

        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }

        public Persona (string nombre, string apellido)
        {
            this.nombre = nombre;

            this.apellido = apellido;

        }

        public virtual void Presentarse()
        {
                                 
            Console.WriteLine($"Hola mi nombre es {NombreCompleto}");
        }                                             

    }
}
