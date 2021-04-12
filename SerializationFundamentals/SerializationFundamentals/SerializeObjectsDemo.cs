using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;

namespace SerializationFundamentals
{
    public static class SerializeObjectsDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** Serialize Objects Demo ***");

            var xavier = new Author()
            {
                name = "Xavier Morera",
                courses = new[] { "Solr", "Spark", "Python", "Jira" },
                happy = true
            };

            Console.WriteLine("Step 1: Serialize an Object");
            var objectSerialized = JsonConvert.SerializeObject(xavier, Formatting.Indented);
            Console.WriteLine(objectSerialized);

            Console.WriteLine("Step 2: Serialize a Collection");
            var courses = new List<string> { "Solr", "Spark", "Python", "Jira" };
            var collectionSerialized = JsonConvert.SerializeObject(courses);
            Console.WriteLine(collectionSerialized);

            Console.WriteLine("Step 3: Serialize a Dictionary");
            var views = new Dictionary<string, int>
            {
                { "Solr", 1500 },
                { "Spark", 300 },
                { "Jira", 2000 }
            };
            var dictionarySerialized = JsonConvert.SerializeObject(views, Formatting.Indented);
            Console.WriteLine(dictionarySerialized);

            Console.WriteLine("Step 4: Serialize a DataSet");
            var coursesDataSet = Generate.CoursesDataSet();
            var datasetSerialized = JsonConvert.SerializeObject(coursesDataSet, Formatting.Indented);
            Console.WriteLine(datasetSerialized);

            Console.WriteLine("Step 5: Serialize JSON to a file");
            await File.WriteAllTextAsync(@"xavier.json", JsonConvert.SerializeObject(xavier));
        }
    }
}
