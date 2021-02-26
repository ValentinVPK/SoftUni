using System;
using System.IO;

namespace _4.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader1 = new StreamReader("../../../input1.txt"))
            {
                using (StreamReader reader2 = new StreamReader("../../../input2.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                    {
                        string currLine1 = reader1.ReadLine();
                        string currLine2 = reader2.ReadLine();
                        while (true)
                        {
                            if (currLine1 == null && currLine2 == null) break;

                            if (currLine1 == null) writer.WriteLine(currLine2);
                            else if (currLine2 == null) writer.WriteLine(currLine1);
                            else
                            {
                                writer.WriteLine(currLine1);
                                writer.WriteLine(currLine2);
                            }

                            currLine1 = reader1.ReadLine();
                            currLine2 = reader2.ReadLine();
                        }
                    }      
                }
            }
        }
    }
}
