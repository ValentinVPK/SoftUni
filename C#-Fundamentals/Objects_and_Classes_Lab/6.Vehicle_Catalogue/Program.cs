using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Globalization;

namespace _6.Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Catalog vehicleCatalog = new Catalog();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] vehicleInformation = command.Split('/');
                string vehicleType = vehicleInformation[0];

                switch (vehicleType)
                {
                    case "Car":
                        string carBrand = vehicleInformation[1];
                        string carModel = vehicleInformation[2];
                        int carHorsePower = int.Parse(vehicleInformation[3]);

                        Car newCar = new Car()
                        {
                            Brand = carBrand,
                            Model = carModel,
                            HorsePower = carHorsePower
                        };

                        vehicleCatalog.Cars.Add(newCar);
                        break;
                    case "Truck":
                        string truckBrand = vehicleInformation[1];
                        string truckModel = vehicleInformation[2];
                        int truckWeight = int.Parse(vehicleInformation[3]);

                        Truck newTruck = new Truck()
                        {
                            Brand = truckBrand,
                            Model = truckModel,
                            Weight = truckWeight
                        };

                        vehicleCatalog.Trucks.Add(newTruck);
                        break;
                }
            }

            List<Car> sortedCarList = vehicleCatalog.Cars.OrderBy(o => o.Brand).ToList();
            List<Truck> sortedTruckList = vehicleCatalog.Trucks.OrderBy(o => o.Brand).ToList();

            // Printing the car catalog:
            Console.WriteLine("Cars:");
            foreach (Car car in sortedCarList)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            // Printing the truck catalog:

            Console.WriteLine("Trucks:");
            foreach (Truck truck in sortedTruckList)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
