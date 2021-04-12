using System;
using Newtonsoft.Json;

namespace AttributesDemo
{
    public static class JsonAttributesDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** [JsonObject] ***");

            Console.WriteLine("- No attribute");

            var xavierAuthor = new Author();
            xavierAuthor.courses.Add(new Course { courseName = "Solr", duration = 182 });
            xavierAuthor.courses.Add(new Course { courseName = "Spark", duration = 183 });
            var xavierAuthorSerialized = JsonConvert.SerializeObject(xavierAuthor, Formatting.Indented);
            Console.WriteLine(xavierAuthorSerialized);

            Console.WriteLine("- With [JsonObject] attribute");
            var xavierAuthorAttribute = new AuthorJsonObject();
            xavierAuthorAttribute.courses.Add(new Course() { courseName = "Solr", duration = 180 });
            xavierAuthorAttribute.courses.Add(new Course() { courseName = "Spark", duration = 181 });
            var xavierAuthorSerializedAttribute = JsonConvert.SerializeObject(xavierAuthorAttribute, Formatting.Indented);
            Console.WriteLine(xavierAuthorSerializedAttribute);

            Console.WriteLine("- With [JsonArray] attribute");
            var xavierAuthorArray = new AuthorJsonArray();
            xavierAuthorArray.courses.Add(new Course() { courseName = "Solr", duration = 180 });
            xavierAuthorArray.courses.Add(new Course() { courseName = "Spark", duration = 181 });
            string xavierAuthorSerializedArray = JsonConvert.SerializeObject(xavierAuthorArray, Formatting.Indented);
            Console.WriteLine(xavierAuthorSerializedArray);

            Console.WriteLine("[JsonArray] and [JsonDictionary]");

            var dictionaryAttribute = new DictionaryWithDictionaryAttribute<string, string>();
            var arrayAttribute = new DictionaryWithArrayAttribute<string, string>();

            Console.WriteLine("- JsonDictionary");
            dictionaryAttribute.Add("key1", "value1");
            dictionaryAttribute.Add("key2", "value2");
            Console.WriteLine(JsonConvert.SerializeObject(dictionaryAttribute, Formatting.Indented));

            Console.WriteLine("- JsonArray");
            arrayAttribute.Add("key1", "value1");
            arrayAttribute.Add("key2", "value2");
            Console.WriteLine(JsonConvert.SerializeObject(arrayAttribute, Formatting.Indented));
        }
    }
}
