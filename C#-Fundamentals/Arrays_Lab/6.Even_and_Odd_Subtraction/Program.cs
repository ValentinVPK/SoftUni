using System;
using System.Linq;

namespace _6.Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            foreach (int number in arr)
            {
                if (number % 2 == 0) evenSum += number;
                else oddSum += number;
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
