using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double consumptionPerKm)
            :base(fuelQuantity, consumptionPerKm + 1.6)
        {

        }
        public override void Refuel(double liters)
        {
            this.FuelQuantity += (95 / 100.0) * liters;
        }
    }
}
