using System;

namespace AttributesDemo
{
    /// <summary>
    /// Deserialize uses the constructor with the JsonConstructor attribute
    /// </summary>
    public class AuthorConstructorAttribute
    {
        public AuthorConstructorAttribute()
        {
            author = "Xavier Morera in Constructor";
            happy = false;
        }

        [Newtonsoft.Json.JsonConstructor]
        AuthorConstructorAttribute(string authorName)
        {
            author = authorName;
            happy = true;
        }

        public string author { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }
    }
}
