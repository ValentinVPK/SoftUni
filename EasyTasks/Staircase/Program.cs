using System;
using System.Text;

namespace Staircase
{
    class Program
    {
        static void staircase(int number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= number; i++)
            {
                for(int j = number - i; j >= 1; j--)
                {
                    sb.Append(' ');
                }

                for (int h = 0; h < i; h++)
                {
                    sb.Append('#');
                }

                sb.Append('\n');
            }

            Console.WriteLine(sb);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            staircase(number);
        }
    }
}
