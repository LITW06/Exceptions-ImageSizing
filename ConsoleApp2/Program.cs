using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection =
                new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=PeopleEF;Integrated Security=True"))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO People VALUES (@f, @n, @a)";
                cmd.Parameters.AddWithValue("@f", Faker.Name.First());
                cmd.Parameters.AddWithValue("@n", Faker.Name.Last());
                cmd.Parameters.AddWithValue("@a", Faker.RandomNumber.Next(20, 100));
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
