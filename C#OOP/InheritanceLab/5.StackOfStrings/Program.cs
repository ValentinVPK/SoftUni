using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(new List<string> {
                "123",
                "456",
                "789",
                "Gogi"
            });

            Console.WriteLine(stack.IsEmpty());

            foreach (var item in stack) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
