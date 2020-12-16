using System;

namespace _13.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibNumber = int.Parse(Console.ReadLine());
            int[] fibArr = new int[fibNumber];
            for (int i = 0; i < fibNumber; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibArr[i] = 1;
                }
                else
                {
                    fibArr[i] = fibArr[i - 2] + fibArr[i - 1];
                }
            }
            Console.WriteLine(fibArr[fibNumber - 1]);
        }
    }
}
