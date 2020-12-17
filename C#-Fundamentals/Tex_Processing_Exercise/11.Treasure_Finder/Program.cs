using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;

            while ((input = Console.ReadLine()) != "find")
            {
                //Finding the hidden message
                int keyIndex = 0;
                StringBuilder hiddenMessage = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    if (keyIndex == key.Length) keyIndex = 0;
                    char current = (char)((int)input[i] - key[keyIndex]);
                    keyIndex++;
                    hiddenMessage.Append(current);
                }
                string hiddenMessageStr = hiddenMessage.ToString();

                // Finding the name:
                int firstIndex = hiddenMessageStr.IndexOf('&');
                int firstLength = hiddenMessageStr.LastIndexOf('&') - firstIndex - 1;
                string name = hiddenMessageStr.Substring(firstIndex + 1, firstLength);

                // Finding the coordinates:

                int secondIndex = hiddenMessageStr.IndexOf('<');
                int secondLength = hiddenMessageStr.LastIndexOf('>') - secondIndex - 1;
                string coordinates = hiddenMessageStr.Substring(secondIndex + 1, secondLength);

                Console.WriteLine($"Found {name} at {coordinates}");
            }
        }
    }
}
