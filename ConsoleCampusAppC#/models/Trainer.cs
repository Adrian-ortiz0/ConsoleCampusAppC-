﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_.models
{
    class Trainer : Usuario
    {
        public List<Curso> CursosTrainer { get; set; }

        public List<RutaEntrenamiento> RutasTrainer { get; set; }
        public String Horario {  get; set; }

        public Trainer(long id, string nombre, string apellido
            , string email, string contraseña
            , List<Curso> cursosTrainer, List<RutaEntrenamiento> rutasTrainer, string horario) : base(id, nombre, apellido, email, contraseña)
        {
            this.CursosTrainer = cursosTrainer;
            this.RutasTrainer = rutasTrainer;
            this.Horario = horario;
        }

        public void ProbarCampers(Camper camper)
        {

        }
    }
}
