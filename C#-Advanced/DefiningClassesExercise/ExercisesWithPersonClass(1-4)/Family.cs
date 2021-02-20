using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            Members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
           return Members.FirstOrDefault(x => x.Age == Members.Max(x => x.Age));
        }
    }
}
