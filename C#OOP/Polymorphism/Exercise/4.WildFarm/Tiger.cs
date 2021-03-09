using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, 
            string breed) 
            : base(name, weight,livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                base.Eat(food);
                this.Weight += 1.0 * food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Tiger)} does not eat " +
                    $"{food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
