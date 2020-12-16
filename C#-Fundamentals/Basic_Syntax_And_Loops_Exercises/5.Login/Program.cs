using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string nickname = Console.ReadLine();
            string password = "";
            int failedAttemps = 0;
            for (int i = nickname.Length - 1; i >= 0; i--)
            {
                password = password + nickname[i];
            }
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput != password)
                {
                    failedAttemps++;
                    if (failedAttemps == 4)
                    {
                        Console.WriteLine($"User {nickname} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {nickname} logged in.");
                    break;
                }
            }
        }
    }
}
