using System.IO;
using System.Threading.Tasks;

namespace JsonSamples
{
    public static class Generate
    {
        public static async Task<string> ExtendedSingleJsonAsync()
        {
            return await File.ReadAllTextAsync("AuthorExtended.json");
        }

        public static async Task<string> SmallJsonAsync()
        {
            return await File.ReadAllTextAsync("AuthorSmall.json");
        }
    }
}
