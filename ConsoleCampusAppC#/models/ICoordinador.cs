using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    interface ICoordinador
    {
        void AprobarCamper(Camper camper);
        void ContratarTrainer(Trainer trainer);
        void CrearRutaDeEntrenamiento(RutaEntrenamiento rutaEntrenamiento);
        void CrearCursos(Curso curso);
        void CrearModulo(Modulo modulo);
        void CrearSalon(Salon salon);
        void EvaluarCamper(List<Camper> campers);
    }
}
