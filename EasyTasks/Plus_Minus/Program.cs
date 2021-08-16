using System;
using System.Linq;

namespace Plus_Minus
{
    class Program
    {
        static void plusMinus(int[] inputArray)
        {
            int positive = 0;
            int negative = 0;
            int zeros = 0;
            foreach (var number in inputArray)
            {
                if (number > 0) positive++;
                else if (number == 0) zeros++;
                else negative++;
            }


            Console.WriteLine($"{((positive * 1.0) / inputArray.Length):f6}");
            Console.WriteLine($"{((negative * 1.0) / inputArray.Length):f6}");
            Console.WriteLine($"{((zeros * 1.0) / inputArray.Length):f6}");
        }
        static void Main(string[] args)
        {
            var size = Console.ReadLine();

            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            plusMinus(arr);
        }
    }
}
