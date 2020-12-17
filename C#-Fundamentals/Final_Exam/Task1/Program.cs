using System;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input;

            while((input = Console.ReadLine()) != "Sign up")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "Case":
                        string lowerOrUpper = tokens[1];
                        if (lowerOrUpper == "lower") username = username.ToLower();
                        else if (lowerOrUpper == "upper") username = username.ToUpper();
                        Console.WriteLine(username);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        if(startIndex >= 0 && endIndex >= 0 && startIndex < username.Length && endIndex < username.Length)
                        {
                            string substringToReverse = username.Substring(startIndex, endIndex - startIndex + 1);
                            StringBuilder reversed = new StringBuilder();
                            for(int i = substringToReverse.Length - 1; i >= 0; i--)
                            {
                                reversed.Append(substringToReverse[i]);
                            }
                            Console.WriteLine(reversed);
                        }

                        break;
                    case "Cut":
                        string substring = tokens[1];
                        if (username.Contains(substring))
                        {
                            int startIndexS = username.IndexOf(substring[0]);
                            username = username.Remove(startIndexS, substring.Length);
                            Console.WriteLine(username);
                        }
                        else Console.WriteLine($"The word {username} doesn't contain {substring}");
                        break;
                    case "Replace":
                        char letter = char.Parse(tokens[1]);
                        username = username.Replace(letter, '*');
                        Console.WriteLine(username);
                        break;
                    case "Check":
                        char validLetter = char.Parse(tokens[1]);
                        if (username.Contains(validLetter)) Console.WriteLine("Valid");
                        else Console.WriteLine($"Your username must contain {validLetter}.");
                        break;
                }
            }
        }
    }
}
