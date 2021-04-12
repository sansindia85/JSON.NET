using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONDates
{
    public static class JsonDatesDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Dates demo ***");

            var dates = new List<DateTime>() {
                new(2009, 07, 11, 23, 00, 00),
                new(2020, 01, 15),
                new(637143211000000000)
            };

            Console.WriteLine("- Serialize object without specifying any date format (default)");
            var dateDefault = JsonConvert.SerializeObject(dates, Formatting.Indented);
            Console.WriteLine(dateDefault);

            // From Json.NET 4.5 and onwards dates are written using the ISO 8601            
            Console.WriteLine("- Serialize object specifying to use Iso DateTime converter");
            string dateIso8601 = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                new IsoDateTimeConverter()
            );
            Console.WriteLine(dateIso8601);

            //Microsoft date format
            Console.WriteLine("- Serialize object specifying Microsoft Date - Default pre .NET 4.5");
            var settingsMicrosoftDate = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            var dateMicrosoftOldDefault = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                settingsMicrosoftDate
            );
            Console.WriteLine(dateMicrosoftOldDefault);

            //Serialize object specifying custom date format
            Console.WriteLine("- Serialize object specifying custom date format");
            var settingsCustomDate = new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy"
            };

            var dateCustom = JsonConvert.SerializeObject(dates, Formatting.Indented, settingsCustomDate);
            Console.WriteLine(dateCustom);

            Console.WriteLine("- Serialize object specifying to use the JavaScript DateTime converter");
            var dateJavaScript = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                new JavaScriptDateTimeConverter()
            );
            Console.WriteLine(dateJavaScript);

            Console.WriteLine("- Serialize object specifying to use the UnixDateTimeConverter DateTime converter");
            var dateUnixDateTimeConverter = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                new UnixDateTimeConverter()
            );
            Console.WriteLine(dateUnixDateTimeConverter);
        }
    }
}
