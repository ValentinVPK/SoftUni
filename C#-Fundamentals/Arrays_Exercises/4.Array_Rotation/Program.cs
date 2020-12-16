using System;
using System.Linq;

namespace _4.Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tmp = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[arr.Length - 1] = tmp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
