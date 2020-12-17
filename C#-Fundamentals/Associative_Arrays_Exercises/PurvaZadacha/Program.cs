using System;
using System.Collections.Generic;

namespace PurvaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach(char letter in input)
            {
                if (letter == ' ') continue;

                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters.Add(letter, 1);
                }
            }

            foreach(var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
