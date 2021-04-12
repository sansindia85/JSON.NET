using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationFundamentals
{
    public static class DeserializeObjectsDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** Deserialize Objects Demo ***");

            var jsonAuthor = @"{
                'name': 'Xavier Morera', 
                'courses': ['Solr', 'Spark', 'Jira'], 
                'happy': true }";

            Console.WriteLine("Step 1: Deserialize to a typed object");
            var authorObj = JsonConvert.DeserializeObject<Author>(jsonAuthor);
            Console.WriteLine(authorObj?.name);

            Console.WriteLine("Step 2: Deserialize into a var");
            var authorVar = JsonConvert.DeserializeObject(jsonAuthor);
            Console.WriteLine(authorVar);

            Console.WriteLine("Step 3: Deserialize into an anonymous type");
            var authorAnonymousDefinition = new
            {
                author = string.Empty,
                happy = false,
                courses = new string[] { },
                anotherproperty = string.Empty
            };
            var authorAnonymous = JsonConvert.DeserializeAnonymousType(jsonAuthor, authorAnonymousDefinition);
            Console.WriteLine(authorAnonymous);

            Console.WriteLine("Step 4: Deserialize a Collection");
            var jsonCollection = @"['Solr', 'Spark', 'Jira']";
            var coursesList = JsonConvert.DeserializeObject<List<string>>(jsonCollection);
            Console.WriteLine(coursesList?.ToString());
            if (coursesList == null) return;
            foreach (var course in coursesList)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Step 5: Deserialize a Dictionary");
            var jsonDictionary = @"{ 'Solr': 1500, 'Spark': 300, 'Jira': 2000 }";
            var coursesDict = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonDictionary);
            if (coursesDict != null)
                foreach (var kvp in coursesDict)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }

            Console.WriteLine("Step 6: Deserialize JSON from a file");
            var xavierAuthor = JsonConvert.DeserializeObject<Author>(await File.ReadAllTextAsync(@"xavier.json"));
            Console.WriteLine(xavierAuthor?.name);
        }
    }
}
