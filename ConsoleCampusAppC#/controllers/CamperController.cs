using ConsoleCampusAppC_.persistence;
using System;
using System.Collections.Generic;
using ConsoleCampusAppC_.models;

namespace ConsoleCampusAppC_.controllers
{
    class CamperController
    {
        public static void CrearCamper(Camper camper)
        {
            var campers = JsonHandler.ReadFromJsonFile();
            campers[camper.Identificacion] = camper; 
            JsonHandler.WriteToJsonFile(campers);
        }

        public static List<Camper> ListarCampers()
        {
            return new List<Camper>(JsonHandler.ReadFromJsonFile().Values);
        }

        public static Camper GetCamperByIdentificacion(long id)
        {
            var campers = JsonHandler.ReadFromJsonFile();
            return campers.ContainsKey(id) ? campers[id] : null;
        }

        public static void EliminarCamperPorId(long id)
        {
            var campers = JsonHandler.ReadFromJsonFile();
            if (campers.Remove(id))
            {
                JsonHandler.WriteToJsonFile(campers);
            }
        }

        public static void EditarCamper(Camper camperActualizado)
        {
            var campers = JsonHandler.ReadFromJsonFile();
            if (campers.ContainsKey(camperActualizado.Identificacion))
            {
                campers[camperActualizado.Identificacion] = camperActualizado;
                JsonHandler.WriteToJsonFile(campers);
            }
        }
    }
}