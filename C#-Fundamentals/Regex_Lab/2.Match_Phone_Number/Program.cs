using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(-| )2\1[0-9]{3}\1[0-9]{4}\b";
            string text = Console.ReadLine();

            var matches = Regex.Matches(text, pattern)
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
