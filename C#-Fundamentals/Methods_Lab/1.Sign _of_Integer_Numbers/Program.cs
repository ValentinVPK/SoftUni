using System;

namespace _1.Sign__of_Integer_Numbers
{
    class Program
    {
        static void Sign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
            }
        }
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Sign(inputNumber);
        }

    }
}
