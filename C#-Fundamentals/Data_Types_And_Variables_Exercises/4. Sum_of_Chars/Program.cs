using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int index = 1; index <= n; index++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}
