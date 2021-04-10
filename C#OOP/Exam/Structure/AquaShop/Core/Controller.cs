using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aqua = null;
            if(aquariumType == "FreshwaterAquarium")
            {
                aqua = new FreshwaterAquarium(aquariumName);
            }
            if (aquariumType == "SaltwaterAquarium")
            {
                aqua = new SaltwaterAquarium(aquariumName);
            }

            if (aqua == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            aquariums.Add(aqua);

            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration dec = null;
            if(decorationType == "Ornament")
            {
                dec = new Ornament();
            }
            if (decorationType == "Plant")
            {
                dec = new Plant();
            }

            if(dec == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            decorations.Add(dec);

            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = null;
            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }

            if(fish == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            IAquarium seachedAqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if(seachedAqua.GetType().Name == "SaltwaterAquarium" && fishType == "FreshwaterFish")
            {
                return $"Water not suitable.";
            }
            if (seachedAqua.GetType().Name == "FreshwaterAquarium" && fishType == "SaltwaterFish")
            {
                return $"Water not suitable.";
            }

            seachedAqua.AddFish(fish);
            return $"Successfully added {fishType} to {aquariumName}.";
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium seachedAqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal value = 0;
            value = seachedAqua.Fish.Sum(f => f.Price) + seachedAqua.Decorations.Sum(d => d.Price);

            return $"The value of Aquarium {aquariumName} is {value:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium seachedAqua = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            seachedAqua.Feed();

            return $"Fish fed: {seachedAqua.Fish.Count}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            if(decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
            if(decorations.FindByType(decorationType) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
            IDecoration searchedDec = decorations.FindByType(decorationType);

            aquariums.First(a => a.Name == aquariumName).Decorations.Add(searchedDec);
            decorations.Remove(searchedDec);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            string result = "";

            foreach(var aqua in aquariums)
            {
                result += aqua.GetInfo();
            }

            return result.Trim();
        }
    }
}
