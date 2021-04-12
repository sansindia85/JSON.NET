using JsonSamples;
using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONTextFundamentals
{
    public static class JsonTextReaderDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** JsonTextReader Demo ***");
            var jsonSample = await Generate.SingleJsonAsync();

            var jsonReader = new JsonTextReader(new StringReader(jsonSample));

            while (await jsonReader.ReadAsync())
            {
                if (jsonReader.Value != null)
                    Console.WriteLine($"Token: {jsonReader.TokenType}, Value: {jsonReader.Value}");
                else
                    Console.WriteLine($"Token: {jsonReader.TokenType}");
            }
        }
    }
}
