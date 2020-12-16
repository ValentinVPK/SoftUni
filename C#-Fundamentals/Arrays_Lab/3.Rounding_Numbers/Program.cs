using System;

namespace _3.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
