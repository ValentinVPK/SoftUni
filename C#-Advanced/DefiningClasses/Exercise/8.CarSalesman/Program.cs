using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (tokens.Length == 3)
                {
                    if(tokens[2][0] >= '0' && tokens[2][0] <= '9')
                    {
                        displacement = tokens[2];
                    }
                    else
                    {
                        efficiency = tokens[2];
                    }
                }
                else if(tokens.Length == 4)
                {
                    displacement = tokens[2];
                    efficiency = tokens[3];
                }

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[0];
                string engine = tokens[1];
                string weight = "n/a";
                string color = "n/a";

                if (tokens.Length == 3)
                {
                    if (tokens[2][0] >= '0' && tokens[2][0] <= '9')
                    {
                        weight = tokens[2];
                    }
                    else
                    {
                        color = tokens[2];
                    }
                }
                else if (tokens.Length == 4)
                {
                    weight = tokens[2];
                    color = tokens[3];
                }

                int currEngineIndex = engines.FindIndex(x => x.Model == engine);

                cars.Add(new Car(model, engines[currEngineIndex], weight, color));
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model}:\n  {car.Engine.Model}:\n    Power: {car.Engine.Power}\n    Displacement: {car.Engine.Displacement}\n    Efficiency: {car.Engine.Efficiency}\n  Weight: {car.Weight}\n  Color: {car.Color}");
            }
        }
    }
}
