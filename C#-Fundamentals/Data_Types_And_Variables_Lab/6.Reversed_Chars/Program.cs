using System;

namespace _6.Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.Write($"{thirdSymbol} {secondSymbol} {firstSymbol}");
        }
    }
}
