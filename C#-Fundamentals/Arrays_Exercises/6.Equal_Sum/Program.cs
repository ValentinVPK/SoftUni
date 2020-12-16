using System;
using System.Linq;

namespace _6.Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool areEqual = false;
            int centeredNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                for (int j = 0; j < i; j++)
                {
                    if (i == 0) leftSum = 0;
                    else leftSum += arr[j];
                }
                for (int h = i + 1; h < arr.Length; h++)
                {
                    if (i == arr.Length - 1) rightSum = 0;
                    else rightSum += arr[h];
                }
                if (leftSum == rightSum)
                {
                    areEqual = true;
                    centeredNumber = i;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (areEqual)
            {
                Console.WriteLine(centeredNumber);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
