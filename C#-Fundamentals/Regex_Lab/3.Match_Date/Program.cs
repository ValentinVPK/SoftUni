using System;
using System.Text.RegularExpressions;

namespace _3.Match_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>(?:0[1-9])|(?:[1-2][0-9])|(?:3[0-2]))(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            string text = Console.ReadLine();

            var dates = Regex.Matches(text, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
