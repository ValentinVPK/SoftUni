using System;

namespace _3.Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone statPhone = new StationaryPhone();

            foreach(string number in numbers)
            {
                if(number.Length == 10)
                {
                    smartphone.Call(number);
                }
                else
                {
                    statPhone.Call(number);
                }
            }

            foreach(string url in urls)
            {
                smartphone.Browse(url);
            }
        }
    }
}
