using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleCampusAppC_
{
    public class Operacion
    {
        public String Tipo {  get; set; }
        public double Resultado { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String path = "operaciones.json";

            Operacion operacion = new Operacion { Tipo = "Suma", Resultado = 8 };

            // Seerializar operacion en el JSON

            EscribirEnJson(path, operacion);

            // Leer el archivo y deserializar el JSON
            Operacion operacionLeida = LeerJson(path);

            if (operacionLeida != null)
            {
                Console.WriteLine($"Operación: {operacionLeida.Tipo}, Resultado: {operacionLeida.Resultado}");
            }


        }
        public static void EscribirEnJson(string path, Operacion operacion)
        {
            try
            {
                String json = JsonSerializer.Serialize(operacion);
                File.WriteAllText(path, json);
                Console.WriteLine("operacion escrita correctamente");
            }
            catch(Exception e) { 
                Console.WriteLine(e.Message);
            }
        }

        public static Operacion LeerJson(string path)
        {
            try
            {
                String json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<Operacion>(json);

            }catch(Exception e)
            {
                Console.WriteLine($"Error en lectura de archivo {e.Message}");
                return null;
            }
        }
    }
}
