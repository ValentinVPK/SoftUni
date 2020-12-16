using System;

namespace _4.Tribonacci_Sequence
{
    class Program
    {
        public static int[] GetTribonacciArray(int num)
        {
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        arr[i] = 1;
                        break;
                    case 1:
                        arr[i] = 1;
                        break;
                    case 2:
                        arr[i] = 2;
                        break;
                    default:
                        arr[i] = arr[i - 3] + arr[i - 2] + arr[i - 1];
                        break;
                }
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = GetTribonacciArray(num);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
