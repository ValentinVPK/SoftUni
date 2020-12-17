using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string playerName = tokens[0];
                    string playerPosition = tokens[1];
                    int playerPoints = int.Parse(tokens[2]);

                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(playerPosition))
                        {
                            if (players[playerName][playerPosition] < playerPoints)
                            {
                                totalPoints[playerName] = totalPoints[playerName] - players[playerName][playerPosition] + playerPoints;
                                players[playerName][playerPosition] = playerPoints;
                            }
                        }
                        else
                        {
                            players[playerName].Add(playerPosition, playerPoints);
                            totalPoints[playerName] = totalPoints[playerName] + playerPoints;
                        }
                    }
                    else
                    {
                        players.Add(playerName, new Dictionary<string, int>());
                        players[playerName].Add(playerPosition, playerPoints);

                        totalPoints.Add(playerName, playerPoints);
                    }
                }
                else
                {
                    string[] tokens = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string playerOne = tokens[0];
                    string playerTwo = tokens[1];

                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        foreach (var positionAndPointsOne in players[playerOne])
                        {
                            foreach (var positionAndPointsTwo in players[playerTwo])
                            {
                                if (positionAndPointsOne.Key == positionAndPointsTwo.Key)
                                {
                                    string position = positionAndPointsOne.Key;
                                    if (players[playerOne][position] < players[playerTwo][position])
                                    {
                                        totalPoints[playerOne] = totalPoints[playerOne] - players[playerOne][position];
                                        players[playerOne].Remove(position);
                                    }
                                    else if (players[playerOne][position] > players[playerTwo][position])
                                    {
                                        totalPoints[playerTwo] = totalPoints[playerTwo] - players[playerTwo][position];
                                        players[playerTwo].Remove(position);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var player in totalPoints.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                if (player.Value == 0) continue;
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var positionAndPoints in players[player.Key].OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {positionAndPoints.Key} <::> {positionAndPoints.Value}");
                }
            }
        }
    }
}
