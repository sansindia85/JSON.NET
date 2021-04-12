using System;

namespace AttributesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // JsonObjectAttribute, JsonArrayAttribute, JsonDictionaryAttribute
            //JsonArray is the default attribute used by NewtonSoft.JSON
            JsonAttributesDemo.Show();

            // JsonObject, JsonProperty, NonSerialized, JsonIgnoreAttribute
            JsonOptInOptOutDemo.Show();

            // JsonPropertyAttribute
            JsonPropertyAttributeDemo.Show();

            // JsonConverterAttribute 
            JsonConverterAttributeDemo.Show();

            // JsonConstructorAttribute : Specify which constructor should be used during deserialization
            JsonConstructorAttribute.Show();

            // JsonExtensionDataAttribute
            JsonExtensionDataAttributeDemo.Show();
        }
    }
}
