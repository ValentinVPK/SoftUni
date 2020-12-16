using System;

namespace _15.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int index = word.Length - 1; index >= 0; index--)
            {
                Console.Write(word[index]);
            }
        }
    }
}
