using System;
using System.IO;
using System.Linq;

namespace _1.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                int count = 0;
                string currLine = reader.ReadLine();

                while(currLine != null)
                {
                    if(count % 2 == 0)
                    {
                        currLine = currLine.Replace("-", "@").Replace(",", "@")
                            .Replace(".", "@")
                            .Replace("!", "@")
                            .Replace("?", "@");

                        string[] arr = currLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        for (int i = arr.Length - 1; i >= 0; i--)
                        {
                            Console.Write(arr[i] + " ");
                        }

                        Console.WriteLine();
                    }

                    count++;
                    currLine = reader.ReadLine();
                }
            }
        }
    }
}
