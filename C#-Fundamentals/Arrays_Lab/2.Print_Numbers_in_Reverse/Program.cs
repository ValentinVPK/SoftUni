using System;

namespace _2.Print_Numbers_in_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                Console.Write("{0} ", numbers[j]);
            }
        }
    }
}
