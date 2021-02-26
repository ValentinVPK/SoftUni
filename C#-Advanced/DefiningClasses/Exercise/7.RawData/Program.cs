using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0;  i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine currEngine = new Engine(int.Parse(tokens[1]), int.Parse(tokens[2]));
                Cargo currCargo = new Cargo(int.Parse(tokens[3]), tokens[4]);
                Tire currTire1 = new Tire(double.Parse(tokens[5]), int.Parse(tokens[6]));
                Tire currTire2 = new Tire(double.Parse(tokens[7]), int.Parse(tokens[8]));
                Tire currTire3 = new Tire(double.Parse(tokens[9]), int.Parse(tokens[10]));
                Tire currTire4 = new Tire(double.Parse(tokens[11]), int.Parse(tokens[12]));

                cars.Add(new Car(tokens[0], currEngine, currCargo, currTire1, currTire2, currTire3, currTire4));
            }

            string input = Console.ReadLine();

            if(input == "fragile")
            {
                foreach(Car car in cars.Where(x => x.Cargo.Type == "fragile" && (x.Tires[0].Pressure < 1) || x.Tires[1].Pressure < 1 || x.Tires[2].Pressure < 1 || x.Tires[3].Pressure < 1))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if(input == "flamable")
            {
                foreach(Car car in cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
