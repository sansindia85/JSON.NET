using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace JsonSamples
{
    public static class Generate
    {
        public static async Task<string> SingleJsonAsync()
        {
            return await File.ReadAllTextAsync("AuthorSingle.json");
        }

        public static DataSet CoursesDataSet()
        {
            var dataSet = new DataSet("Courses");
            //dataSet.Namespace = "NetFrameWork";
            var table = new DataTable();
            var idColumn = new DataColumn("id", typeof(int))
            {
                AutoIncrement = true
            };

            var itemColumn = new DataColumn("name", typeof(string));
            table.Columns.Add(idColumn);
            table.Columns.Add(itemColumn);
            dataSet.Tables.Add(table);

            var courses = new[] { "Solr", "Spark", "Jira" };

            foreach (var course in courses)
            {
                var newRow = table.NewRow();
                newRow["name"] = course;
                table.Rows.Add(newRow);
            }

            dataSet.AcceptChanges();

            return dataSet;
        }

        public static async Task<string> DatesJsonAsync()
        {
            return await File.ReadAllTextAsync("AuthorDates.json");
        }
    }
}
