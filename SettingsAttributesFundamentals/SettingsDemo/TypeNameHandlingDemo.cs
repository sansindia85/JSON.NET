using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class TypeNameHandlingDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** TypeNameHandling ***");

            var xavier = new Author
            {
                name = "Xavier Morera",
                courses = new List<string> {"Solr", "Spark", "Jira"},
                car = new Car {model = "Land Rover", year = 1976}
            };

            // Include the type on all 
            Console.WriteLine("- TypeNameHandling.All");
            var settingsAll = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };
            var xavierTypeNameHandlingAll = JsonConvert.SerializeObject(xavier, settingsAll);
            Console.WriteLine(xavierTypeNameHandlingAll);

            // Include type information only on arrays
            Console.WriteLine("- TypeNameHandling.Arrays");
            var settingsArrays = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Arrays,
                Formatting = Formatting.Indented
            };
            string xavierTypeNameHandlingArrays = JsonConvert.SerializeObject(xavier, settingsArrays);
            Console.WriteLine(xavierTypeNameHandlingArrays);

            // Also available: None, Objects or Auto
        }
    }
}
