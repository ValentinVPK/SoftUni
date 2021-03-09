using System;
using System.Collections.Generic;
using System.Text;

namespace _2.VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double consumptionPerKm, double tankCapacity)
            : base(fuelQuantity, consumptionPerKm , tankCapacity)
        {

        }

        public bool ContainsPeople { get; set; }

        public override void Drive(double kilometers)
        {
            if (ContainsPeople) this.ConsumptionPerKm += 1.4;
            base.Drive(kilometers);

            this.ConsumptionPerKm -= 1.4;
        }
    }
}
