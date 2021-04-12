using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AttributesDemo
{
    public class AuthorJsonExtension
    {
        public string author { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> unMappedFields;
    }
}
