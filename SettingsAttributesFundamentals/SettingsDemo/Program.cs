using System.Threading.Tasks;

namespace SettingsDemo
{
    class Program
    {
        static async Task Main()
        {
            //MissingMemberHandling controls how missing members are handled during deserialization
            await DeserializationMissingMemberDemo.ShowAsync();

            //Controls serialization when circular references are present
            SerializationCircularReferencesDemo.Show();

            // NullValueHandling
            SerializationNullValueHandlingDemo.Show();

            // DefaultValueHandling : Controls how Json.NET uses default values using the .NET DefaultValueAttribute 
            // when serializing and deserializing
            DefaultValueHandlingDemo.Show();

            //controls how objects are created and deserialized to during deserialization.
            await ObjectCreationHandlingDemo.ShowAsync();

            TypeNameHandlingDemo.Show();

            //Controls how type names are written during serialization. Includes Assembly versions
            TypeNameAssemblyFormatHandlingDemo.Show();

            // SerializationBinder 
            BinderDemo.Show();

            // SerializationBinder 
            BinderDemo.Show();

            // MetadataPropertyHandling. Default type: Newtonsoft.Json.Linq.JObject
            //Affects performance if we use MetadataPropertyHandling.ReadAhead
            MetadataHandlingDemo.Show();

            // ConstructorHandling : Specifies how constructors are used when initializing objects during deserialization
            ConstructorHandlingDemo.Show();

        }
    }
}
