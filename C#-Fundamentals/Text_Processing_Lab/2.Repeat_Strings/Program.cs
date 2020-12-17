using System;
using System.Linq;

namespace _2.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            foreach (string word in words)
            {
                for (int i = 1; i <= word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
