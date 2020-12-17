using System;
using System.Linq;

namespace _5.Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] evenLengthWords = words.Where(w => w.Length % 2 == 0).ToArray();

            foreach (string word in evenLengthWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
