using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class BinderDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Binder ***");

            var xavierBinder = new Author()
            {
                name = "Xavier Morera",
                courses = new List<string> { "Solr", "Spark", "Jira" },
                happy = true,
                car = new Car
                {
                    model = "Land Rover",
                    year = 1976
                }
            };

            // Baseline
            Console.WriteLine("- With TypeNameHandling");
            var jsonFullClass = JsonConvert.SerializeObject(xavierBinder, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });

            Console.WriteLine(jsonFullClass);

            // With TypeSerializationBinder
            Console.WriteLine("- With SerializationBinder");
            var binder = new TypeSerializationBinder
            {
                KnownTypes = new List<Type> { typeof(Car) }
            };

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                SerializationBinder = binder
                // [deprecated] Binder = binder
            };

            var json = JsonConvert.SerializeObject(xavierBinder, Formatting.Indented, settings);

            Console.WriteLine(json);
        }
    }
}
