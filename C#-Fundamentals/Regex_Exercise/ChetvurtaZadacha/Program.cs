using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace ChetvurtaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"@(?<planet>[A-Za-z]+)(?:[^@\-!:>])*:(?<population>\d+)(?:[^@\-!:>])*!(?<AorD>A|D)!(?:[^@\-!:>])*->(?<soldiers>\d+)";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                StringBuilder decryptedMessage = new StringBuilder();
                int count = 0;

                foreach(char ch in input)
                {
                    if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r' || ch == 'S' || ch == 'T' || ch == 'A' || ch == 'R') count++;
                }

                for(int j = 0; j < input.Length; j++)
                {
                    decryptedMessage.Append((char)(input[j] - count));
                }

                input = decryptedMessage.ToString();

                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(input)) continue;

                Match matchedPlanet = regex.Match(input);

                if (matchedPlanet.Groups["AorD"].Value == "A") attackedPlanets.Add(matchedPlanet.Groups["planet"].Value);
                else if (matchedPlanet.Groups["AorD"].Value == "D") destroyedPlanets.Add(matchedPlanet.Groups["planet"].Value);
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count != 0)
            {
                foreach(string planet in attackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count != 0)
            {
                foreach (string planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
