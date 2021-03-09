using System;
using System.Collections.Generic;
using System.Text;

namespace _2.VehiclesExtension
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;
        public Vehicle(double fuelQuantity, double consumptionPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.ConsumptionPerKm = consumptionPerKm;
            if(fuelQuantity > this.TankCapacity)
            {
                fuelQuantity = 0;
            }

            this.FuelQuantity = fuelQuantity;
        }
        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                this.fuelQuantity = value;
            }
        }
        public double ConsumptionPerKm { get; protected set; }

        public double TankCapacity { get; protected set; }

        public virtual void Drive(double kilometers)
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

        public virtual void Refuel(double liters)
        {
            if(liters <= 0) 
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
