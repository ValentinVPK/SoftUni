using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
            {
                base.Eat(food);
                this.Weight += 0.10 * food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Mouse)} does not eat " +
                    $"{food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
