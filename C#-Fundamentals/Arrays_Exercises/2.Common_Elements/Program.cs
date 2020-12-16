using System;

namespace _2.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            foreach (string element2 in arr2)
            {
                foreach (string element1 in arr1)
                {
                    if (element2 == element1)
                    {
                        Console.Write(element2 + " ");
                    }
                }
            }
        }
    }
}
