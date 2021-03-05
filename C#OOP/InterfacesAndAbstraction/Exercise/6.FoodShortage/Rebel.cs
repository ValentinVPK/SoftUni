using System;
using System.Collections.Generic;
using System.Text;

namespace _6.FoodShortage
{
    public class Rebel : IBuyer, INameable, IAge
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }
        public int Food { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
