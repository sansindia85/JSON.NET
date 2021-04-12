using System;
using Newtonsoft.Json;

namespace SettingsDemo
{
    class SerializationNullValueHandlingDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Null Value Handling ***");

            var xavierWithNullValue = new Author
            {
                name = "Xavier Morera",
                happy = true
            };

            // Serialize class with null values without specifying how to handle null values
            Console.WriteLine("- Serialize object with null values");
            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var xavierNullValue = JsonConvert.SerializeObject(xavierWithNullValue, jsonSettings);
            Console.WriteLine(xavierNullValue);

            // Serialize using NullValueHandling.Ignore
            Console.WriteLine("- Serialize object with setting to ignore null values");
            var jsonSettingsIgnore = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            var xavierNullValueIgnore = JsonConvert.SerializeObject(xavierWithNullValue, jsonSettingsIgnore);
            Console.WriteLine(xavierNullValueIgnore);
        }
    }
}
