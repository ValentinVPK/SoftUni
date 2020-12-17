using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            int productCount = 1;
            foreach (string product in products)
            {
                Console.WriteLine($"{productCount}.{product}");
                productCount++;
            }
        }
    }
}
