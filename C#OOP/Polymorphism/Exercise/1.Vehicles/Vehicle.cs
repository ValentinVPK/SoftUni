using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double consumptionPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.ConsumptionPerKm = consumptionPerKm;
        }
        public double FuelQuantity { get; protected set; }
        public double ConsumptionPerKm { get; protected set; }

        public void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.ConsumptionPerKm;

            if (this.FuelQuantity < fuelNeeded)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.FuelQuantity -= fuelNeeded;
                Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
            }
        }

        public abstract void Refuel(double liters);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
