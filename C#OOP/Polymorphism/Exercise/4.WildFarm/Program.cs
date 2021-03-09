using System;
using System.Collections.Generic;

namespace _4.WildFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "End")
                {
                    break;
                }

                string[] parts1 = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Animal animal = CreateAnimal(parts1);

                string[] parts2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Food food = CreateFood(parts2);

                animal.ProduceSound();
                animal.Eat(food);
                animals.Add(animal);
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] parts)
        {
            string type = parts[0];

            Food food = null;

            if (type == "Meat") food = new Meat(int.Parse(parts[1]));
            else if (type == "Vegetable") food = new Vegetable(int.Parse(parts[1]));
            else if (type == "Fruit") food = new Fruit(int.Parse(parts[1]));
            else if (type == "Seeds") food = new Seeds(int.Parse(parts[1]));

            return food;
        }

        private static Animal CreateAnimal(string[] parts)
        {
            string type = parts[0];
            Animal animal = null;

            if(type == nameof(Hen))
            {
                animal = new Hen(parts[1], double.Parse(parts[2]), double.Parse(parts[3]));
            }
            else if(type == nameof(Owl))
            {
                animal = new Owl(parts[1], double.Parse(parts[2]), double.Parse(parts[3]));
            }
            else if(type == nameof(Mouse))
            {
                animal = new Mouse(parts[1], double.Parse(parts[2]), parts[3]);
            }
            else if (type == nameof(Dog))
            {
                animal = new Dog(parts[1], double.Parse(parts[2]), parts[3]);
            }
            else if (type == nameof(Cat))
            {
                animal = new Cat(parts[1], double.Parse(parts[2]), parts[3], parts[4]);
            }
            else if (type == nameof(Tiger))
            {
                animal = new Tiger(parts[1], double.Parse(parts[2]), parts[3], parts[4]);
            }

            return animal;
        }
    }
}
