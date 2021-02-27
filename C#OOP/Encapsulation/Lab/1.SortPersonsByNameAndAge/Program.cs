using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(tokens[0], tokens[1], int.Parse(tokens[2])));
            }

            foreach(var person in people.OrderBy(p => p.FirstName).ThenBy(p => p.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
}
