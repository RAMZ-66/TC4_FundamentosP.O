using System;

namespace TC4__Fundamentos.P.O
{

    class Materia
    {

        public string nombreMateria;

        int semestre;

        public string NombreSemestre
        {
            get => TransformarSemestreATexto() + " semestre";
        }

        private string TransformarSemestreATexto()
        {

            if (this.semestre == 1)
            {
                return "1er";
            }
            else if(this.semestre == 2)
            {
                return "2ndo";

            }
            else if(this.semestre == 3)
            {
                return "3er";

            }
            else if(this.semestre == 4)
            {
                return "4to.";

            }
            else if(this.semestre == 5)
            {
                return "5to.";

            }
                  else if(this.semestre == 6)
            {
                return "6to.";

            }
            else if(this.semestre == 7)
            {
                return "7mo";

            }
            else if(this.semestre == 8)
            {
                return "8vo.";

            }
            else 
            {
                return this.semestre + " to";
            }
        }

        public Materia(string nombreMateria, int semestre)
        {
            
            this.nombreMateria = nombreMateria;

            this.semestre = semestre;

        }



    }










}