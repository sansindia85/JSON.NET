using System;
using System.Collections.Generic;

namespace SettingsDemo
{
    public class Author
    {
        // This is for Object Creation Handling
        public Author()
        {
            courses = new List<string> { "course 1", "course 2", "course 3" };
        }

        public string name { get; set; }

        public List<string> courses { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }

        public object issues { get; set; }

        public List<Author> favoriteAuthors { get; set; }

        public Car car { get; set; }
    }
}
