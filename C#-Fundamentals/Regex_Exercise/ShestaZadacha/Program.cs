using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ShestaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(?<user>([A-Za-z0-9])+(?:[.\-_A-Za-z0-9]+)*)@(?<host>[a-zA-Z]+([\.\-_][A-Za-z]+)+)(\b|(?=\s))";

            var matches = Regex.Matches(input, pattern);

            foreach(var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
