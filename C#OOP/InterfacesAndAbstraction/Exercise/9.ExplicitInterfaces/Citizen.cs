using System;
using System.Collections.Generic;
using System.Text;

namespace _9.ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }
        public string Name { get; }
        public int Age { get; }
        public string Country { get; }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }

        string IResident.GetName()
        {
           return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
