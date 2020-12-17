using System;
using System.Linq;

namespace _4.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sorted = arr.OrderByDescending(n => n)
                .ToArray();

            for (int i = 0; i < 3; i++)
            {
                if (i >= sorted.Length) break;

                Console.Write($"{sorted[i]} ");
            }
        }
    }
}
