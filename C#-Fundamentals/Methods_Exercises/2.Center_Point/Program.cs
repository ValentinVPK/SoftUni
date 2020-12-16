using System;

namespace _2.Center_Point
{
    class Program
    {
        public static void PrintThePointClosestToTheCenter(double x1, double y1, double x2, double y2)
        {
            double distancePointA = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double distancePointB = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (distancePointA <= distancePointB)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintThePointClosestToTheCenter(x1, y1, x2, y2);
        }
    }
}
