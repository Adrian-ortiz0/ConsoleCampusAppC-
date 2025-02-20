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

        public Modulo(long id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
