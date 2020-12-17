using System;

namespace _1.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');


            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(0, words.Length);
                string wordAtPos1 = words[pos1];

                words[pos1] = words[pos2];
                words[pos2] = wordAtPos1;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
