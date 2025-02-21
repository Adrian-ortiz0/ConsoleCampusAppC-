using System;
using System.Collections.Generic;
using ConsoleCampusAppC_.persistence;
using ConsoleCampusAppC_.models;

namespace ConsoleCampusAppC_.controllers
{
    class CoordinadorController
    {
        public static void CrearCoordinador(Coordinador coordinador)
        {
            Dictionary<long, Coordinador> coordinadores = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Coordinador>>("coordinadores");
            if (coordinadores == null)
            {
                coordinadores = new Dictionary<long, Coordinador>();
            }
            coordinadores[coordinador.Identificacion] = coordinador;
            JsonHandler.WriteEntityToJsonFile(coordinadores, "coordinadores");
        }

        public static List<Coordinador> ListarCoordinadores()
        {
            Dictionary<long, Coordinador> coordinadores = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Coordinador>>("coordinadores");
            if (coordinadores == null)
            {
                coordinadores = new Dictionary<long, Coordinador>();
            }
            return new List<Coordinador>(coordinadores.Values);
        }

        public static Coordinador GetCoordinadorByIdentificacion(long id)
        {
            Dictionary<long, Coordinador> coordinadores = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Coordinador>>("coordinadores");
            if (coordinadores != null && coordinadores.ContainsKey(id))
            {
                return coordinadores[id];
            }
            return null;
        }

        public static void EliminarCoordinadorPorId(long id)
        {
            Dictionary<long, Coordinador> coordinadores = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Coordinador>>("coordinadores");
            if (coordinadores != null && coordinadores.Remove(id))
            {
                JsonHandler.WriteEntityToJsonFile(coordinadores, "coordinadores");
            }
        }

        public static void EditarCoordinador(Coordinador coordinadorActualizado)
        {
            Dictionary<long, Coordinador> coordinadores = JsonHandler.ReadEntityFromJsonFile<Dictionary<long, Coordinador>>("coordinadores");
            if (coordinadores != null && coordinadores.ContainsKey(coordinadorActualizado.Identificacion))
            {
                coordinadores[coordinadorActualizado.Identificacion] = coordinadorActualizado;
                JsonHandler.WriteEntityToJsonFile(coordinadores, "coordinadores");
            }
        }
    }
}
