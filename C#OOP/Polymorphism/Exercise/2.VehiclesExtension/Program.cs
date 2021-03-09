using System;

namespace _2.VehiclesExtension
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] truckTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] busTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
            Vehicle truck = new Truck(double.Parse(truckTokens[1]),
                double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
            Bus bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                string vehicle = input[1];
                double value = double.Parse(input[2]);

                try
                {
                    if (vehicle == "Car")
                    {
                        if (command == "Drive")
                        {
                            car.Drive(value);
                        }
                        else if(command == "Refuel")
                        {
                            car.Refuel(value);
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        if (command == "Drive")
                        {
                            truck.Drive(value);
                        }
                        else if (command == "Refuel")
                        {
                            truck.Refuel(value);
                        }
                    }
                    else if (vehicle == "Bus")
                    {
                        if (command == "Drive")
                        {
                            bus.ContainsPeople = true;
                            bus.Drive(value);
                            bus.ContainsPeople = false;
                        }
                        else if(command == "DriveEmpty")
                        {
                            bus.Drive(value);
                        }
                        else if (command == "Refuel")
                        {
                            bus.Refuel(value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
