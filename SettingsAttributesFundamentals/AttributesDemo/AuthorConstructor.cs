using System;

namespace AttributesDemo
{
    public class AuthorConstructor
    {
        public AuthorConstructor()
        {
            author = "Xavier Morera In Constructor";
            happy = false;
        }

        AuthorConstructor(string authorName)
        {
            author = authorName;
            happy = true;
        }

        public string author { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }
    }
}
