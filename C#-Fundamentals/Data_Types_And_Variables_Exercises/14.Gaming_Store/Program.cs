using System;

namespace _14.Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBalance = double.Parse(Console.ReadLine());
            double moneySpent = 0.0;


            while (true)
            {
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                string gameName = Console.ReadLine();
                if (gameName == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${currentBalance:f2}");
                    break;
                }
                else if (gameName == "OutFall 4")
                {
                    if (currentBalance < 39.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        currentBalance -= 39.99;
                        moneySpent += 39.99;
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (currentBalance < 15.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        currentBalance -= 15.99;
                        moneySpent += 15.99;
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (currentBalance < 19.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        currentBalance -= 19.99;
                        moneySpent += 19.99;
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (currentBalance < 59.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        currentBalance -= 59.99;
                        moneySpent += 59.99;
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (currentBalance < 29.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                        currentBalance -= 29.99;
                        moneySpent += 29.99;
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (currentBalance < 39.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        currentBalance -= 39.99;
                        moneySpent += 39.99;
                    }
                }
                else Console.WriteLine("Not Found");
            }
        }
    }
}
