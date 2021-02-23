using System;

namespace CustomRandomList
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("Pesho");
            list.Add("Mariq");
            list.Add("Valio");
            list.Add("Stefan");
            list.Add("Ivan");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
