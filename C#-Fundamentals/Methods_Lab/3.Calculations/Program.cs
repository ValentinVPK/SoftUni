using System;

namespace _3.Calculations
{
    class Program
    {
        static void Calculator(string command, int firstNumber, int secondNumber)
        {
            switch (command)
            {
                case "add":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "substract":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "multiply":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "divide":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Calculator(command, firstNumber, secondNumber);
        }
    }
}
