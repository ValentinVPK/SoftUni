using System;

namespace _4.Print_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingNumber = int.Parse(Console.ReadLine());
            var endingNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
