using System;
using System.Collections.Generic;


namespace _4.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsDic = new Dictionary<string, Dictionary<string, List<string>>>();

            for(int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continentsDic.ContainsKey(continent))
                {
                    continentsDic.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsDic[continent].ContainsKey(country))
                {
                    continentsDic[continent].Add(country, new List<string>());
                }

                continentsDic[continent][country].Add(city);
            }

            foreach(var continent in continentsDic)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"    {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
