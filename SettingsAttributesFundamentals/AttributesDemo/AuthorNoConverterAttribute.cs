using System;

namespace AttributesDemo
{
    public class AuthorNoConverterAttribute
    {
        public string author { get; set; }

        public Relationship relationship { get; set; }

        public DateTime since { get; set; }
    }

    public enum Relationship
    {
        EmployeeAuthor,
        IndependentAuthor
    }
}
