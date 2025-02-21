using ConsoleCampusAppC_.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleCampusAppC_.persistence
{
    class JsonHandler
    {
        private static readonly string DefaultPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "persistence", "CampusApp.json");

        public static void WriteToJsonFile(Dictionary<long, Camper> campers)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(new { campers }, Formatting.Indented);
                File.WriteAllText(DefaultPath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo JSON: {ex.Message}");
            }
        }

        public static Dictionary<long, Camper> ReadFromJsonFile()
        {
            try
            {
                if (File.Exists(DefaultPath))
                {
                    string jsonData = File.ReadAllText(DefaultPath);
                    var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<long, Camper>>>(jsonData);
                    return jsonObject != null && jsonObject.ContainsKey("campers") ? jsonObject["campers"] : new Dictionary<long, Camper>();
                }
                else
                {
                    Console.WriteLine("El archivo JSON no existe. Creando uno nuevo...");
                    return new Dictionary<long, Camper>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                return new Dictionary<long, Camper>();
            }
        }
    }
}