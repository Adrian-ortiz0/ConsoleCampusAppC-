using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Modulo
    {
        public String Nombre { get; set; }
        public double NotaTeorica { get; set; }
        public double NotaPractica { get; set; }
        public double NotaTrabajos { get; set; }
        public double NotaExamen {  get; set; }
        public bool Aprobado { get; set; }

        public Modulo(string nombre, double notaTeorica, double notaPractica, double notaTrabajos, double notaExamen, bool aprobado)
        {
            Nombre = nombre;
            NotaTeorica = notaTeorica;
            NotaPractica = notaPractica;
            NotaTrabajos = notaTrabajos;
            NotaExamen = notaExamen;
            Aprobado = aprobado;
        }
    }
}
