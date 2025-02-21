using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleCampusAppC_.persistence
{
    public class JsonHandler
    {
        private static readonly string DefaultPath = Path.Combine(
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName,
            "persistence", "CampusApp.json");

        public static T ReadEntityFromJsonFile<T>(string rootName)
        {
            if (File.Exists(DefaultPath))
            {
                string jsonData = File.ReadAllText(DefaultPath);
                var wrapper = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(jsonData);
                if (wrapper != null && wrapper.ContainsKey(rootName))
                {
                    return wrapper[rootName].ToObject<T>();
                }
            }
            return default(T);
        }
        public static void WriteEntityToJsonFile<T>(T data, string rootName)
        {
            Dictionary<string, JToken> wrapper;
            if (File.Exists(DefaultPath))
            {
                string jsonData = File.ReadAllText(DefaultPath);
                wrapper = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(jsonData)
                          ?? new Dictionary<string, JToken>();
            }
            else
            {
                wrapper = new Dictionary<string, JToken>();
            }

            wrapper[rootName] = JToken.FromObject(data);
            string output = JsonConvert.SerializeObject(wrapper, Formatting.Indented);
            File.WriteAllText(DefaultPath, output);
        }
    }
}
