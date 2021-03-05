using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Telephony
{
    public class StationaryPhone : ICallable
    {
        public void Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {number}");
            }
        }
    }
}
