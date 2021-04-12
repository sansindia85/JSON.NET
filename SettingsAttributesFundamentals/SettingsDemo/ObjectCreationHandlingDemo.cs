using System;
using System.Linq;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class ObjectCreationHandlingDemo
    {
        /// <summary>
        /// controls how objects are created and deserialized to during deserialization.
        /// </summary>
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** ObjectCreationHandling ***");

            var xavierJson = await Generate.SmallJsonAsync();

            // Json.NET will append values to existing collections during deserialization
            Console.WriteLine("- No setting");
            var xavierObjectHandling = JsonConvert.DeserializeObject<Author>(xavierJson);

            if (xavierObjectHandling != null)
            {
                Console.WriteLine(xavierObjectHandling.courses.Count());
                Console.WriteLine(string.Join(",", xavierObjectHandling.courses));
            }

            // Json.NET will replace existing values on collections during deserialization
            Console.WriteLine("- ObjectCreationHandling.Replace");
            var xavierObjectHandlingReplace = JsonConvert.DeserializeObject<Author>(xavierJson, new JsonSerializerSettings
            {
                ObjectCreationHandling = ObjectCreationHandling.Replace
            });
            if (xavierObjectHandlingReplace != null)
            {
                Console.WriteLine(xavierObjectHandlingReplace.courses.Count());
                Console.WriteLine(string.Join(",", xavierObjectHandlingReplace.courses));
            }
        }
    }
}
