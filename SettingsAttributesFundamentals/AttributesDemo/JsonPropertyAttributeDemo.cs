using System;
using Newtonsoft.Json;

namespace AttributesDemo
{
    class JsonPropertyAttributeDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** JsonProperty ***");

            var author = new AuthorProperties();
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(author));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Serializing Object: " + ex.Message);
            }

            author.name = "Xavier Morera";
            Console.WriteLine(JsonConvert.SerializeObject(author, Formatting.Indented));

            author.location = "Costa Rica";
            Console.WriteLine(JsonConvert.SerializeObject(author, Formatting.Indented));
        }
    }
}
