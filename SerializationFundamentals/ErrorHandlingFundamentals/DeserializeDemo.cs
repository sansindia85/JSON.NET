using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;

namespace ErrorHandlingFundamentals
{
    class DeserializeDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** Deserialize Error ***");

            var jsonDates = await Generate.DatesJsonAsync();

            try
            {
                var deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>(jsonDates);
                Console.WriteLine(deserializedDates?.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to deserialize object: " + ex.Message);
            }
        }
        
    }
}
