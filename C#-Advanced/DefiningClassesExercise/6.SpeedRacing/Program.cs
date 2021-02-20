using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                cars.Add(new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2])));
            }

            string input;

            while((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = tokens[1];
                double kmAmount = double.Parse(tokens[2]);

                int currCarIndex = cars.FindIndex(x => x.Model == carModel);

                cars[currCarIndex].DriveCar(kmAmount);
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
