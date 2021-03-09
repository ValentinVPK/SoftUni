using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                base.Eat(food);
                this.Weight += 0.40 * food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Dog)} does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
