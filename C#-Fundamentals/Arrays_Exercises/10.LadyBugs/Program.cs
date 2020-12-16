using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialField = new int[fieldSize];

            int[] bugsPositions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //place the bugs on the field
            for (int i = 0; i < bugsPositions.Length; i++)
            {
                if (bugsPositions[i] < fieldSize && bugsPositions[i] >= 0)
                {
                    initialField[bugsPositions[i]] = 1;
                }

            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugInitialPosition = int.Parse(commandArray[0]);
                string direction = commandArray[1];
                int ladyBugMoves = int.Parse(commandArray[2]);
                // Checking if the length is a negative number
                if (ladyBugMoves < 0 && direction == "right")
                {
                    direction = "left";
                    ladyBugMoves = Math.Abs(ladyBugMoves);
                }
                else if (ladyBugMoves < 0 && direction == "left")
                {
                    direction = "right";
                    ladyBugMoves = Math.Abs(ladyBugMoves);
                }

                // Checking if the index is inside the field or there isnt already a lady bug in place
                if (ladyBugInitialPosition < 0 || ladyBugInitialPosition >= fieldSize || initialField[ladyBugInitialPosition] == 0)
                {
                    continue;
                }

                if (ladyBugMoves == 0)
                {
                    initialField[ladyBugInitialPosition] = 1;
                    continue;
                }

                if (direction == "right")
                {
                    initialField[ladyBugInitialPosition] = 0;
                    for (int newPosition = ladyBugInitialPosition + ladyBugMoves; newPosition < int.MaxValue; newPosition += ladyBugMoves)
                    {
                        if (newPosition >= fieldSize)
                        {
                            break;
                        }
                        else if (initialField[newPosition] == 1)
                        {
                            continue;
                        }
                        else if (initialField[newPosition] == 0)
                        {
                            initialField[newPosition] = 1;
                            break;
                        }
                    }
                }
                else if (direction == "left")
                {
                    initialField[ladyBugInitialPosition] = 0;
                    for (int newPosition = ladyBugInitialPosition - ladyBugMoves; newPosition > int.MinValue; newPosition -= ladyBugMoves)
                    {
                        if (newPosition < 0)
                        {
                            break;
                        }
                        else if (initialField[newPosition] == 1)
                        {
                            continue;
                        }
                        else if (initialField[newPosition] == 0)
                        {
                            initialField[newPosition] = 1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", initialField));
        }
    }
}
