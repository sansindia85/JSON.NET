using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ErrorHandlingFundamentals
{
    public static class OnErrorAttributeDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** On Error Attribute Demo ***");

            var xavier = new Author()
            {
                name = "Xavier Morera",
                courses = new string[] { "Solr", "Spark", "Jira" },
                happy = true,
                since = new DateTime(2014, 01, 15),
                car = null
            };

            var json = JsonConvert.SerializeObject(xavier, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
