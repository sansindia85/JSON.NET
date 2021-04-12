using JsonSamples;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationFundamentals
{
    public static class SerializeDeserializeDemo
    {
        public static async Task Show()
        {
            var jsonSample = await Generate.SingleJsonAsync();

            Console.WriteLine("Step 1: Output JSON");
            Console.WriteLine(jsonSample);

            Console.WriteLine(Environment.NewLine + "Step 2: Output property Author.Name from deserialized class");
            var xavierAuthor = JsonConvert.DeserializeObject<Author>(jsonSample);
            Console.WriteLine(xavierAuthor?.name);

            Console.WriteLine(Environment.NewLine + "Step 3: Output serialized Author class");
            var xavierJsonSerialized = JsonConvert.SerializeObject(xavierAuthor);
            Console.WriteLine(xavierJsonSerialized);

            Console.WriteLine(Environment.NewLine + "Step 4: Output serialized Author class with indentation");
            var xavierJsonSerializedIndented = JsonConvert.SerializeObject(xavierAuthor, Formatting.Indented);
            Console.WriteLine(xavierJsonSerializedIndented);
        }
    }
}
