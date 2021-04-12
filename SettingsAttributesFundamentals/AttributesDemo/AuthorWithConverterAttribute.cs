using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AttributesDemo
{
    public class AuthorWithConverterAttribute
    {
        public string author { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Relationship relationship { get; set; }

        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime since { get; set; }
    }
}
