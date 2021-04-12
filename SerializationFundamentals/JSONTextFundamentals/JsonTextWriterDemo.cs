using System;
using System.IO;
using Newtonsoft.Json;

namespace JSONTextFundamentals
{
    public static class JsonTextWriterDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** JsonTextWriter Demo ***");

            var stringWriter = new StringWriter();
            var jsonTextWriter = new JsonTextWriter(stringWriter) {Formatting = Formatting.Indented};

            //try at the beginning and at the end

            jsonTextWriter.WriteStartObject();
            jsonTextWriter.WritePropertyName("name");
            jsonTextWriter.WriteValue("Xavier Morera");
            jsonTextWriter.WritePropertyName("courses");
            jsonTextWriter.WriteStartArray();
            jsonTextWriter.WriteValue("Solr");
            jsonTextWriter.WriteValue("Spark");
            jsonTextWriter.WriteEndArray();
            jsonTextWriter.WritePropertyName("since");
            jsonTextWriter.WriteValue(new DateTime(2014, 01, 14));
            jsonTextWriter.WritePropertyName("happy");
            jsonTextWriter.WriteValue(true);
            jsonTextWriter.WritePropertyName("issues");
            jsonTextWriter.WriteNull();
            jsonTextWriter.WritePropertyName("car"); // what happens if you forget this one? Exception!
            jsonTextWriter.WriteStartObject();
            jsonTextWriter.WritePropertyName("model");
            jsonTextWriter.WriteValue("Land Rover Series III");
            jsonTextWriter.WritePropertyName("year");
            jsonTextWriter.WriteValue(1976);
            jsonTextWriter.WriteEndObject();
            jsonTextWriter.WriteEndObject();
            jsonTextWriter.Flush();

            var jsonText = stringWriter.GetStringBuilder().ToString();

            Console.WriteLine(jsonText);
        }
    }
}
