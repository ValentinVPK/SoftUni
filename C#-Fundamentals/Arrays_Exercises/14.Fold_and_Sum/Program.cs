using System;
using System.Linq;

namespace _14.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = inputArray.Length / 4;
            int count = 0;

            // first row

            int[] firstRow = new int[inputArray.Length / 2];

            // left part

            for (int i = k - 1; i >= 0; i--)
            {
                firstRow[count] = inputArray[i];
                count++;
            }
            // right part

            for (int j = inputArray.Length - 1; j >= inputArray.Length * 3 / 4; j--)
            {
                firstRow[count] = inputArray[j];
                count++;
            }

            // second row

            int[] secondRow = new int[inputArray.Length / 2];
            count = 0;
            for (int h = inputArray.Length * 1 / 4; h < inputArray.Length * 3 / 4; h++)
            {
                secondRow[count] = inputArray[h];
                count++;
            }

            // summing the first and the second row

            int[] summedArray = new int[inputArray.Length / 2];

            for (int s = 0; s < inputArray.Length / 2; s++)
            {
                int sum = firstRow[s] + secondRow[s];
                summedArray[s] = sum;
            }
            Console.WriteLine(string.Join(" ", summedArray));
        }
    }
}
