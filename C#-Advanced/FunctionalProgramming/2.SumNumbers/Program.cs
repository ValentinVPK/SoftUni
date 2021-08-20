using System;
using System.Linq;

namespace _2.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            int[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Sum());
        }
    }
}
