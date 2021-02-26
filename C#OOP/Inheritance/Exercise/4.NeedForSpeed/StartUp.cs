using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car fiat = new Car(60, 300);

            Console.WriteLine(fiat.DefaultFuelConsumption);
        }
    }
}
