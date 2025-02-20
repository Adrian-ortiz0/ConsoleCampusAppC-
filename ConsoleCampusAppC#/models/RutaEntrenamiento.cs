using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class RutaEntrenamiento
    {
        public string Nombre { get; set; }
        public List<Modulo> Modulos { get; set; }

        public RutaEntrenamiento(string nombre, List<Modulo> modulos)
        {
            Nombre = nombre;
            Modulos = modulos;
        }
    }
}
