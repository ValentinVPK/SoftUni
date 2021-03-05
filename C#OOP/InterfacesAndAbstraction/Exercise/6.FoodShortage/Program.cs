using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.FoodShortage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> foodBuyers = new Dictionary<string, IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if(tokens.Length == 4)
                {
                    foodBuyers.Add(tokens[0], new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if(tokens.Length == 3)
                {
                    foodBuyers.Add(tokens[0], new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            string input;

            while((input = Console.ReadLine()) != "End")
            {
                if (foodBuyers.ContainsKey(input))
                {
                    foodBuyers[input].BuyFood();              
                }
            }

            Console.WriteLine(foodBuyers.Sum(b => b.Value.Food));
        }
    }
}
