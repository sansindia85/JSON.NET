using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ErrorHandlingFundamentals
{
    public static class HandleConversionErrorsDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** Conversion Errors with Delegate ***");

            var jsonDates = await Generate.DatesJsonAsync();

            var settings = new JsonSerializerSettings
            {
                Error = HandleDeserializationError,
                Converters = { new IsoDateTimeConverter() }
            };

            List<DateTime> deserializedDates;
            deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>(jsonDates, settings);

            Console.WriteLine("Dates:");
            if (deserializedDates != null)
                foreach (DateTime date in deserializedDates)
                {
                    Console.WriteLine(date.ToShortDateString());
                }
        }

        private static void HandleDeserializationError(object sender, ErrorEventArgs errorEventArgs)
        {
            var currentError = errorEventArgs.ErrorContext.Error.Message;
            Console.WriteLine(currentError);
            errorEventArgs.ErrorContext.Handled = true;
        }
    }
}
