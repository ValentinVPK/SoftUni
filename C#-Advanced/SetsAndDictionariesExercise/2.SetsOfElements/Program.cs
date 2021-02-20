using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for(int i = 0; i < input[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for(int i = 0; i < input[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int number in set1)
            {
                if (set2.Contains(number)) Console.Write(number + " ");
            }
        }
    }
}
