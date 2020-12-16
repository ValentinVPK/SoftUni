using System;

namespace _7.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            string command = Console.ReadLine();

            while (command != "Start")
            {
                double insertedCoin = double.Parse(command);
                if (insertedCoin != 0.1 && insertedCoin != 0.2 && insertedCoin != 0.5 && insertedCoin != 1 && insertedCoin != 2)
                {
                    Console.WriteLine($"Cannot accept {insertedCoin}");
                }
                else sum += insertedCoin;
                command = Console.ReadLine();
            }

            while (true)
            {
                string item = Console.ReadLine();
                if (item == "End")
                {
                    double moneyLeft = sum;
                    Console.WriteLine($"Change: {moneyLeft:f2}");
                    break;
                }
                else if (item == "Nuts")
                {
                    if (sum < 2) Console.WriteLine("Not enough money");
                    else
                    {
                        Console.WriteLine($"Purchased nuts");
                        sum -= 2;
                    }
                }
                else if (item == "Water")
                {
                    if (sum < 0.7) Console.WriteLine("Sorry, not enough money");
                    else
                    {
                        Console.WriteLine($"Purchased water");
                        sum -= 0.7;
                    }
                }
                else if (item == "Crisps")
                {
                    if (sum < 1.5) Console.WriteLine("Sorry, not enough money");
                    else
                    {
                        Console.WriteLine($"Purchased crisps");
                        sum -= 1.5;
                    }
                }
                else if (item == "Soda")
                {
                    if (sum < 0.8) Console.WriteLine("Sorry, not enough money");
                    else
                    {
                        Console.WriteLine($"Purchased soda");
                        sum -= 0.8;
                    }
                }
                else if (item == "Coke")
                {
                    if (sum < 1) Console.WriteLine("Sorry, not enough money");
                    else
                    {
                        Console.WriteLine($"Purchased coke");
                        sum -= 1;
                    }
                }
                else Console.WriteLine("Invalid product");
            }
    }
}
