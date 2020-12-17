using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _8.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\D+[0-9]+";
            var matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                StringBuilder currentNumber = new StringBuilder();
                StringBuilder currentString = new StringBuilder();
                foreach (char ch in match.Value)
                {
                    if (char.IsLetter(ch))
                    {
                        currentString.Append(char.ToUpper(ch));
                    }
                    else if (char.IsDigit(ch)) currentNumber.Append(ch);
                    else
                    {
                        currentString.Append(ch);
                    }
                }
                for (int i = 0; i < int.Parse(currentNumber.ToString()); i++)
                {
                    result.Append(currentString);
                }
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
