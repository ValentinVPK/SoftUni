using System;

namespace _7.Contact_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string sentence = firstName + delimiter + lastName;
            Console.WriteLine(sentence);
        }
    }
}
