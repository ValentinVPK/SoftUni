using System;
using System.Text.RegularExpressions;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b";
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, pattern);

            Console.WriteLine(string.Join(' ', matches));
        }
    }
}
