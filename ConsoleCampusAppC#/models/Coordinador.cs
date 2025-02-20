using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Coordinador : Usuario, ICoordinador
    {
        public Coordinador(long id, string nombre, string apellido, string email, string contraseña) : base(id, nombre, apellido, email, contraseña)
        {
        }

        public void AprobarCamper(Camper camper)
        {
            throw new NotImplementedException();
        }

        public void ContratarTrainer(Trainer trainer)
        {
            throw new NotImplementedException();
        }

        public void CrearCursos(Curso curso)
        {
            throw new NotImplementedException();
        }

        public void CrearModulo(Modulo modulo)
        {
            throw new NotImplementedException();
        }

        public void CrearRutaDeEntrenamiento(RutaEntrenamiento rutaEntrenamiento)
        {
            throw new NotImplementedException();
        }

        public void CrearSalon(Salon salon)
        {
            throw new NotImplementedException();
        }

        public void EvaluarCamper(List<Camper> campers)
        {
            throw new NotImplementedException();
        }
    }
}
