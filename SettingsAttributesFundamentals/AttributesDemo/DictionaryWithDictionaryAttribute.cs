using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttributesDemo
{
    [JsonDictionary]
    public class DictionaryWithDictionaryAttribute<K, V> : Dictionary<K, V>
    {
        public string Name { get; set; }
    }
}
