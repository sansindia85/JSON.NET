using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SerializationFundamentals
{
    public static class ObjectReferencesDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.Write("*** Object References Demo ***");

            var xavier = new Author()
            {
                name = "Xavier Morera",
                courses = new[] { "Solr", "Spark", "Jira", "Python" }
            };

            var lars = new Author()
            {
                name = "Lars Klint",
                courses = new[] { "Windows Phone" }
            };

            var jason = new Author()
            {
                name = "Jason Alba",
                courses = new[] { "Email", "Soft Skills" }
            };

            xavier.favoriteAuthors = new List<Author>
            { 
                xavier, jason, lars, jason
            };

            var xavierJson = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });

            Console.WriteLine(xavierJson);
        }

        
}
}
