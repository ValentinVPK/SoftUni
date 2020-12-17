using System;
using System.Collections.Generic;

namespace _3.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                string[] songAtributes = Console.ReadLine().Split("_");
                Song newSong = new Song();
                newSong.TypeList = songAtributes[0];
                newSong.Name = songAtributes[1];
                newSong.Time = songAtributes[2];
                songs.Add(newSong);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
