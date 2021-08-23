using System;

namespace GenericScale
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int> eq= new EqualityScale<int>(4,5);

            Console.WriteLine(eq.AreEqual());
        }
    }
}
