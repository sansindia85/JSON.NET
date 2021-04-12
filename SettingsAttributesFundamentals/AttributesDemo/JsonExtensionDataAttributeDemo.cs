using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AttributesDemo
{
    public static class JsonExtensionDataAttributeDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine(" *** [JsonExtensionData] *** ");

            string authorJson = @"{'authorName': 'Xavier Morera in JSON'}";

            Console.WriteLine(authorJson);

            AuthorJsonExtension xavierJsonExtension = JsonConvert.DeserializeObject<AuthorJsonExtension>(authorJson);

            Console.WriteLine("author -> " + xavierJsonExtension.author);
            foreach (KeyValuePair<string, JToken> field in xavierJsonExtension.unMappedFields)
            {
                Console.WriteLine("Unmapped field: " + field.Key + " -> " + ((JValue)field.Value).Value);
            }
        }
    }
}
