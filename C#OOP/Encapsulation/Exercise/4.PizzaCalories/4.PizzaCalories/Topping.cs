using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                var valueAsLower = value.ToLower();
                if(valueAsLower != "meat" &&
                    valueAsLower != "veggies" && 
                    valueAsLower != "cheese" &&
                    valueAsLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.name = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(MinWeight, MaxWeight, value, $"{this.Name} weight should be in the range [{MinWeight}..{MaxWeight}].");

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double modifer = GetModifier();

            return 2 * this.Weight * modifer;
        }

        private double GetModifier()
        {
            var nameAsLower = this.Name.ToLower();

            if(nameAsLower == "meat")
            {
                return 1.2;
            }
            if (nameAsLower == "veggies")
            {
                return 0.8;
            }
            if (nameAsLower == "cheese")
            {
                return 1.1;
            }

            return 0.9;
        }
    }
}
