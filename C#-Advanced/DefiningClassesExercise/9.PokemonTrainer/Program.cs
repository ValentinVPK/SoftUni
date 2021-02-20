using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
       {
            string input;
            List<Trainer> trainers = new List<Trainer>();
            while((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                Pokemon currPokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
                if(trainers.Any(x => x.Name == trainerName))
                {
                    int index = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[index].Collection.Add(currPokemon);
                }
                else
                {
                    trainers.Add(new Trainer(trainerName, currPokemon));
                }
            }

            while((input = Console.ReadLine()) != "End")
            {
                foreach(Trainer trainer in trainers)
                {
                    if(trainer.Collection.Any(x => x.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for(int i = 0; i < trainer.Collection.Count; i++)
                        {
                            trainer.Collection[i].Health -= 10;
                            if(trainer.Collection[i].Health <= 0)
                            {
                                trainer.Collection.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }


            foreach(Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Collection.Count}");
            }
       }
    }
}
