using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int index = 1; index <= number; index++)
            {
                bool isSpecial;
                int digit = index;
                int sum = 0;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", index, isSpecial);
                sum = 0;
            }
        }
    }
}
