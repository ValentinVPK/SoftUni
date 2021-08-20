using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => x[0] >= 'A' && x[0] <= 'Z').ToArray();

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
