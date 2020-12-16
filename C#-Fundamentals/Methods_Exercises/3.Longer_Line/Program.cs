using System;

namespace _3.Longer_Line
{
    class Program
    {
        public static void PrintTheLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double secondLine = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            if (firstLine >= secondLine)
            {
                double closerPoint = GetThePointClosestToTheCenter(x1, y1, x2, y2);
                if (closerPoint == x1) Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                double closerPoint = GetThePointClosestToTheCenter(x3, y3, x4, y4);
                if (closerPoint == x3) Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }

        public static double GetThePointClosestToTheCenter(double x1, double y1, double x2, double y2)
        {
            double distancePointA = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double distancePointB = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (distancePointA <= distancePointB)
            {
                return x1;
            }
            else
            {
                return x2;
            }
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintTheLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
