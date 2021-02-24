using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach(string word in words)
            {
                wordsCount.Add(word, 0);
            }

            string[] lines = File.ReadAllLines("../../../text.txt");

            foreach(string line in lines)
            {
                string[] currLine = line.Split(new char[] { '.', '?', '!', '-', ' ', ',' });
                foreach(string word in currLine)
                {
                    if (wordsCount.ContainsKey(word.ToLower())) wordsCount[word.ToLower()]++;
                }
            }

            StringBuilder result1 = new StringBuilder();
            StringBuilder result2 = new StringBuilder();

            foreach (var word in wordsCount)
            {
                result1.AppendLine($"{word.Key} - {word.Value}");
            }

            File.WriteAllText("../../../actualResult.txt", result1.ToString());

            foreach(var word in wordsCount.OrderByDescending(w => w.Value))
            {
                result2.AppendLine($"{word.Key} - {word.Value}");
            }

            File.WriteAllText("../../../expectedResult.txt", result2.ToString());
        }
    }
}
