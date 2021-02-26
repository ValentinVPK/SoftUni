using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelPerKm;
            this.TravelledDistance = 0;
        }

        public void DriveCar(double kmAmount)
        {
            double fuelNeeded = kmAmount * this.FuelConsumptionPerKilometer;
            if(this.FuelAmount < fuelNeeded)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= fuelNeeded;
                this.TravelledDistance += kmAmount;
            }
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
    }
}
