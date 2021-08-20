using System;
using System.Linq;

namespace _1.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(", ", arr.Where(n => n % 2 == 0).OrderBy(n => n)));
        }
    }
}
