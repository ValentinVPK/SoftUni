using System;

namespace _8.CollectionHierarchy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            for (int i = 0; i < tokens.Length; i++)
            {
                Console.Write($"{addCollection.AddElement(tokens[i])} ");
            }

            Console.WriteLine();
            for (int i = 0; i < tokens.Length; i++)
            {
                Console.Write($"{addRemoveCollection.AddElement(tokens[i])} ");
            }

            Console.WriteLine();
            for (int i = 0; i < tokens.Length; i++)
            {
                Console.Write($"{myList.AddElement(tokens[i])} ");
            }
            Console.WriteLine();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{addRemoveCollection.RemoveElement()} ");
            }
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.Write($"{myList.RemoveElement()} ");
            }

        }
    }
}
