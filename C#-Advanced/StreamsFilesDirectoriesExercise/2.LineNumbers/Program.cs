using System;
using System.Collections.Generic;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using(StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    int count = 1;
                    string currLine = reader.ReadLine();

                    List<char> marks = new List<char>
                    {
                         '-',
                         '.',
                         ',',
                         '?',
                         ';',
                         '\'',
                         '\"' ,
                         '!'
                    };
                    while (currLine != null)
                    {
                        int letterCount = 0;
                        int marksCount = 0;
                        

                        for(int i = 0; i < currLine.Length; i++)
                        {
                            if (marks.Contains(currLine[i])) marksCount++;                        
                            
                            if ((currLine[i] >= 'a' && currLine[i] <= 'z') || (currLine[i] >= 'A' && currLine[i] <= 'Z')) letterCount++;
                        }

                        writer.WriteLine($"Line {count}: {currLine} ({letterCount})({marksCount})");
                        count++;
                        currLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
