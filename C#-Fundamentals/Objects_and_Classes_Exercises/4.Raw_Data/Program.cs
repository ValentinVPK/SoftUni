using System;
using System.Collections.Generic;

namespace _4.Raw_Data
{
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
    }

    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
    }
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
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
                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInformation[0];
                int engineSpeed = int.Parse(carInformation[1]);
                int enginePower = int.Parse(carInformation[2]);
                int cargoWeight = int.Parse(carInformation[3]);
                string cargoType = carInformation[4];
                Car currentCar = new Car(carModel, engineSpeed, enginePower, cargoWeight, cargoType);
                listOfCars.Add(currentCar);
            }

            string command = Console.ReadLine();
            foreach (Car car in listOfCars)
            {
                if (command == "flamable" && command == car.Cargo.CargoType && car.Engine.EnginePower > 250)
                {
                    Console.WriteLine(car.Model);
                }
                else if (command == "fragile" && command == car.Cargo.CargoType && car.Cargo.CargoWeight < 1000)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
