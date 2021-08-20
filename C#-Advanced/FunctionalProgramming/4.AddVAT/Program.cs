using System;
using System.Linq;

namespace _4.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = n => double.Parse(n);
            double[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).Select(n => n + 20 * 1.0/100 * n).ToArray();

            foreach(double number in arr)
            {
                Console.WriteLine($"{number:f2}");
            }
        }      
    }
}
