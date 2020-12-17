using System;

namespace PurvaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach(string username in usernames)
            {
                bool isUsernameValid = true;
                foreach(char ch in username)
                {
                    if (!char.IsLetterOrDigit(ch) && ch != '-' && ch != '_') isUsernameValid = false;
                }
                if ((username.Length > 3 && username.Length < 16) && isUsernameValid) Console.WriteLine(username);
            }
        }
    }
}
