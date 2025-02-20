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

        public static List<Camper> ListarCampers()
        {
            return JsonHandler.ReadFromJsonFile<Camper>();
        }

        public static Camper GetCamperByIdentificacion(long id)
        {
            return JsonHandler.ReadFromJsonFile<Camper>().FirstOrDefault(c => c.Identificacion == id);
        }

        public static void EliminarCamperPorId(long id)
        {
            var campers = JsonHandler.ReadFromJsonFile<Camper>();
            campers = campers.Where(c => c.Identificacion == id).ToList();
            JsonHandler.WriteToJsonFile(campers);
        }

        public static void EditarCamper(Camper camperActualizado)
        {
            var campers = JsonHandler.ReadFromJsonFile<Camper>();
            var camper = campers.FirstOrDefault(c => c.Identificacion == camperActualizado.Identificacion);
            if(camper != null)
            {
                camper.Nombre = camperActualizado.Nombre;
                camper.Apellido = camperActualizado.Apellido;
                camper.Email = camperActualizado.Email;
                camper.Contraseña = camperActualizado.Contraseña;
                camper.Direccion = camperActualizado.Direccion;
                camper.Acudiente = camperActualizado.Acudiente;
                camper.Telefono = camperActualizado.Telefono;
                camper.Estado = camperActualizado.Estado;
                camper.Riesgo = camperActualizado.Riesgo;

                JsonHandler.WriteToJsonFile(campers);
            }
        }
    }
}
