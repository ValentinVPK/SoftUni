using System;
using System.Collections.Generic;
using System.Linq;

namespace ChetvurtaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, int> itemAndQuantity = new Dictionary<string, int>();
            Dictionary<string, double> itemAndPrice = new Dictionary<string, double>();

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] itemPriceQuantity = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string item = itemPriceQuantity[0];
                double price = double.Parse(itemPriceQuantity[1]);
                int quantity = int.Parse(itemPriceQuantity[2]);

                if(itemAndPrice.ContainsKey(item) && itemAndQuantity.ContainsKey(item))
                {
                    itemAndQuantity[item] += quantity;
                    itemAndPrice[item] = price;
                }
                else
                {
                    itemAndPrice.Add(item, price);
                    itemAndQuantity.Add(item, quantity);
                }
            }
            
            foreach(var item in itemAndPrice)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value * itemAndQuantity[item.Key]):f2}");
            }
        }
    }
}
