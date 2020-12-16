using System;

namespace _1.Data_Types
{
    class Program
    {
        public static int MultiplyBy2(int number)
        {
            return number * 2;
        }

        public static double MultiplyBy1point5(double number)
        {
            return number * 1.5;
        }

        public static string SuroundWithDollars(string word)
        {
            return "$" + word + "$";
        }
        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();

            switch (typeOfVariable)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(MultiplyBy2(number));
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{MultiplyBy1point5(realNumber):f2}");
                    break;
                case "string":
                    string word = Console.ReadLine();
                    Console.WriteLine(SuroundWithDollars(word));
                    break;
            }
        }
    }
}
