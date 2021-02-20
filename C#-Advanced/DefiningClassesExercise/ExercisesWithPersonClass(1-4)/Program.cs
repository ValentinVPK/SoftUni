using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            /* 3th exercise:
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Person currPerson = new Person(tokens[0], int.Parse(tokens[1]));
                family.AddMember(currPerson);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            */



            // 4th exercise

            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                people.Add(new Person(tokens[0], int.Parse(tokens[1])));
            }

            foreach(Person person in people.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
