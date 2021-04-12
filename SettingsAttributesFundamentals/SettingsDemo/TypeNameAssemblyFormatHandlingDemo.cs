using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class TypeNameAssemblyFormatHandlingDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** TypeNameAssemblyFormatHandling ***");

            var xavier = new Author
            {
                name = "Xavier Morera",
                courses = new List<string> {"Solr", "Spark", "Jira"},
                car = new Car {model = "Land Rover", year = 1976}
            };

            Console.WriteLine("- TypeNameAssemblyFormatHandling.Simple");
            var xavierSimple = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All, 
                //TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierSimple);

            Console.WriteLine("- TypeNameAssemblyFormatHandling.Full");
            var xavierFull = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierFull);
        }
    }
}
