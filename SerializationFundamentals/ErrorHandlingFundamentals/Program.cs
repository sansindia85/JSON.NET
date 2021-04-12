using System.Threading.Tasks;

namespace ErrorHandlingFundamentals
{
    class Program
    {
        static async Task Main()
        {
            await DeserializeDemo.ShowAsync();
            await ConversionErrorsDemo.ShowAsync();
            await HandleConversionErrorsDemo.ShowAsync();
            OnErrorAttributeDemo.Show();
        }
    }
}
