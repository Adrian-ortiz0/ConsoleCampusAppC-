using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleCampusAppC_.persistence
{
    class JsonHandler
    {
        private static readonly string DefaultPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "persistence", "CampusApp.json");

        public static void WriteToJsonFile<T>(List<T> data)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(DefaultPath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo JSON: {ex.Message}");
            }
        }

        public static List<T> ReadFromJsonFile<T>()
        {
            try
            {
                if (File.Exists(DefaultPath))
                {
                    string jsonData = File.ReadAllText(DefaultPath);
                    return JsonConvert.DeserializeObject<List<T>>(jsonData) ?? new List<T>();
                }
                else
                {
                    Console.WriteLine("El archivo JSON no existe. Creando uno nuevo...");
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                return new List<T>();
            }
        }
    }
}
