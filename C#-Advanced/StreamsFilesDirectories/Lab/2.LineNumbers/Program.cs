using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using(StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    int line = 1;
                    string currentLine = reader.ReadLine();
                    while (currentLine != null)
                    {
                        writer.WriteLine($"{line}. {currentLine}");
                        line++;
                        currentLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
