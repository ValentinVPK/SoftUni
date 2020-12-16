using System;
using System.Linq;
using System.Linq.Expressions;

namespace _3.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int[] additionalArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    arr1[i] = additionalArr[0];
                    arr2[i] = additionalArr[1];
                }
                else
                {
                    int[] additionalArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    arr1[i] = additionalArr[1];
                    arr2[i] = additionalArr[0];
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
