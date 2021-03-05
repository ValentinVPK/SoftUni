using System;
using System.Collections.Generic;
using System.Text;

namespace _5.BirthdayCelebrations
{
    public class Pet : INameable, IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
