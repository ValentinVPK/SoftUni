using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int people in arr)
            {
                sum += people;
                Console.Write(people + " ");
            }

            Console.WriteLine("\n" + sum);
        }
    }
}
