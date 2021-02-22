using System;
using System.IO;

namespace _1.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currentLine = reader.ReadLine();
                int row = 0;
                while(currentLine != null)
                {
                    if(row % 2 == 1)
                    {
                        Console.WriteLine(currentLine);
                    }
                    currentLine = reader.ReadLine();
                    row++;
                } 
            }
        }
    }
}
