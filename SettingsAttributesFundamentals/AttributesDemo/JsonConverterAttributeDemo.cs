using System;
using Newtonsoft.Json;

namespace AttributesDemo
{
    public static class JsonConverterAttributeDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** [JsonConverterAttribute] ***");

            AuthorNoConverterAttribute xavierNoAttribute = new AuthorNoConverterAttribute()
            {
                author = "Xavier",
                relationship = Relationship.IndependentAuthor,
                since = new DateTime(2015, 02, 15)
            };
            Console.WriteLine(JsonConvert.SerializeObject(xavierNoAttribute, Formatting.Indented));

            AuthorWithConverterAttribute xavierWithAttribute = new AuthorWithConverterAttribute()
            {
                author = "Xavier",
                relationship = Relationship.IndependentAuthor,
                since = new DateTime(2015, 02, 15)
            };
            Console.WriteLine(JsonConvert.SerializeObject(xavierWithAttribute, Formatting.Indented));
            //And of course it can be used at class level with the appropriate converter
        }
    }
}
