using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _5.Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<int> drumsQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumsQualityTmp = new List<int>();

            foreach (int drum in drumsQuality)
            {
                drumsQualityTmp.Add(drum);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < drumsQuality.Count; i++)
                {
                    int initialDrumQuality = drumsQualityTmp[i];
                    drumsQuality[i] -= hitPower;

                    if (drumsQuality[i] <= 0)
                    {
                        int price = initialDrumQuality * 3;
                        if (savings < price)
                        {
                            drumsQuality.RemoveAt(i);
                            drumsQualityTmp.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            drumsQuality[i] = initialDrumQuality;
                            savings -= price;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumsQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
