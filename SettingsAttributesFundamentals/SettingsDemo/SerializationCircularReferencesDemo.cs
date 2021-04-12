using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public class SerializationCircularReferencesDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Circular References ***");

            var xavier = new Author { name = "Xavier Morera" };
            var alba = new Author { name = "J. Alba" };
            var simon = new Author { name = "Simon Robinson" };

            xavier.favoriteAuthors = new List<Author> { xavier, alba, simon };

            // Serialize with a circular reference  
            try
            {
                Console.WriteLine("- Serialize Author with circular reference");
                var xavierJson = JsonConvert.SerializeObject(xavier);
                Console.WriteLine(xavierJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Serialize ignoring the circular reference 
            Console.WriteLine("- Serialize Ignoring Author circular reference with ReferenceLoopHandling");
            var settingsIgnore = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            var xavierJsonReferenceLoopHandling = JsonConvert.SerializeObject(xavier, settingsIgnore);
            Console.WriteLine(xavierJsonReferenceLoopHandling);

            // Serialize managing the circular reference  
            Console.WriteLine("- Serialize Managing Author circular reference with ReferenceLoopHandling");
            var settingsAll = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Formatting = Formatting.Indented
            };
            var xavierJsonPreserveReferencesHandling = JsonConvert.SerializeObject(xavier, settingsAll);
            Console.WriteLine(xavierJsonPreserveReferencesHandling);
        }
    }
}
