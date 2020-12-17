using System;
using System.Collections.Generic;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordToLowerCase = word.ToLower();
                if (counts.ContainsKey(wordToLowerCase))
                {
                    counts[wordToLowerCase]++;
                }
                else
                {
                    counts.Add(wordToLowerCase, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
