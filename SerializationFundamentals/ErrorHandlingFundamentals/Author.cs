using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace ErrorHandlingFundamentals
{
    public class Author
    {
        public string name { get; set; }
        public string[] courses { get; set; }
        public DateTime since { get; set; }
        public bool happy { get; set; }
        public object issues { get; set; }
        public Car _car = new Car();
        public Car car
        {
            get
            {
                if (_car == null)
                {
                    // Can also use an attribute
                    throw new Exception("Car not loaded!");
                }
                return _car;
            }
            set => _car = value;
        }

        [OnError]
        internal void OnError(StreamingContext context, ErrorContext errorContext)
        {
            var currentError = errorContext.Error.Message;
            Console.WriteLine("Manage an error in .NET object: {0}", currentError);
            errorContext.Handled = true;
        }

        // These attributes are no longer needed

        //public List<Author> favoriteAuthors { get; set; }

        //public AuthorRelationship authorRelationship { get; set; }
    }
}
