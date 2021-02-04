using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(arr);
            List<int> evenNumbers = new List<int>();

            while(queue.Count > 0)
            {
                int currElement = queue.Dequeue();
                if (currElement % 2 == 0)
                {
                    evenNumbers.Add(currElement);
                }             
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
