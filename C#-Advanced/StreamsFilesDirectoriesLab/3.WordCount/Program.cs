using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            using (StreamReader wordsReader = new StreamReader("../../../words.txt"))
            {
                string[] wordsArr = wordsReader.ReadToEnd().Split();
                for(int i = 0; i < wordsArr.Length; i++)
                {
                    wordsCount.Add(wordsArr[i], 0);
                }
            }
            using (StreamReader inputReader = new StreamReader("../../../input.txt"))
            {
                string currLine = inputReader.ReadLine();
                while(currLine != null)
                {
                    string[] currLineArr = currLine.Split(new char[] {'-', ' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < currLineArr.Length; i++)
                    {
                        if (wordsCount.ContainsKey(currLineArr[i].ToLower()))
                        {
                            wordsCount[currLineArr[i].ToLower()]++;
                        }
                    }

                    currLine = inputReader.ReadLine();
                }
            }

            using(StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                foreach(var word in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
