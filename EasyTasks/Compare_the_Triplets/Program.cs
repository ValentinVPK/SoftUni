using System;
using System.Linq;

namespace Compare_the_Triplets
{
    class Program
    {
        static int[] compareTriplets(int[] inputArray1, int[] inputArray2)
        {
            int aPoints = 0;
            int bPoints = 0;
            for (int i = 0; i < inputArray1.Length; i++)
            {
                if(inputArray1[i] > inputArray2[i])
                {
                    aPoints++;
                } 
                else if(inputArray1[i] < inputArray2[i])
                {
                    bPoints++;
                }
            }

            return new int[] { aPoints, bPoints };
        }
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(" ",compareTriplets(arr1,arr2)));
        }
    }
}
