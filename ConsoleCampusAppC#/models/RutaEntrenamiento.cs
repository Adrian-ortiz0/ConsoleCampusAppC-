using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class RutaEntrenamiento
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public List<Modulo> Modulos { get; set; }

        public RutaEntrenamiento(long id, string nombre, List<Modulo> modulos)
        {
            Id = id;
            Nombre = nombre;
            Modulos = modulos;
        }
    }
}
