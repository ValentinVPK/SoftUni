using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public virtual void ProduceSound()
        {
            Console.WriteLine();
        }

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
    }
}
