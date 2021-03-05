using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Telephony
{

    public class Smartphone : ICallable, IBrowsable
    {
        public void Browse(string link)
        {
            if (link.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {link}!");
            }
        }

        public void Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {number}");
            }
        }
    }
}
