using ConsoleCampusAppC_.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCampusAppC_.models;

namespace ConsoleCampusAppC_.controllers
{
    class CamperController
    {

        public static void CrearCamper(Camper camper)
        {
            var campers = JsonHandler.ReadFromJsonFile<Camper>();
            campers.Add(camper);
            JsonHandler.WriteToJsonFile(campers);
        }
    }
}
