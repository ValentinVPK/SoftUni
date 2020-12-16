using System;

namespace _7.Repeat_String
{
    class Program
    {
        public static string RepeatedString(string str, int num)
        {
            string result = string.Empty;

            for (int i = 0; i < num; i++)
            {
                result += str;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(str, num));
        }
    }
}
