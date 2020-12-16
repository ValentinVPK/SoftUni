using System;

namespace _4.Printing_Triangle
{
    class Program
    {
        static void Triangle(int number)
        {
            // upper part

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            // lower part

            for (int row = number - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Triangle(number);
        }
    }
}
