using System;

namespace _6.Calculate_Rectangle_Area
{
    class Program
    {
        public static int Rectangle(int length, int width)
        {
            int result = length * width;
            return result;
        }
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine(Rectangle(length, width));
        }
    }
}
