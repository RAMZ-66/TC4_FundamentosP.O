using System;

using System.Collections.Generic;

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
            

            Materia programacion1 = new Materia ("Programación 1", 2);
            Console.WriteLine($"La materia de {programacion1.nombreMateria} se ve en {programacion1.NombreSemestre}");

            
            Materia inteligenciaArtificial = new Materia ("Inteligencia Artificial", 7);
            Console.WriteLine($"La materia de {inteligenciaArtificial.nombreMateria} se ve en {inteligenciaArtificial.NombreSemestre}");

            //Introduccion a listas
            
            List <Materia> materiasDeInteres = new List<Materia>();
            materiasDeInteres.Add(programacion1);
            materiasDeInteres.Add(inteligenciaArtificial);
            materiasDeInteres.Add(new Materia("Sistemas Interactivos 1", 7));
            
            
            Console.WriteLine("La materia de " + materiasDeInteres[2].nombreMateria + " se ve en " + materiasDeInteres[2].NombreSemestre);

            Console.WriteLine("Me interesan " + materiasDeInteres.Count + " materias");

            for (int i = 0; i < materiasDeInteres.Count; i++ )
            {
                Console.WriteLine(materiasDeInteres[i].nombreMateria);
            }

            Console.WriteLine("...");
            materiasDeInteres.Remove(programacion1);
            Console.WriteLine("Ahora me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("Primera materia ahora es: " + materiasDeInteres[0].nombreMateria);

            Materia materiaBorrar = null;

            for (int i = 0; i < materiasDeInteres.Count; i++ )
            {
                if (materiasDeInteres[i].nombreMateria == "Sistemas Interactivos 1")
                {
                    materiaBorrar = materiasDeInteres[i];
                    
                    break;
                }

            }

            //Break interrumpe el ciclo para que ya no siga, en caso de que se cumpla el if 

            if (materiaBorrar != null)
            {
                // Sí se encontró
                materiasDeInteres.Remove(materiaBorrar);
            }

            Console.WriteLine("Ahora me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("Primer materia ahora es: " + materiasDeInteres[0].nombreMateria);


        }

    }

}
