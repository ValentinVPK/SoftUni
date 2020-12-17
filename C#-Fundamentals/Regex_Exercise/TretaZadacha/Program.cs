using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace TretaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%(?:.*)<(?<product>\w+)>(?:.*)\|(?<quantity>(?:[0-9])|(?:[1-9][0-9]+))\|(?:\D*)(?<price>(?:[0-9]+)|(?:[0-9]\.[0-9]+)|(?:[1-9][0-9]+\.[0-9]+))\$";
            double totalIncome = 0;

            string input;

            while((input = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(input)) continue;

                var validMatch = regex.Match(input);

                string customer = validMatch.Groups["customer"].Value;
                string product = validMatch.Groups["product"].Value;
                double currentIncome = (int.Parse(validMatch.Groups["quantity"].Value)) * (double.Parse(validMatch.Groups["price"].Value));

                totalIncome += currentIncome;

                Console.WriteLine($"{customer}: {product} - {currentIncome:f2}");
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
