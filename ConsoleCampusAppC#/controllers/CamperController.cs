using ConsoleCampusAppC_.persistence;
using System.Collections.Generic;
using ConsoleCampusAppC_.models;

namespace ConsoleCampusAppC_.controllers
{
    class CamperController
    {
        public static void CrearCamper(Camper camper)
        {
            Dictionary<long, Camper> campers = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Camper>>("campers");
            if (campers == null)
            {
                campers = new Dictionary<long, Camper>();
            }
            campers[camper.Identificacion] = camper;
            JsonHandler.WriteEntityToJsonFile(campers, "campers");
        }

        public static List<Camper> ListarCampers()
        {
            Dictionary<long, Camper> campers = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Camper>>("campers");
            return campers != null ? new List<Camper>(campers.Values) : new List<Camper>();
        }

        public static Camper GetCamperByIdentificacion(long id)
        {
            Dictionary<long, Camper> campers = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Camper>>("campers");
            return (campers != null && campers.ContainsKey(id)) ? campers[id] : null;
        }

        public static void EliminarCamperPorId(long id)
        {
            Dictionary<long, Camper> campers = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Camper>>("campers");
            if (campers != null && campers.Remove(id))
            {
                JsonHandler.WriteEntityToJsonFile(campers, "campers");
            }
        }

        public static void EditarCamper(Camper camperActualizado)
        {
            Dictionary<long, Camper> campers = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Camper>>("campers");
            if (campers != null && campers.ContainsKey(camperActualizado.Identificacion))
            {
                campers[camperActualizado.Identificacion] = camperActualizado;
                JsonHandler.WriteEntityToJsonFile(campers, "campers");
            }
        }
    }
}
