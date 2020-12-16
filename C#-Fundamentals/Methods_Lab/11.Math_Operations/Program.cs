using System;

namespace _11.Math_Operations
{
    class Program
    {
        public static double Calculation(int a, string operation, int b)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Calculation(a, operation, b);
            Console.WriteLine(result);
        }
    }
}
