using System;
using System.Linq;

namespace _5.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isBigger = true;
                int tmp = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (tmp <= arr[j]) isBigger = false;
                }
                if (isBigger) Console.Write(tmp + " ");
            }
        }
    }
}
