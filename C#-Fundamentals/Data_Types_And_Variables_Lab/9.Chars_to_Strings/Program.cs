using System;

namespace _9.Chars_to_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            string result = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString();
            Console.WriteLine(result);
        }
    }
}
