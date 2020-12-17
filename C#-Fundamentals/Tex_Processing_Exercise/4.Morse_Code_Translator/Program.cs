using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInMorseCode = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            Dictionary<string, char> textMorse = new Dictionary<string, char>()
            {
                { ".-",'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'},
                {".",'E'},
                {"..-.",'F'},
                {"--.",'G'},
                {"....",'H'},
                {"..",'I'},
                {".---",'J'},
                {"-.-",'K'},
                {".-..",'L'},
                {"--",'M'},
                {"-.",'N'},
                {"---",'O'},
                {".--.",'P'},
                {"--.-",'Q'},
                { ".-.",'R'},
                {"...",'S'},
                {"-",'T'},
                {"..-",'U'},
                {"...-",'V'},
                {".--",'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                {"--..",'Z'},
            };

            foreach (string word in wordsInMorseCode)
            {
                StringBuilder currWord = new StringBuilder();
                string[] letters = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string letter in letters)
                {
                    currWord.Append(textMorse[letter]);
                }

                result.Append(currWord.ToString());
                result.Append(' ');
            }

            Console.WriteLine(result);
        }
    }
}
