using System;
using System.Collections.Generic;
using System.Text;

namespace _2.VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double consumptionPerKm, double tankCapacity)
            :base(fuelQuantity, consumptionPerKm + 1.6, tankCapacity)
        {

        }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                liters = (95 / 100.0) * liters;
                this.FuelQuantity += liters;
            }
        }
    }
}
