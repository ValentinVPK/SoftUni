using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Oldest_Family_Member
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestPerson(List<Person> members)
        {
            Person oldestMember = Members.OrderByDescending(x => x.Age).First();
            return oldestMember;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 1; i <= numberOfMembers; i++)
            {
                string[] personNameAndAge = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person currentMember = new Person(personNameAndAge[0], int.Parse(personNameAndAge[1]));
                family.AddMember(currentMember);
            }

            Person oldestMember = family.GetOldestPerson(family.Members);

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
