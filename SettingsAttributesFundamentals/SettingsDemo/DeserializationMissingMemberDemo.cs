using System;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class DeserializationMissingMemberDemo
    {
        public static async Task ShowAsync()
        {
            Console.Clear();
            Console.WriteLine("*** Deserialization Missing Member ***");

            // Extended contains a value called dance
            // But there is no dance property in the Author class 
            var xavierJsonExtraNameValue = await Generate.ExtendedSingleJsonAsync();

            // Deserialize without providing any settings
            Console.WriteLine("Deserialize with no settings specified");

            var xavierNoSetting = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue);

            Console.WriteLine(xavierNoSetting?.name);
            //Check value of 'happy' and 'dance'
            // By default, Json.NET ignores a JSON member if there is no field or property for its value to be set to during deserialization.

            // Deserialize with Ignore setting
            Console.WriteLine("Deserialize with MissingMemberHandling.Ignore");
            var jsonSettingsIgnore = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            var xavierWithSettingIgnore = JsonConvert.DeserializeObject<Author>(
                xavierJsonExtraNameValue,
                jsonSettingsIgnore
            );

            Console.WriteLine(xavierWithSettingIgnore?.name);

            // Deserialize with Error setting
            // Json.NET raises an exception when there is a missing member during deserialization
            try
            {
                Console.WriteLine("Deserialize with MissingMemberHandling.Error");
                var jsonSettingsError = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    MissingMemberHandling = MissingMemberHandling.Error
                };
                var xavierWithSettingError = JsonConvert.DeserializeObject<Author>(
                    xavierJsonExtraNameValue,
                    jsonSettingsError
                );
                Console.WriteLine(xavierWithSettingError?.name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
