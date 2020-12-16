using System;

namespace _8.Math_Power
{
    class Program
    {
        public static double PowedNumber(double num, int times)
        {
            double result = 0d;
            if (times >= 0)
            {
                result = 1;
                for (int i = 0; i < times; i++)
                {
                    result *= num;
                }
            }
            else
            {
                result = 1;
                for (int i = 0; i < Math.Abs(times); i++)
                {
                    result *= 1.0 / num;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(PowedNumber(num, times));
        }
    }
}
