using System;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class ConstructorHandlingDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Constructor Handling ***");

            var jsonConstructor = "{'name': 'Xavier Morera', 'happy': true }";

            // Use the default constructor
            try
            {
                Console.WriteLine("- Deserialize normally");
                var author = JsonConvert.DeserializeObject<AuthorConstructor>(jsonConstructor);
                Console.WriteLine(author?.name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Use the non-public constructor
            Console.WriteLine("- Deserialize with AllowNonPublicDefaultConstructor");
            var settings = new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };

            var authorConstructorHandling = JsonConvert.DeserializeObject<AuthorConstructor>(jsonConstructor, settings);
            Console.WriteLine(authorConstructorHandling?.name);
        }
    }
}
