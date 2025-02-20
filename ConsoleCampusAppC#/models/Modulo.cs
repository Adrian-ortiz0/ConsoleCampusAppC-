using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Modulo
    {
        public long Id { get; set; }
        public String Nombre { get; set; }
        public double NotaTeorica { get; set; }
        public double NotaPractica { get; set; }
        public double NotaTrabajos { get; set; }
        public double NotaExamen {  get; set; }
        public bool Aprobado { get; set; }

        public Modulo(long id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
