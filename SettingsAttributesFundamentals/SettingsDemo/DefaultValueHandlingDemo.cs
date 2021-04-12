using System;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class DefaultValueHandlingDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Default Value Handling ***");

            var author = new AuthorDefaults();

            author.name = "Xavier Morera"; // No default
            author.courses = 4; //Default is 4
            author.happy = true; //Default is true
            author.resting = false; //Default is true
            //'state' not set, but has a default of 'Passionate about teaching'

            // Serialize with default values
            Console.WriteLine("- Serialize with default values but no setting");
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var authorJsonDefaults = JsonConvert.SerializeObject(author, settings);
            Console.WriteLine(authorJsonDefaults);

            // Ignore properties with default values when serializing 
            Console.WriteLine("- DefaultValueHandling.Ignore");
            var settingsIgnore = new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            var authorJsonDefaultsIgnore = JsonConvert.SerializeObject(author, settingsIgnore);
            Console.WriteLine(authorJsonDefaultsIgnore);

            // Include properties with default values when deserializing 
            Console.WriteLine("- Deserialize default");
            var authorOnlyName = "{'name': 'Xavier Morera'}";

            AuthorDefaults authorDefaultValueHandling = JsonConvert.DeserializeObject<AuthorDefaults>(authorOnlyName);
            Console.WriteLine(authorDefaultValueHandling?.state);

            Console.WriteLine("- DefaultValueHandling.Populate");
            var settingsPopulate = new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Populate,
                Formatting = Formatting.Indented
            };

            AuthorDefaults authorDefaultValueHandlingPopulate = JsonConvert.DeserializeObject<AuthorDefaults>(authorOnlyName, settingsPopulate);
            Console.WriteLine(authorDefaultValueHandlingPopulate?.state);

            //Populate and Ignore can be used together with IgnoreAndPopulate
        }
    }
}
