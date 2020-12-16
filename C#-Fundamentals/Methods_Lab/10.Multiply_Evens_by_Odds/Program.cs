using System;

namespace _10.Multiply_Evens_by_Odds
{
    class Program
    {
        public static int GetSumOfEvenDigits(string number)
        {
            int sum = 0;
            foreach (char digitChar in number)
            {
                int digit = digitChar - '0';
                if (digit % 2 == 0)
                {
                    sum += Math.Abs(digit);
                }
            }
            return sum;
        }

        public static int GetSumOfOddDigits(string number)
        {
            int sum = 0;
            foreach (int digitChar in number)
            {
                int digit = digitChar - '0';
                if (digit % 2 == 1)
                {
                    sum += Math.Abs(digit);
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            Console.WriteLine(result);
        }
    }
}
