using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight,string livingRegion, 
            string breed) 
            : base(name, weight,livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                base.Eat(food);
                this.Weight += 0.30 * food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Cat)} does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
