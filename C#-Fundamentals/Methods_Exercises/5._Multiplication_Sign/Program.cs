using System;

namespace _5._Multiplication_Sign
{
    class Program
    {
        public static string PositiveOrNegative(int num1, int num2, int num3)
        {
            int negativeCount = 0;
            bool isZero = false;

            if (num1 < 0)
            {
                negativeCount++;
            }
            if (num2 < 0)
            {
                negativeCount++;
            }
            if (num3 < 0)
            {
                negativeCount++;
            }

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                isZero = true;
            }

            if (isZero)
            {
                return "zero";
            }

            if (negativeCount % 2 == 1) return "negative";
            else return "positive";
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(PositiveOrNegative(num1, num2, num3));
        }
    }
}
