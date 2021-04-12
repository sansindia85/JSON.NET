using System;
using Newtonsoft.Json;

namespace SettingsDemo
{
    public static class MetadataHandlingDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Metadata Handling ***");

            // Default metadata handling
            var xavierAuthor = @"{ 'name': 'Xavier Morera', 
                '$type': 'SettingsDemo.Author, SettingsDemo'}";

            var xavierObjectNoSetting = JsonConvert.DeserializeObject(xavierAuthor);
            if (xavierObjectNoSetting != null)
                Console.WriteLine("- xavierObjectNoSetting is of type "
                                  + xavierObjectNoSetting.GetType());

            // Read all metadata properties first before deserializing
            var xavierWithMetadataReadAhead = JsonConvert.DeserializeObject(xavierAuthor, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                // $type no longer needs to be first
                MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead
            });
            if (xavierWithMetadataReadAhead != null)
                Console.WriteLine("- xavierWithMetadataReadAhead is of type "
                                  + xavierWithMetadataReadAhead.GetType());
        }
    }
}
