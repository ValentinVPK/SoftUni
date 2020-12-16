using System;

namespace _6.Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numberInt = Convert.ToInt32(number);
            int sumOfFactorials = 0;
            int fact = 1;
            foreach (char ch in number)
            {
                int currentNumber = ch - 48;
                for (int i = 1; i <= currentNumber; i++)
                {
                    fact *= i;
                }
                sumOfFactorials += fact;
                fact = 1;
            }
            if (numberInt == sumOfFactorials)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
