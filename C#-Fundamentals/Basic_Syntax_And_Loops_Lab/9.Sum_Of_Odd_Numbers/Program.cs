using System;

namespace _9.Sum_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
            }
            Console.Write($"Sum: {sum}");
        }
    }
}
