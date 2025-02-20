using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Curso
    {
        public String Nombre { get; set; }
        public String Horario { get; set; }
        public RutaEntrenamiento RutaAsignada { get; set; }
        public Trainer TrainerAsignado { get; set; }
        public List<Camper> Campers { get; set; }

        public Curso(string nombre, string horario, Trainer trainerAsignado, List<Camper> campers)
        {
            Nombre = nombre;
            Horario = horario;
            TrainerAsignado = trainerAsignado;
            Campers = campers;
        }
    }
}
