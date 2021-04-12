using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttributesDemo
{
    [JsonArray]
    public class AuthorJsonArray : Author
    {
        public AuthorJsonArray()
        {
            courses = new List<Course>();
        }
    }
}
