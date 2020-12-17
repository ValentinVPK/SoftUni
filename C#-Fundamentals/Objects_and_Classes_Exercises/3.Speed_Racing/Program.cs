using System;
using System.Collections.Generic;
using System.Data;

namespace _3.Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public int TraveledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TraveledDistance = 0;
        }

        public void DriveCar(int amountOfKm)
        {
            double neededFuel = FuelConsumptionPerKilometer * amountOfKm;

            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            for (int i = 1; i <= number; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car currentCar = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                listOfCars.Add(currentCar);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] driveCar = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = driveCar[1];
                int amountOfKm = int.Parse(driveCar[2]);

                foreach (Car car in listOfCars)
                {
                    if (car.Model == carModel)
                    {
                        car.DriveCar(amountOfKm);
                    }
                }
            }

            foreach (Car car in listOfCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
