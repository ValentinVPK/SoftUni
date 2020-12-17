using System;
using System.Linq;

namespace _1.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                string reversed = new string(word.Reverse().ToArray());
                Console.WriteLine($"{word} = {reversed}");
            }
        }
    }
}
