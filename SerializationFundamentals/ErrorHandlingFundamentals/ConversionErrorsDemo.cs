using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ErrorHandlingFundamentals
{
    public static class ConversionErrorsDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** Conversion Errors with Delegate ***");

            var jsonDates = await Generate.DatesJsonAsync();

            var errors = new List<string>();

            var settings = new JsonSerializerSettings
            {
                Error = delegate(object _, ErrorEventArgs errorArgs)
                {
                    errors.Add(errorArgs.ErrorContext.Error.Message);
                    errorArgs.ErrorContext.Handled = true;
                },
                Converters = {new IsoDateTimeConverter()}
            };

            var deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>
                (jsonDates, settings);

            Console.WriteLine("Dates:");
            if (deserializedDates != null)
                foreach (var date in deserializedDates)
                {
                    Console.WriteLine(date.ToShortDateString());
                }

            Console.WriteLine("Errors:");
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
