using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace PurvaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string pattern = @">>(?<name>\w+)<<(?<price>[0-9]+\.?[0-9]+)!(?<quantity>[0-9]+)\b";
            List<string> allProducts = new List<string>();
            double moneySpend = 0;

            while((input = Console.ReadLine()) != "Purchase")
            {
                var regex = new Regex(pattern);

                if (!regex.IsMatch(input)) continue;

                Match match = regex.Match(input);

                allProducts.Add(match.Groups["name"].Value);
                moneySpend += (double.Parse(match.Groups["price"].Value)) * (int.Parse(match.Groups["quantity"].Value));
            }

            Console.WriteLine("Bought furniture:");

            foreach(string product in allProducts)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
