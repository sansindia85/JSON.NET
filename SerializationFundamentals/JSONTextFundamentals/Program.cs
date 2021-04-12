using System.Threading.Tasks;

namespace JSONTextFundamentals
{
    class Program
    {
        static async Task Main()
        {
            //JSONSerializer and JSONConvert uses reflection to use JSONText to convert .Net Classes
            await JsonSerializerDemo.ShowAsync();

            //Provides fastest way and does not use reflection
            await JsonTextReaderDemo.ShowAsync();

            JsonTextWriterDemo.Show();
        }
    }
}
