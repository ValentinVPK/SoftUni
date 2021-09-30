using Microsoft.Data.SqlClient;
using System;

namespace CSharpDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.;Integrated Security=true;Database=SoftUni";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "UPDATE Employees SET Salary = Salary + 0.12 " +
                    "WHERE FirstName LIKE 'N%'";

                string query2 = "SELECT COUNT(*) FROM Employees";

                string query3 = "SELECT FirstName, LastName FROM Employees ORDER BY [FirstName]";

                SqlCommand command = new SqlCommand(query3, connection);

                //var rowsAffected = command.ExecuteNonQuery(); // For query1

                //var result = (int)command.ExecuteScalar(); // For query2
                //Console.WriteLine(result);

                //SQL reader demo

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["FirstName"]);
                    }
                } // For query3
            }          
        }
    }
}
