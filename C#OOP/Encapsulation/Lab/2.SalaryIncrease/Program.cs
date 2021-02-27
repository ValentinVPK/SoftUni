using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            int lines = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3])));
            }

            decimal percentage = decimal.Parse(Console.ReadLine());
            foreach (var person in people)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person);
            }
        }
    }
}
