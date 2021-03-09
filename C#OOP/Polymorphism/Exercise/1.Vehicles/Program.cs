using System;

namespace _1.Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] truckTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
            Vehicle truck = new Truck(double.Parse(truckTokens[1]), 
                double.Parse(truckTokens[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                string vehicle = input[1];
                double value = double.Parse(input[2]);

                if(command == "Drive")
                {
                    if(vehicle == "Car")
                    {
                        car.Drive(value);
                    }
                    else
                    {
                        truck.Drive(value);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(value);
                    }
                    else
                    {
                        truck.Refuel(value);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
