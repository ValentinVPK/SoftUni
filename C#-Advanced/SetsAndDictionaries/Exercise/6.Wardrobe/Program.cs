using System;
using System.Collections.Generic;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];
                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());
                }
                string[] clothes = tokens[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach(string clothing in clothes)
                {
                    if (!colors[color].ContainsKey(clothing))
                    {
                        colors[color].Add(clothing, 0);
                    }

                    colors[color][clothing]++;
                }
            }

            string[] input = Console.ReadLine().Split();
            foreach(var color in colors)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach(var clothing in color.Value)
                {
                    if(color.Key == input[0] && clothing.Key == input[1])
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
