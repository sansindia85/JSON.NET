using System.Collections.Generic;
using Newtonsoft.Json;

namespace AttributesDemo
{
    [JsonObject]
    public class AuthorJsonObject : Author
    {
        public AuthorJsonObject()
        {
            courses = new List<Course>();
        }
    }
}
