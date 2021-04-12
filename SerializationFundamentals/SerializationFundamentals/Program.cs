using System.Threading.Tasks;

namespace SerializationFundamentals
{
    class Program
    {
        static async Task Main()
        {
            //Demo: Mapping JSON to and from.NET with JsonConvert.
            await SerializeDeserializeDemo.Show();

            //By default : When you serialize a class, JSON.Net serialized object by value.
            //Uses $id for value and $ref for reference.
            ObjectReferencesDemo.Show();

            //Add properties dynamically
            DynamicDemo.Show();

            //Serializing different types of objects
            await SerializeObjectsDemo.ShowAsync();

            //Deserializing Different Types of Objects
            await DeserializeObjectsDemo.ShowAsync();
        }
    }
}
