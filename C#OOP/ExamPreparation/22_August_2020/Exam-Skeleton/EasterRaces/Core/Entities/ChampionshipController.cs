using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IDriver> driverRepository;
        private readonly IRepository<ICar> carRepository;
        private readonly IRepository<IRace> raceRepository;
        public ChampionshipController()
        {
            this.driverRepository = new DriverRepository();
            this.carRepository = new CarRepository();
            this.raceRepository = new RaceRepository();
        }
        public string AddCarToDriver(string driverName, string carModel)
        {
            var driver = driverRepository.GetByName(driverName);
            var car = carRepository.GetByName(carModel);

            if(driver == null)
            {
                throw new ArgumentException($"Driver {driverName} could not be found.");
            }
            if(car == null)
            {
                throw new ArgumentException($"Car {carModel} could not be found.");
            }

            driver.AddCar(car);
            //this.carRepository.Remove(car); // ???
            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            var race = raceRepository.GetByName(raceName);
            var driver = driverRepository.GetByName(driverName);

            if (race == null)
            {
                throw new ArgumentException($"Race {raceName} could not be found.");
            }
            if (driver == null)
            {
                throw new ArgumentException($"Driver {driverName} could not be found.");
            }

            race.AddDriver(driver);
            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            var carExists = carRepository.GetByName(model);
            if(carExists != null)
            {
                throw new ArgumentException($"Car {model} is already created.");
            }

            ICar car = null;
            if(type == "Muscle")
            {
                car = new MuscleCar(model,horsePower);
            }
            if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            carRepository.Add(car);
            return $"{car.GetType().Name} {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = new Driver(driverName);
            IDriver exisingDriver = driverRepository.GetByName(driverName);
            if(exisingDriver == null)
            {
                driverRepository.Add(driver);
                return $"Driver {driverName} is created.";
            }
            else
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }
        }

        public string CreateRace(string name, int laps)
        {
            var raceExist = raceRepository.GetByName(name);
            if(raceExist != null)
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }

            var race = new Race(name, laps);
            raceRepository.Add(race);
            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            var race = raceRepository.GetByName(raceName);
            if(race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if(race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }


            List<IDriver> top3 = race.Drivers.OrderByDescending(d => d.Car.CalculateRacePoints(race.Laps)).ToList();

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Driver {top3[0].Name} wins {race.Name} race.");
            result.AppendLine($"Driver {top3[1].Name} is second in {race.Name} race.");
            result.AppendLine($"Driver {top3[2].Name} is third in {race.Name} race.");

            this.raceRepository.Remove(race);

            return result.ToString().TrimEnd();
        }
    }
}
