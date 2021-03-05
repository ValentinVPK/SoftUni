using System;
using System.Collections.Generic;
using System.Text;

namespace _6.FoodShortage
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
