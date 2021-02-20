using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            Console.WriteLine(DateModifier.CalculateDifference(input1, input2));
        }
    }
}
