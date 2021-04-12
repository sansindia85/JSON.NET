using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace JSONTextFundamentals
{
    public static class JsonSerializerDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** JsonSerializer Demo ***");

            var xavier = new Author()
            {
                name = "Xavier Morera",
                courses = new[] { "Solr", "Spark", "Jira" },
                happy = true,
                since = new DateTime(2014, 01, 15)
            };

            Console.WriteLine("Step 1: Serialize JSON with default settings");

            //Does not serialize immediately
            //await using var streamWriter = new StreamWriter("1-defaultsettings.json");
            //var serializer = new JsonSerializer();
            //serializer.Serialize(streamWriter, xavier);

            await using (var streamWriter = new StreamWriter("1-defaultsettings.json"))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(streamWriter, xavier);
            }

            Console.WriteLine("Step 2: Serialize JSON with indented true");

            await using (var streamWriter = new StreamWriter("2-indented.json"))
            {
                var serializer = new JsonSerializer {Formatting = Formatting.Indented};
                serializer.Serialize(streamWriter, xavier);
            }

            Console.WriteLine("Step 3: Serialize JSON with ignore nulls");

            using (var sw = new StreamWriter("3-ignorenulls.json"))
            {
                JsonSerializer serializer = new JsonSerializer
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented
                };
                serializer.Serialize(sw, xavier);
            }

            Console.WriteLine("Curious about size difference?");

            var defaultSettings = new FileInfo(@"1-defaultsettings.json");
            Console.WriteLine("Size of file 1-defaultsettings.json: {0} bytes", defaultSettings.Length);

            FileInfo indented = new FileInfo(@"2-indented.json");
            Console.WriteLine("Size of file 2-indented.json: {0} bytes", indented.Length);

            FileInfo ignoreNulls = new FileInfo(@"3-ignorenulls.json");
            Console.WriteLine("Size of file 3-ignorenulls.json: {0} bytes", ignoreNulls.Length);
        }
    }
}
