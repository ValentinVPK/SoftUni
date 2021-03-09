using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            base.Eat(food);
            this.Weight += 0.35 * food.Quantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"Cluck");
        }
    }
}
