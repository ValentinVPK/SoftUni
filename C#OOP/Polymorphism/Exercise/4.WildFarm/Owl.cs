using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            :base(name,weight,wingSize)
        {

        }
        public override void Eat(Food food)
        {
            if(food.GetType().Name == "Meat")
            {
                base.Eat(food);
                this.Weight += 0.25 * food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Owl)} does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"Hoot Hoot");
        }
    }
}
