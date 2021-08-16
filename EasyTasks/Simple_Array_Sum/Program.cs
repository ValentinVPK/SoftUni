using System;
using System.Linq;

namespace Simple_Array_Sum
{
    class Program
    {
        static int simpleArraySum(int[] inputArray)
        {
            var result = 0;
            foreach (var number in inputArray)
            {
                result += number;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = simpleArraySum(array);

            Console.WriteLine(result);
        }
    }
}
