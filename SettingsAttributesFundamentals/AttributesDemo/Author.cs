using System.Collections;
using System.Collections.Generic;

namespace AttributesDemo
{
    public class Author : IEnumerable<Course>
    {
        public List<Course> courses { get; set; }

        public Author()
        {
            courses = new List<Course>();
        }
        public IEnumerator<Course> GetEnumerator()
        {
            return courses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
