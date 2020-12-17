using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int result = 0;

            int smallerCode = Math.Min((int)firstChar, (int)secondChar);
            int biggerCode = Math.Max((int)firstChar, (int)secondChar);

            foreach (char ch in input)
            {
                if ((int)ch > smallerCode && (int)ch < biggerCode)
                {
                    result += (int)ch;
                }
            }

            Console.WriteLine(result);
        }
    }
}
