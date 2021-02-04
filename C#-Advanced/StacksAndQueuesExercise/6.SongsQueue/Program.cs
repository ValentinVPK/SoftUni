using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(songsInput);

            while(songs.Count > 0)
            {
                string command = Console.ReadLine();
                if(command == "Play")
                {
                    songs.Dequeue();
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                else if(command[0] == 'A')
                {
                    string currSong = command.Substring(4);
                    if(!songs.Contains(currSong))
                    {
                        songs.Enqueue(currSong);
                    }
                    else
                    {
                        Console.WriteLine($"{currSong} is already contained!");
                    }
                    
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
