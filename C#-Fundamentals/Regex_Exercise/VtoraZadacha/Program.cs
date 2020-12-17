using System;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace VtoraZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> allParticipants = new Dictionary<string, int>();
            string[] inputNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input;

            while((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder name = new StringBuilder();
                int kilometersRan = 0;
                foreach(char ch in input)
                {
                    if (char.IsLetter(ch)) name.Append(ch);
                    else if (char.IsDigit(ch)) kilometersRan += (ch - '0');
                }

                if (!inputNames.Contains(name.ToString())) continue;

                if (allParticipants.ContainsKey(name.ToString()))
                {
                    allParticipants[name.ToString()] += kilometersRan;
                }
                else
                {
                    allParticipants.Add(name.ToString(), kilometersRan);
                }
            }

            int place = 1;
            foreach(var particiant in allParticipants.OrderByDescending(p => p.Value))
            {
                switch (place)
                {
                    case 1:
                        Console.WriteLine($"1st place: {particiant.Key}");
                        place++;
                        break;
                    case 2:
                        Console.WriteLine($"2nd place: {particiant.Key}");
                        place++;
                        break;
                    case 3:
                        Console.WriteLine($"3rd place: {particiant.Key}");
                        place++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
