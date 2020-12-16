using System;
using System.Collections.Generic;
using System.Linq;


namespace _9.Greater_of_Two_Values
{
    class Program
    {
        public static string GetMax(string typeOfVariable, string firstInput, string secondInput)
        {
            switch (typeOfVariable)
            {
                case "int":
                    if (int.Parse(firstInput) > int.Parse(secondInput)) return firstInput;
                    else return secondInput;
                case "char":
                    if (char.Parse(firstInput) > char.Parse(secondInput)) return firstInput;
                    else return secondInput;
                case "string":
                    List<string> lis = new List<string>();
                    lis.Add(firstInput);
                    lis.Add(secondInput);
                    return lis.Max();
                default:
                    return string.Empty;
            }
        }
        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            Console.WriteLine(GetMax(typeOfVariable, firstInput, secondInput));
        }
    }
}
