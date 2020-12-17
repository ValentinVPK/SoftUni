using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace _10.Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> children = new List<string>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder decryptedMessage = new StringBuilder();
                string pattern = @"@(?<name>[A-Za-z]+)[^@\-!>:]+(?<behaviour>![GN]!)";
                foreach (char ch in input)
                {
                    decryptedMessage.Append((char)(ch - key));
                }

                if (Regex.IsMatch(decryptedMessage.ToString(), pattern))
                {
                    Match match = Regex.Match(decryptedMessage.ToString(), pattern);
                    if (match.Groups["behaviour"].Value == "!G!")
                    {
                        children.Add(match.Groups["name"].Value);
                    }
                }
            }

            foreach (string child in children)
            {
                Console.WriteLine(child);
            }
        }
    }
}
