using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }
        private List<Car> cars;
        private int capacity;

        public int Count 
        {
            get { return this.cars.Count; }
        }

        public string AddCar(Car car)
        {
            if(this.cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if(this.cars.Count == this.capacity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = this.cars
                .FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

            if(car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.cars.Remove(car);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            Car car = this.cars
                .FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            this.cars = this.cars
                .Where(x => !registrationNumbers.Contains(x.RegistrationNumber)).ToList();
        }
    }
}
