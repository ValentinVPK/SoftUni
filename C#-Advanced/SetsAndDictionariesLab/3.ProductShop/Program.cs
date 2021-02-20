using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedDictionary<string, Dictionary<string, double>> markets = new SortedDictionary<string, Dictionary<string, double>>();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "Revision")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string marketName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!markets.ContainsKey(marketName))
                {
                    markets.Add(marketName, new Dictionary<string, double>());
                }

                if (!markets[marketName].ContainsKey(product))
                {
                    markets[marketName].Add(product, price);
                }
            }

            foreach (var market in markets)
            {
                Console.WriteLine($"{market.Key}->");
                foreach (var product in market.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
