using System;
using System.Linq;

namespace Very_Big_Sum
{
    class Program
    {
        static long aVeryBigSum(int[] inputArray)
        {
            long result = 0;
            foreach (var number in inputArray)
            {
                result += number;
            }

            return result;
        }
        static void Main(string[] args)
        {
            var size = Console.ReadLine();
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(aVeryBigSum(arr));
        }
    }
}
