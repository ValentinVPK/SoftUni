using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double consumptionPerKm)
            :base(fuelQuantity, consumptionPerKm + 0.9)
        {

        }
        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}
