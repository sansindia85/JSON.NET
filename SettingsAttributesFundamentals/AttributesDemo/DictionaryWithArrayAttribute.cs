using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttributesDemo
{
    [JsonArray]
    public class DictionaryWithArrayAttribute<K, V> : Dictionary<K, V>
    {
        public string Name { get; set; }
    }
}
