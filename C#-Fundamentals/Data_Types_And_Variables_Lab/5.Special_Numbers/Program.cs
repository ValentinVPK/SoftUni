using System;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int index = 1; index <= n; index++)
            {

                int sumOfDigits = 0;
                int digits = index;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{index} -> True");
                }
                else Console.WriteLine($"{index} -> False");

            }
        }
    }
}
