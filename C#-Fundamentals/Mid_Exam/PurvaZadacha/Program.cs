using System;

namespace PurvaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunderForDay = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double plunderGathered = 0;

            for(int i = 1; i <= days; i++)
            {
                plunderGathered = plunderGathered + plunderForDay;

                if(i % 3 == 0)
                {
                    plunderGathered = plunderGathered + (50.0 / 100) * plunderForDay;
                }
                
                if(i % 5 == 0)
                {
                    plunderGathered = plunderGathered - (30.0 / 100) * plunderGathered;
                }
            }

            if(plunderGathered >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunderGathered:f2} plunder gained.");
            }
            else
            {
                double percentGathered = (plunderGathered / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentGathered:f2}% of the plunder.");
            }
        }
    }
}
