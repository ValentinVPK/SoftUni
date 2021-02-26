using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] ordersInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(ordersInput);
            Console.WriteLine(orders.Max());

            while(true)
            {
                if(orders.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
                int currOrder = orders.Peek();
                if(currOrder <= foodQuantity)
                {
                    orders.Dequeue();
                    foodQuantity -= currOrder;
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(' ', orders));
                    break;
                }
            }
        }
    }
}
