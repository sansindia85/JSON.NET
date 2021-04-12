using System;
using Newtonsoft.Json;

namespace AttributesDemo
{
    public static class JsonConstructorAttribute
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** [JsonConstructor] ***");

            var authorJson = @"{'authorName': 'Xavier Morera As Parameter'}";

            var xavierNoAttribute = JsonConvert.DeserializeObject<AuthorConstructor>(authorJson);
            Console.WriteLine(xavierNoAttribute?.author);

            AuthorConstructorAttribute xavierWithAttribute = JsonConvert.DeserializeObject<AuthorConstructorAttribute>(authorJson);
            Console.WriteLine(xavierWithAttribute?.author);
        }
    }
    
}
