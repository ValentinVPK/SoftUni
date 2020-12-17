using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(.+)>(?<numbers>\d{3})\|(?<lcLetters>[a-z]{3})\|(?<ucLetters>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1";
            for(int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                if (Regex.IsMatch(password, pattern))
                {
                    Match match = Regex.Match(password, pattern);
                    string validPassword = match.Groups["numbers"].Value + match.Groups["lcLetters"].Value + match.Groups["ucLetters"].Value + match.Groups["symbols"].Value;
                    Console.WriteLine($"Password: {validPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
