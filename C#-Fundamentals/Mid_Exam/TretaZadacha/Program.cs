using System;
using System.Collections.Generic;
using System.Linq;

namespace TretaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> premiumVehicles = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int number = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= number; i++)
            {
                string[] commandArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string method = commandArr[0];

                if(method == "Add")
                {
                    string cardName = commandArr[1];
                    if (premiumVehicles.Contains(cardName)) Console.WriteLine("Card is already bought");
                    else
                    {
                        Console.WriteLine("Card successfully bought");
                        premiumVehicles.Add(cardName);
                    }
                }
                else if(method == "Remove")
                {
                    string cardName = commandArr[1];

                    if (premiumVehicles.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully sold");
                        premiumVehicles.Remove(cardName);
                    }
                    else Console.WriteLine("Card not found");
                }
                else if(method == "Remove At")
                {
                    int index = int.Parse(commandArr[1]);
                    if (index < 0 || index >= premiumVehicles.Count) Console.WriteLine("Index out of range");
                    else
                    {
                        Console.WriteLine("Card successfully sold");
                        premiumVehicles.RemoveAt(index);
                    }
                }
                else if(method == "Insert")
                {
                    int index = int.Parse(commandArr[1]);
                    string cardName = commandArr[2];

                    if (index < 0 || index >= premiumVehicles.Count) Console.WriteLine("Index out of range");
                    else
                    {
                        if (premiumVehicles.Contains(cardName)) Console.WriteLine("Card is already bought");
                        else
                        {
                            Console.WriteLine("Card successfully bought");
                            premiumVehicles.Insert(index, cardName);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", premiumVehicles));
        }
    }
}
